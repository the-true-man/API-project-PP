   M S B A M L   `   `   `  ����E  Aproject_PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:project_PP
project_PP  5          project_PP.basket_page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:project_PP     5        N� Title$  basket_page��5	      .��5      � .+�5   
   �� ���#2b2b2b �� CornerRadius$ 50��6&   $	��500��68   $	��500��6H   $
��auto��6W   $
��auto��6d   $��	0 0 15 15q�6r   $��Stretch=�6�   $��Stretch=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 35Q�6#      	Direction$	 270Q�63      Color$ Black��6C      ShadowDepth$ 10Q�6Q      Opacity$	 0.5Q�6b   6r   5      �� 5   
   .+�5      �� -   5         ��Name$ 	lb_basket��5      $��50 50 50 50q�6*   $
��auto��6?   $	��500��6M   ��5      �� 5      .R�5      � $	��600��6   	 � ColumnDefinitions	 5      �� 5   "   65   �� 5   "   65   �� 5   "   65   .+�5      �� $��0��6?   $��18(�6P   
���   ���6(   �� *Title+6s   �� 5      $��50 0 0 0q�6(   $��18(�6:   $��1��6H   
���   ���6k   �� *Cost+
 �� StringFormat$
 {0} руб.��6�   �� 5      -   5        $��Удалить��5   %   $��20(�67   $��2��6E   $��Right=�6U   6�   5      5       5"      �� 5#       �� Orientation$ 
Horizontal=�6   $��20 0 0 0q�62   .+�5$      �� $��Общая сумма: ��6   $��30(�61   
�������6U   �� 5%      -   5         ��Name$ lb_general_cost��5%      $��10000��61   $��30(�6B   $��DemiBold"�6P   
�������6|   5'      �� 5(      -   5        $:��4Купить все товары из корзины��5(      $	��300��6<   $��40��6H   $��18(�6T   $
��Left=�6b   $��50 0 0 0q�6}   6�   5)      5+      5,      