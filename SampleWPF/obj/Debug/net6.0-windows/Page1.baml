   M S B A M L   `   `   `  ����D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SampleWPF	SampleWPF  5          SampleWPF.Page1   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SampleWPF     5        N� Title$  Page1��5      $	��300��6   $	��400��6"    N� 
Background
 �����.��5	      � -   5         �Name$ 	Page1Grid��5	       J� Opacity$	 100Q�6   .+�5   
   �� -   5         ��Name$ StaffDetailPanel��5      $��0,20,0,0q�6/   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5         AutoGenerateColumns$ false��6+      CanUserAddRows$ false��6G   $��
20,10,20,9q�6^      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��5   ;   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   �� *
staff_id+  5      -   5        
nameColumn��$
	 Name��5   =   $
 * 6K    6U   �� *name+  5      -   5        	divColumn��$	 Division��5   <   $
 * 6N    6X   �� *
division+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 * 6-      CellTemplate 5      �� 5      .R�5   "   �� $��callAPIButton��6)   -   5        $��Guess Gender��5   N   6g   5      5      5      5      5      5      