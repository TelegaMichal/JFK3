using Lab3_Interface_FixBug;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Reflection
{
    public partial class Form1 : Form
    {
        private Assembly assembly;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddModule(Module module, TreeNode parent)
        {
            var newNode = new TreeNode(module.Name) { Tag = module };
            parent.Nodes.Add(newNode);

            foreach (var type in module.GetTypes())
            {
                AddType(type, newNode);
            }
        }

        private void AddType(Type type, TreeNode parent)
        {
            var newNode = new TreeNode(type.Name) { Tag = type };
            var memberTypeNode = new TreeNode();
            TreeNode memberNode;

            memberTypeNode = new TreeNode("Methods");
            foreach (var method in type.GetMethods())
            {
                var count = method.GetParameters().Length;
                var stringBuilder = new StringBuilder(method.Name).Append('(');
                foreach (var param in method.GetParameters())
                {
                    stringBuilder.Append(param.ParameterType);
                    if (param.Position < count - 1)
                    {
                        stringBuilder.Append(", ");
                    }
                }

                stringBuilder.Append(')');
                memberNode = new TreeNode(stringBuilder.ToString()) { Tag = method };
                memberTypeNode.Nodes.Add(memberNode);
            }
            
            newNode.Nodes.Add(memberTypeNode);

            parent.Nodes.Add(newNode);
        }

        private void PopulateTree()
        {
            folderTree.Nodes.Clear();
            var newNode = new TreeNode(assembly.GetName().Name) { Tag = assembly };
            folderTree.Nodes.Add(newNode);

            foreach (var module in assembly.GetModules())
            {
                AddModule(module, newNode);
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            folderTree.Nodes.Clear();
            descriptionBox.Text = string.Empty;
            argumentBox.Text = string.Empty;
            resultBox.Text = string.Empty;

            string[] files = null;

            using (var folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    files = Directory.GetFiles(folder.SelectedPath);
                }
            }

            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.EndsWith("dll") || file.EndsWith("exe"))
                    {
                        assembly = Assembly.LoadFile(file);
                        PopulateTree();
                    }
                }
            }
        }

        private void FolderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            descriptionBox.Text = string.Empty;
            argumentBox.Text = string.Empty;
            resultBox.Text = string.Empty;

            if (folderTree.SelectedNode?.Tag is Type selectClass)
            {
                if (selectClass.GetCustomAttribute<DescriptionAttribute>(true) != null)
                {
                    descriptionBox.Text = selectClass.GetCustomAttribute<DescriptionAttribute>().Description;
                }

                else
                {
                    descriptionBox.Text = "Brak opisu";
                }
            }

            else
            {
                descriptionBox.Text = string.Empty;
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (folderTree?.SelectedNode != null)
            {
                var selectedType = folderTree.SelectedNode.Tag as Type;

                if (selectedType.GetInterfaces().Contains(typeof(ISimpleMathMethod)))
                {
                    if (int.TryParse(argumentBox.Text, out int number))
                    {
                        if ((Activator.CreateInstance(selectedType) is ISimpleMathMethod mathMethod))
                        {
                            int result = mathMethod.SimpleMethod(number);

                            if (result == 0)
                            {
                                resultBox.Text = "Niepoprawny argument, wprowadź ponownie argument";
                            }

                            else
                            {
                                resultBox.Text = result.ToString();
                            }
                        }

                        else
                        {
                            throw new InvalidOperationException();
                        }
                    }

                    else
                    {
                        resultBox.Text = "Niepoprawny typ argumentu";
                    }
                }  
            }
        }
    }
}
