   M S B A M L   `   `   `  ���� >  :PTP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PTPPTP      PTP.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  localclr-namespace:PTP    � Title$  python打包器��$	��500��$	��800��.��� .+��� .@��� $��打包py文件��.��� ���	#FFE5E5E5 � ColumnDefinitions �� $	��97* ��� $
��701* �.+��� $��	10,31,0,0q�$��/python.png��$��31��$	��Top=�$
��Left=�$��27���� -    ��Name$ pythonFileTextBox��$
��Left=�$��	42,31,0,0q� �� TextWrapping$
 Wrap=�$��Python File��$	��Top=�$	��258��$��2���� -   $��浏览��$
��Left=�$��
208,30,0,0q�$	��Top=�$��30��$��1���� -    ��Name$ TPkgTool�� �� SelectedIndex$ 0��$
��Left=�$��	42,89,0,0q�$	��Top=�$	��309��$��2��@��� $$��请选择一个python打包器��${�False���� $��Nuitka���� $��PyInstaller���� $
��Left=�$��	45,13,0,0q�$
��Wrap=�$��python 文件路径��$	��Top=�$��2���� $��	10,89,0,0q�$��/zip.png��$��31��$	��Top=�$
��Left=�$��27���� $
��Left=�$��	45,70,0,0q�$
��Wrap=�$��python 打包器��$	��Top=�$��2���� $
��Left=�$��
45,131,0,0q�$
��Wrap=�$��打包配置��$	��Top=��� -    ��Name$	 C_1��$��使结果可移植��$
��Left=�$��
42,153,0,0q�$	��Top=�$��2���� -   $	 C_2��$��自动删除无用文件��$
��Left=�$��
42,174,0,0q�$	��Top=�$��2���� -   $	 C_3��$��结果为单个exe��$
��Left=�$��
42,195,0,0q�$	��Top=�$��2���� -    ��Name$ 
TPkgButton��$��打包��$
��Left=�$��599,392,0,0q�$	��Top=�$��78��$��1���� -   $ TextBoxShell��$
��Left=�$	��337��$��
259,10,0,0q�$
 Wrap=�$	��Top=�$	��418�� �� 
IsReadOnly$
 True��	 �� AcceptsReturn$
	 True��$��1���� -	   $ PrintTPkgButton��$��合成指令��$
��Left=�$��512,392,0,0q�$	��Top=�$��78��$��1���� -
   $ PrintTextBox��$
��Left=�$��302,352,0,0q�$
 Wrap=�$	��Top=�$	��375��$��1���� $
��Left=�$��271,358,0,0q�$
��Wrap=�$��输出��$	��Top=�
 J� RenderTransformOrigin$
 -0.005,0.549&�$��1���� $��相关选项��$��28��$��Bottom=�.��� ���	#FFE5E5E5.+��� $
��Left=�$��	16,13,0,0q�$
��Wrap=�$��设置微信余额��$	��Top=��� -   $��
加100 RMB��$
��Left=�$��	103,7,0,0q�$	��Top=�$	��661���� -    ��Name$ LYJ_6��$
��Left=�$	��173��$��568,113,0,0q�$	��Top=�$	��186��$��/wow.jpg��$y�Hidden=��� -    ��Name$ LYJ_1��$
��Left=�$��
52,136,0,0q�$
��Wrap=�$��是的是的，我��$	��Top=�$
 -0.077,0.662&�$y�Hidden=��� -   $ LYJ_2��$
��Left=�$��135,130,0,0q�$
��Wrap=�$��超级喜欢��$	��Top=�$
 0.5,0.5&�$��22(�$
��Bold"�$��27��$��96��$y�Hidden=�z�V� .~��� �� ��  �� Angle$ -18.022Q�T� �� -   $ LYJ_3��$
��Left=�$��
66,175,0,0q�$
��Wrap=�$��y这种类型的，如果你有这种视频（”学习“小视频更好）或者图片赶紧甩到我的邮箱，谢谢��$	��Top=�$y�Hidden=��� -   $ LYJ_4��$
��Left=�$��
40,210,0,0q�$
��Wrap=�$��aas0309@163.com��$	��Top=�$
 0.5,0.5&�$��36(�$
��Bold"�$��52��$	��367��$��	Underline{�$y�Hidden=�z�V� .~��� �� �� $ 0.497Q�T� �� -   $ LYJ_5��$
��Left=�$	��173��$��394,264,0,0q�$	��Top=�$	��186��$��/IMG_6447.JPG��$y�Hidden=��� -   $	 LYJ��$��辣眼睛模式��$
��Left=�$��
103,49,0,0q�$	��Top=�$
 0.492,0.238&�${�False���� -   $
��Left=�$��
发现BUG?��$
��Left=�$��	16,80,0,0q�$	��Top=�$	��748���� -   $
��Left=�$��前往github��$
��Left=�$��
16,113,0,0q�$	��Top=�$	��748���� -   $
��Left=�$!��前往项目集相关网页��$
��Left=�$��
16,146,0,0q�$	��Top=�$	��748���� -   $
��Left=�$��	关于PTP��$
��Left=�$��
16,179,0,0q�$	��Top=�$	��748��