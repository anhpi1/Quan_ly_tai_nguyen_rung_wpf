   M S B A M L   `   `   `  ����V  RQuan_ly_tai_nguyen_rung_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Quan_ly_tai_nguyen_rung_wpfQuan_ly_tai_nguyen_rung_wpf  5      /    )Quan_ly_tai_nguyen_rung_wpf.ctrl_dong_vat   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Quan_ly_tai_nguyen_rung_wpf     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dataGrid��5
         AutoGenerateColumns$ False��6%   $��	0,0,0,132q�6A      
IsReadOnly$
 True��5         RowDetailsVisibilityMode$ 	Collapsed=�5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 66      CellTemplate 5      �� 5      .R�5      �� ��6(   �� *id+5      5        5      $ Tên sản phẩm��6)   $ * 6?    5      �� 5      .R�5      �� ��6(   �� *
username+5      5        5      $ 
Chi tiết��6)   $
 Auto 6;    5       �� 5!      .R�5"      �� -   5        $��
Chi tiết��5"   %   
 � Tag 6N   �� 5#      5%        5'      $
 Xóa��6)   $
 Auto 66    5(      �� 5)      .R�5*      �� -   5        $
��Xóa��5*   %    6E   �� *id+5+      5-      	   RowDetailsTemplate	 50      �� 51      .R�52      �� $��10q�6!   .+�53      �� $��
Chi tiet: ��6$   $
��Bold"�66   �� 55      
 �� Orientation$
 
Horizontal=�6%   $��0,5,0,0q�6>   .+�56      �� $
��Id: ��6(   $
��Bold"�64   �� 57      ��6(   �� *id+58      �� 59      $
 
Horizontal=�6%   $��0,5,0,0q�6>   .+�5:      �� $��Phone: ��6(   $
��Bold"�67   �� 5;      ��6(   �� *phone+5<      �� 5=      $
 
Horizontal=�6%   $��0,5,0,0q�6>   .+�5>      �� $��
Password: ��6(   $
��Bold"�6:   �� 5?      ��6(   �� *
password+5@      5A      5B      5D      � 5G   
   -   5         �Name$ 	inputGrid��5G      $y�	Collapsed=�6"   
�������$	��100q�6P    J� Opacity$
 0.95Q�6]   .+�5I      �� -   5        $��X��5I      $��25��6!   $��25��6,   
���  ��
�������$
��Bold"�5J      $��Right=�6   $	��Top=�6;   $��5q�5K      6   �� 5L      $��20q�6   .+�5M      �� $��Thêm Sản Phẩm��6   $
��Bold"�61   $��16(�6C   $��0,0,0,10q�6Q   �� 5N      $
 
Horizontal=�6   $
��0,10q�66   .+�5O      �� $��name: ��6    $	��100��6.   $��Center=�6:   �� 5P      -   5         ��Name$ txtName��5P      $	��200��6/   5Q      �� 5R      $
 
Horizontal=�6   $
��0,10q�66   .+�5S      �� $��Phone: ��6    $	��100��6/   $��Center=�6;   �� 5T      -   5        $ txtCategory��5T      $	��200��63   5U      �� 5V      $
 
Horizontal=�6   $
��0,10q�66   .+�5W      �� $��
Password: ��6    $	��100��62   $��Center=�6>   �� 5X      -   5        $ txtPrice��5X      $	��200��60   5Y      5Z      5[      �� 5^   
   -	   5         ��Name$ btnAddSubmit��5^      $	��Add��6'   $��Center=�65   $��	0,352,0,0q�6R   $	��Top=�6e   $��40��6}   $	��112��6�   6�   5_      5`      