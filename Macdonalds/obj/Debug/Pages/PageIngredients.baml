   M S B A M L   `   `   `  ����E  AMacdonalds, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Macdonalds.PagesMacdonalds.Pages  5      &     Macdonalds.Pages.PageIngredients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Macdonalds.Pages     5        N� Title$  PageIngredients��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5      $
��auto �6   6,   .+�5   
   �� -   5         ��Name$ DishName��5      $��17(�6&   $��Center=�64   $��10q�6Q   6_   �� 5   
   -   5         ��Name$ ListIngredients��5      $��17(�6+   $��1��69   $��Hidden=�6F   $��0q�6x   ��.  $��Center=�6�    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� 
������ ._�5   &   �� 5   #   5      5      5      5      ��5       �� 5!      .R�5"      � 	 � ColumnDefinitions	 5#      �� 5$      $	��120 �6/   6=   �� 5%      61   .+�5'      �� $	��100��6A   ��6    �� *Element.Photo+6O   �� 5(      $��1��6%   
 �� Orientation$
 
Horizontal=�65   $��Center=�6N   .+�5)      �� $
��20,0q�6F   $	��120��6T   ��6(   �� *Element.Name+6b   �� 5+      $
��10,0q�6?   ��6(   �� *Count+6O   5-      5.      5/      51      �� 52   
   -   5         ��Name$ SaveBtn��52      $$��Добавить в заказ��6"      StandartButton#��[  6=   $��2��6{   $��10q�6�   6�   53      54      