   M S B A M L   `   `   `  ����E  Aproject_PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:project_PP
project_PP  5   	       project_PP.window_shop   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:project_PP     5   	   -   5          � Title$  Магазин��5   	   $
��1080��6   $
��1920��6'   $	��800��64   $
��1200��6D    � WindowState$ 	Maximized=�6T   ���#ffe0b3.��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
    � -   5          �Name$ 
frame_shop��5        � NavigationUIVisibility$ Hidden=�6$   $��Stretch=�6D   $��Stretch=�6b   $��Center=�6~   $��Center=�6�   $��1��6�   $��9��6�   $��1��6�   $��2��6�   5       �� 5!   
   $��0��6   ���#2b2b2b$��
100 0 10 0q�66    �� CornerRadius$ 50��6J   $��1��6\   $��3��6i    J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         
BlurRadius$ 35Q�6#   	   	Direction$		 270Q�63   
   Color$
 Black��6C      ShadowDepth$ 10Q�6Q      Opacity$	 0.5Q�6b   6r   ._�5%      �  5&      �� 5'      �� 5(      �� 5)      .+�5+      �� -   5         ��Name$ btn_shop��5+      $��0��6+   $��	15 5 15 5q�68   
������ 
������ $��Каталог��6   $��30(�6�   
�������6�   �� 5,      -   5        $ 
btn_basket��5,      $��1��6-   $��	15 5 15 5q�6:   
������ 
������ $��Корзина��6�   $��30(�6�   
�������6�   �� 5-      -   5        $ btn_profile��5-      $��2��6.   $��	15 5 15 5q�6;   
������ 
������ $!��Личный кабинет��6�   $��30(�6�   
�������6�   5/      50      �� 51   
   $��10q�6    �� TextAlignment$ Center=�6    $��20(�67   
������ $
��Left=�6_   �� 52      -   5        
���   � �� TextDecorations$ 	Underline{�52   8   .�6T    Выйти из профиля54      55      56      57      