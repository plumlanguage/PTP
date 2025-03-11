using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.IO;
using Path = System.IO.Path;
using System.Security.Policy;

namespace PTP;

public partial class MainWindow : Window
{
    public MainWindow()
    {
		// essageBox.Show("当前PTP为Beta版本，相互冲突的操作还没有添加约束！", "提示");
        InitializeComponent();
    }

	string shellText = "nuitka ";

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		// 创建一个 OpenFileDialog 实例
		OpenFileDialog openFileDialog = new OpenFileDialog();
		// 设置过滤器，只显示 .py 文件
		openFileDialog.Filter = "Python文件 (*.py)|*.py|所有文件 (*.*)|*.*";
		openFileDialog.FilterIndex = 1; // 默认选择第一个过滤器

		// 显示打开文件对话框
		if (openFileDialog.ShowDialog() == true)
		{
			// 获取选中的文件路径
			string selectedFilePath = openFileDialog.FileName;
			// MessageBox.Show("你选择的文件是: " + selectedFilePath);
			pythonFileTextBox.Text = selectedFilePath;
			// 在这里可以添加处理选中文件的逻辑
		}
	}

	private void pythonFileTextBox_TextChanged(object sender, TextChangedEventArgs e)
	{

	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (TPkgTool.SelectedIndex == 1)
		{
			C_1.IsEnabled = true;
		}
		else if (TPkgTool.SelectedIndex == 2)
		{
			MessageBox.Show("PyInstaller暂时不支持，😿喵~", "👌提示");
			TPkgTool.SelectedIndex = 1;
			// C_1.IsEnabled = false;
		}
	}

	private void TPkgButton_Click(object sender, RoutedEventArgs e)
	{
		bool TPkgPass = true;
		// 判断内容是否完善
		if(pythonFileTextBox.Text == "Python File")
		{
			TPkgPass = false;
		}
		else if(TPkgTool.SelectedIndex == 0)
		{
			TPkgPass = false;
		}
		if (!TPkgPass)
		{
			MessageBox.Show("您的配置尚未完善，这可能会导致您的项目打包失败！", "配置未完善！");
		}
		string pythonFilePath = pythonFileTextBox.Text;
		if (string.IsNullOrEmpty(pythonFilePath))
		{
			MessageBox.Show("请选择一个Python文件", "提示");
			return;
		}

		string pythonFileDirectory = Path.GetDirectoryName(pythonFilePath);
		if (string.IsNullOrEmpty(pythonFileDirectory))
		{
			MessageBox.Show("无法获取Python文件所在目录", "错误");
			return;
		}

		try
		{
			// 更改当前工作路径为Python文件所在的路径
			Directory.SetCurrentDirectory(pythonFileDirectory);
		}
		catch (Exception ex)
		{
			MessageBox.Show($"无法更改工作目录: {ex.Message}", "错误");
			return;
		}

		
		if (C_1.IsChecked == true) //使结果可移植
		{
			shellText = shellText + "--standalone ";
		}
		if (C_2.IsChecked == true) //自动删除无用文件
		{
			shellText = shellText + "--remove-output ";
		}
		if (C_3.IsChecked == true) //结果为单个exe
		{
			shellText = shellText + "--onefile ";
		}
		shellText = shellText + Path.GetFileName(pythonFilePath); // 只需要文件名，因为已经切换到文件所在目录

		using (PowerShell powerShell = PowerShell.Create())
		{
			// 添加要运行的PowerShell命令
			powerShell.AddScript(shellText);

			// 调用命令并获取输出
			Collection<PSObject> results = powerShell.Invoke();

			// 遍历输出结果并追加到 TextBox 中
			foreach (PSObject result in results)
			{
				if (result != null)
				{
					TextBoxShell.AppendText(result.ToString() + Environment.NewLine);
				}
			}

			// 检查是否有错误
			if (powerShell.HadErrors)
			{
				foreach (ErrorRecord error in powerShell.Streams.Error)
				{
					TextBoxShell.AppendText($"Error: {error.Exception.Message}" + Environment.NewLine);
				}
			}
		}
		MessageBox.Show("那个……内个，可能已经成功了，但是这个textBox还是会输出一堆奇怪的报错。\n如果您的exe可以成功运行，那就没事了。\n如果您的exe无法成功运行，就使用[合成指令]按钮进行半自动打包。", "温馨提示");

	}

	private void PrintTPkgButton_Click(object sender, RoutedEventArgs e)
	{
		string pythonFilePath = pythonFileTextBox.Text;
		if (C_1.IsChecked == true) //使结果可移植
		{
			shellText = shellText + "--standalone ";
		}
		if (C_2.IsChecked == true) //自动删除无用文件
		{
			shellText = shellText + "--remove-output ";
		}
		if (C_3.IsChecked == true) //结果为单个exe
		{
			shellText = shellText + "--onefile ";
		}
		shellText = shellText + Path.GetFileName(pythonFilePath); // 只需要文件名，因为已经切换到文件所在目录
		PrintTextBox.Text = shellText;
	}

	private void PrintTextBox_TextChanged(object sender, TextChangedEventArgs e)
	{

	}

	int DianJi = 0;

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		if (DianJi == 10)
		{
			MessageBox.Show("啊~你要干什么", "小刈");
		}
		else if (DianJi == 15)
		{
			MessageBox.Show("呃……可不可以不要动了", "小刈");
		}
		else if(DianJi == 20)
		{
			MessageBox.Show("不要……不……不行", "小刈");
		}
		else if (DianJi == 23)
		{
			MessageBox.Show("额……啊~！", "失去孩子的小刈");
		}
		else if (DianJi > 23)
		{
			MessageBox.Show("你要负责哦~舔干净！", "失去孩子的小刈");
		}
		DianJi++;
	}

	private void LYJ_Checked(object sender, RoutedEventArgs e)
	{
		LYJ_1.Visibility = Visibility.Visible;
		LYJ_2.Visibility = Visibility.Visible;
		LYJ_3.Visibility = Visibility.Visible;
		LYJ_4.Visibility = Visibility.Visible;
		LYJ_5.Visibility = Visibility.Visible;
		LYJ_6.Visibility = Visibility.Visible;
	}

	private void LYJ_Unchecked(object sender, RoutedEventArgs e)
	{
		LYJ_1.Visibility = Visibility.Hidden;
		LYJ_2.Visibility = Visibility.Hidden;
		LYJ_3.Visibility = Visibility.Hidden;
		LYJ_4.Visibility = Visibility.Hidden;
		LYJ_5.Visibility = Visibility.Hidden;
		LYJ_6.Visibility = Visibility.Hidden;
	}

	private void Button_Click_2(object sender, RoutedEventArgs e)
	{
		MessageBox.Show("如果您发现了bug可以通过以下方式联系到开发者，或者点击[前往github]自行修改!\nQQ:3840357282\n邮箱:aas0309@163.com");
	}

	private void Button_Click_3(object sender, RoutedEventArgs e)
	{
		string url = "https://github.com/plumlanguage/PTP";
		System.Diagnostics.Process.Start("explorer.exe", url);
	}

	private void Button_Click_4(object sender, RoutedEventArgs e)
	{
		string url = "https://plumlanguage.github.io/DOC/PTP.html";
		System.Diagnostics.Process.Start("explorer.exe", url);
	}

	private void Button_Click_5(object sender, RoutedEventArgs e)
	{
		MessageBox.Show("版本: Beta 3\n作者:KinichJueMe\nGithub:https://github.com/plumlanguage\n当前版本状态：不出意外的话，还会有下一个版本", "关于PTP");
	}
}