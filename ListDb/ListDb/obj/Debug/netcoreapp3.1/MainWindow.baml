   M S B A M L   `   `   `  ����A  =ListDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ListDbListDb  5   	       ListDb.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:ListDb     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��450��6)    � 	Resources 5	         ListViewItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%S  &	        �� 5
   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� #��z��5   !   #��z��5   !   #��z��5   !   5      5      5       5      P� 5       �@J�IsMouseOver$
 true��61   . �5      ��  � ��
 ���� 63   5      5      5      .��5       � $��10q�6   $	��400��6   	 � ColumnDefinitions	 5!   
   �� 5"      �� 5#      .+�5&   
   �� .��5'      �� -   5        
 ��Name$
 ListViewTest��5*      $��0��5)      #��[  5+      ��5,      �� 5-      .R�5.      9� ��5/      �� 50   "   ��6,   �� *name+��52      �� 53   "   $
 InnerListView��56   %   -   5        $	��180��55   %   ��57   %   �� *data+59   #   5;      5<      5>      5?      �� 5A   
   $��1��5B      $	��Top=�5C      $��/asset/jetbrains.png��5D      5E      5F      