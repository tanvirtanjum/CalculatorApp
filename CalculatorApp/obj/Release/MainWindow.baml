   M S B A M L   `   `   `  ���� H  DCalculatorApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CalculatorAppCalculatorApp      CalculatorApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:CalculatorApp       � Icon$  icon.ico�� � Title$ Calculator App��$��386.4��$��413.2�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ Window��$
��Left=�$��0,0,-1.6,-4.2q�$	��408�����	#FF7D98A6 � RowDefinitions �� $
��370* ��� $��0* ��� �� $��0* � � ColumnDefinitions �� $��0* ��� �� $��0* �.+��� -    ��Name$ Flbl1��$��1st Number:��$
��Left=�$��	20,35,0,0q�$	��Top=�$	��115��$��35��$��18(�$��1���� -   $
 Slbl��$��2nd Number:��$
��Left=�$��	20,90,0,0q�$	��Top=�$	��115��$��35��$��18(�$��1���� -    ��Name$	 ftb��$��1��$
��Left=�$��30��$��
135,35,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��135��$��18(�
��������� -   $	 stb��$��1��$
��Left=�$��30��$��
135,95,0,0q�$
	 Wrap=�$	��Top=�$	��135��$��18(�
��������� -   
 ��Name$

 pBTN��$��+��$
��Left=�$��
25,155,0,0q�$	��Top=�$��55��$��45��$��24(�$
��Bold"����	#FF000157
�������
�������$��1�� �� 	IsDefault .  �� -   $

 mBTN��$��-��$��1��$
��Left=�$��125,155,0,0q�$	��Top=�$��55��$��45��$
��Bold"�$��24(�
����������	#FF000157
������� .  �� -   $
 muBTN��$��X��$��1��$
��Left=�$��225,155,0,0q�$	��Top=�$��55�����	#FF000157
�������
�������$��45��$��24(� .  �� -	   $

 dBTN��$��/��$��1��$
��Left=�$��325,155,0,0q�$	��Top=�$��55�����	#FF000157
�������
�������$��45��$��24(� .  �� -
   $
 rlbl��$��Result:��$
��Left=�$��
25,215,0,0q�$	��Top=�$��65��$��45��$��18(�$��1���� -   $	 rTB��$
��Left=�$��35��$��
90,215,0,0q�$
	 Wrap=�$	��Top=�$	��280��$��18(� �� 
IsReadOnly . $��1��
��������� -   $
 ClearBTN��$��CLEAR��$��1��$
��Left=�$��145,271,0,0q�$	��Top=�$	��140��$��34��
���  ��
���   �
�������$��18(�$
��Bold"� .  �� -   $
 closeBTN��$��2��$��Right=�$��0,2,18,0q�$	��Top=�$��40��$��33�� J� RenderTransformOrigin$ 0.5,0.5&����	#00000000����  �� Color$ 	#00000000������ .���� $��28��$��exit.png��$
��Fill=�$��37��