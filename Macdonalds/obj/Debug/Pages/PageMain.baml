   M S B A M L   `   `   `  ����E  AMacdonalds, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Macdonalds.PagesMacdonalds.Pages  5      9!clr-namespace:Macdonalds.ControlsMacdonalds.Controls  5          Macdonalds.Pages.PageMain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Macdonalds.Pages     5      0uc!clr-namespace:Macdonalds.Controls     5      -   5          N� Title$  PageMain��5
      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $	��100 �6   6+   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��120 �6#   61   �� 5      6%   .+�5      +   %Macdonalds.Controls.CategoryesDisplay  -   5          Name$ ListCategoryes��5   #   6=   '   !Macdonalds.Controls.DishesDisplay  5      -   5          Name$ 
ListDishes��5      $��1��63   6E   5      �� 5   
   -   5        $��TextNull��5   w   $��Нет блюд��6   $��17(�6$   $��Center=�62   $��Center=�6O   $��1��6j   6�   �� 5   
   -   5         ��Name$ 	ListSaves��5      $��17(�6%   $��1��63   $��0q�6@   $��Hidden=�6T   $y�	Collapsed=�6�    � 	Resources 5       �� 
TargetType �� Property	 �� Value
 �� 
TargetType��%�   '��       �� 5       " ��6   .�5!      ��  � ��	 5"      �� 5#      "
 ��6.   .R�5$   "   �� 
������ ._�5%   &   �� 5&   #   5'      5)      5*      5+      ��5,      �� 5-      .R�5.      � 6"   5/      ��51      �� 52      .R�53      ��  �� CornerRadius$ 25��6   
����ح�$��10q�6F   ._�54      �� $��10q�6%   .+�55      �� $
��Wrap=�6>   ��6(   �� *Name+6T   �� 56      ��6(   �� *Count+ �� StringFormat$  {0} рублей��6]   �� 57      $��Center=�6(   �� 6F   -   5        
���  ��.�57   y   Удалить6�   6�   58      59      5:      5<      � 5=   
   $��3��6   $��50��6    5>      �� 5?      6%   �� 5@      6%   .+�5B      �� -   5         ��Name$ 	CancelBtn��5B      $!��Отменить заказ��6(      StandartButton#��[  6A   
���  ��$��10q�6�   6�   �� 5C      -   5        $ SaveBtn��5C      $��Готово��6&   #��[  67   $��1��6_   {�.  $��10q�6�   6�   5D      5E      5F      