   M S B A M L   `   `   `  ����E  Aproject_PP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:project_PP
project_PP  5          project_PP.profile_page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:project_PP     5        N� Title$  profile_page��5	      .��5      � .+�5   
   �� ���#2b2b2b �� CornerRadius$ 50��6&   $	��500��68   $	��500��6H   $
��auto��6W   $
��auto��6d   $��	0 0 15 15q�6r   $��Stretch=�6�   $��Stretch=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 35Q�6#      	Direction$	 270Q�63      Color$ Black��6C      ShadowDepth$ 10Q�6Q      Opacity$	 0.5Q�6b   6r   5      �� 5   
   $��50 20 50 20q�6    �� Orientation$ Vertical=�6*   .+�5      �� $��Фамилия��6   $��30(�6&   
�������6I   �� 5      -   5        	 ��Name$	 tb_surename��5      
 �� 	MaxLength$	
 100��6+   $��30(�6;   
���   �$	��500��6\   $
��Left=�6h   $��0 0 0 30q�6�   6�   �� 5      $��Имя��6   $��30(�6"   
�������6E   �� 5      -   5        $	 tb_name��5      $	
 100��6'   $��30(�67   
���   �$	��500��6X   $
��Left=�6d   $��0 0 0 30q�6   6�   �� 5      $��Отчество��6   $��30(�6(   
�������6K   �� 5      -   5        $	 
tb_midname��5      $	
 100��6*   $��30(�6:   
���   �$	��500��6[   $
��Left=�6g   $��0 0 0 30q�6�   6�   �� 5      $��E-Mail��6   $��30(�6%   
�������6H   �� 5      -   5        $	 lb_email��5      $	
 100��6(   $
��Bold"�68   $	��500��6J   $��30(�6V   
���   �$
��Left=�6w   $��0 0 0 30q�6�   6�   �� 5      -   5        $��Соханить��5      $��50��6(   $��30(�64   $	��400��6B   $
��Left=�6N      	round_btn#��[  6i   ���	#FFF1F1F16�   �� 5      $#��История заказов��6   $��30(�6.   
�������6Q   �� 5      -   5         ��Name$ 	lv_orders��5      $	��180��6*   ��5      �� 5      .R�5       �� $��20 0 0 0q�6%   $ 
Horizontal=�67   $
��auto��6P   $
��auto��6]   .+�5!      �� $��18(�6(   
���   ���6I   �� *Id+6_   �� 5"      $��18(�6(   $��	10 0 10 0q�66   
���   ���6\   �� *Status+6v   �� 5$      $��18(�6(   $��	10 0 10 0q�67    �� TextAlignment$
 Left=�6J   ��6`   �� *General_cost+ �� StringFormat$ {0} руб.��6�   �� 5%      $��18(�6(   $��	10 0 10 0q�67   ��6J   �� *
Count_item+$ 	{0} шт.��6�   �� 5&      $��18(�6(   $��	10 0 10 0q�67   ��6J   �� *	DateOrder+6g   5'      5(      5*      5+      5,      5-      