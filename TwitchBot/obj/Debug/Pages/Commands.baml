   M S B A M L   `   `   `  ����D  @TwitchBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TwitchBot.PagesTwitchBot.Pages  5          TwitchBot.Pages.Commands   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TwitchBot.Pages     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5
      � $	��430��6   $	��700��6     � ColumnDefinitions  5   
   �� 5      $	��89* �6   �� 5      $
��171* �6   �� 5      $	��90* �6    � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $	��36* �6   .+�5   
   �� $��Commands��6   $��32(�6$   $��SemiBold"�62   $��0 20 0 0q�6H   ���#121518$
��Left=�6o   $��2��6�   �� 5   
   -   5         ��Name$	 Add��5         	addButton#��[  6   $��0��6A   $��2��6N   $��Center=�6^   $	��150��6{    � Cursor$
 Hand��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=�6(   $��Center=�64   $��0 1 8 0q�6O   $��11��6`   $��11��6k   �� 5      $��Add New Command��6   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ membersDataGrid��5   s     DataGridRowStyle1   RowStyle# �  6     DataGridCellStyle1   	CellStyle# �  6B     DataGridStyle1#���  6�   $��0,10,0,0q�6�   $��3��6�   $��1��6�   	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$
 #��6%      
IsReadOnly .    CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   �� *Number+  5$      $
 Command��6%    .    MaxWidth$	 100Q�6`    66   �� *Cmd+6`     5%      $
 Message��6%    . $ * 6h    66   �� *CommandText+6h   4  .System.Windows.Controls.DataGridTemplateColumn  5'      $
 
Operations��6)    . $
 auto 6O      CellTemplate 5(      �� 5)      .R�5*      �� $ 
Horizontal=�6)   .+�5+   "   �� -   5          gridEditButton#��[ 5+   )   $
 Hand��6d   .��5,   &     $ PencilOutline=�6<     gridButtonIcon#��[ 6Q   5-   #   �� 5.   "   -   5        $��5 0 0 0q�5.   )     gridRemoveButton#��[ 6:   $
 Hand��6d   .��5/   &     $ DeleteOutline=�6<   #��[ 6Q   50   #   51      52      54      56      57      58      