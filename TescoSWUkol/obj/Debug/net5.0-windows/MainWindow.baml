   M S B A M L   `   `   `  ����F  BTescoSWUkol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TescoSWUkolTescoSWUkol  5   	       TescoSWUkol.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TescoSWUkol     5   	     � Title$  	Car Sales��5   	   $	��400��6   $	��500��6(   .��5	      �� .+�5
   
   �� -   5         ��Name$ btnLoad��5
      $��Center=�5      $��Center=�5      $��16(�5      $��Black"�5      $��Načíst data��5      ���	#FF466CEC$��80��5      $	��140��5      $��0,25,0,5q�6    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 35��65   5      5      5      �� 5   
   � 5   
   $
��Auto��5      $
��Auto��5       J� IsManipulationEnabled$ False��5      $��Center=�6-   $��Center=�6J   $��	0,25,0,25q�6e    � RowDefinitions 5      �� 5       $��* �6     � ColumnDefinitions 5"      �� 5#      $
��Auto �6#   .+�5%      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 
MyDataGrid��5%      $
��True��5&      $��Visible=�5'      $��Visible=�5(      $��0��5)      $��0��5*      
   CanUserResizeColumns$
 False��5+         CanUserResizeRows$ False��5,         CanUserAddRows$ False��5-         CanUserDeleteRows$ False��5.         
IsReadOnly$
 True��5/         AutoGenerateColumns$ False��50      
�������   RowBackground
 ����� 53      $   TescoSWUkol.GetStringConverter   GetStringConverter��%   &	          54      6/   55         Columns 56      4  .System.Windows.Controls.DataGridTemplateColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$  Název modelu
Cena bez DPH��6-      CellTemplate 58      �� 59      .R�5:   "   �� .+�5;   &   ��  ��Name$ 	modelName��60   ��6C   �� *	ModelName+�� 5<   &   $ price��60   ��6?   �� *
TotalPrice+ �� 	Converter# [  5=   #   5>      5@      0  *System.Windows.Controls.DataGridTextColumn  5B      $ 
Cena s DPH��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *TotalPriceWithDph+# [  5D      5E      5F      5H      