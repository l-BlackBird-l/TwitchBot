   M S B A M L   `   `   `  ����D  @TwitchBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TwitchBot.PagesTwitchBot.Pages  5          TwitchBot.Pages.Message   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TwitchBot.Pages     5        � 	Resources  5	         Storyboard1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  Storyboard2  Storyboard3��%5  &	        &	 �     &	 s    �� 5
   
   .��5      U� $ (UIElement.Opacity)�6,   $
 Mess��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      5      �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $ backr��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.3��6'   $ 1Q�69   5      5      �� 5   
   .��5      U� -   5        $ (UIElement.Opacity)�5   ,   $ backr��6\   .\�5        $ 0:0:0.5��6'   $ 0Q�69   5      5      5       � Triggers 5      :� 5    
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5!      �� #��[  6   �� 5"      #��[ 6   5#      :� 5%   
   $ ButtonBase.Click��6    :� 
SourceName$ CloseWindow��66   .[�5&      �� #��[ 6   5'      .��5*      �� -   5         ��Name$ backr��5*   T   ���	#7F000000	 �� CornerRadius$
	 34.6��6%   $
��auto��69   $
��auto��6F   ._�5-   
   �� -   5        $
 Mess��5-   n   
�������$��Center=�6$   $��Center=�6A   $	 20��6\   
 J� Opacity$
 0Q�6|   ._�5.      � $��
50 10 10 0q�6   .+�5/      �� $��0 0 0 15q�6    �� Orientation$ Vertical=�6/   .+�50      �� -   5         ��Name$ Caption��50   �   $��Add command��6   $
��Left=�62   $	��Top=�6M   $��17(�6e   $��	-30 0 0 2q�6s   $��Medium"�6�   6�   �� 51      $��-50 0 -10 20q�6    $	��Top=�66   $	��0.8��6K   ���#7e5fdc6X   �� 52      $ 
Horizontal=�6!   $��	-40 0 0 0q�6:   .+�53      �� $��Command��6$   $��13(�63   $��DemiBold"�6A   �� 54      -   5         ��Name$	 CMD��54   N   $��10 0 0 0q�6"   $��13(�64   $	��150��6B   6N   55      �� 57      $ 
Horizontal=�6!   $��0 10 0 0q�6:   .+�58      �� $��Message��6$   $��13(�63   $��DemiBold"�6A   $��	-40 0 0 0q�6W   �� 59      -   5        $ CommandText��59   N   $��20 0 0 0q�6"   $��13(�64   $	��150��6B   6N   5:      �� 5<      $ 
Horizontal=�6!   $��Right=�6:   $��	20 20 3 0q�6V   .+�5=      �� -   5         ��Name$ Accept��5=   !   $��Submit��61     gridEditButton#��[ 6B   $��0 0 5 0q�6j   ���#6741d9 � Cursor$
 Hand��6�   6�   �� 5>      -   5        $ CloseWindow��5>   !   $��Cancel��66     gridRemoveButton#��[ 6G   ���#d32f2f���#c2c2c2$
 Hand��6�   6�   5?      5@      5B      5C      5D      5E      