   M S B A M L   `   `   `  ����F  BMainProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MainProject.PagesMainProject.Pages  5   	       MainProject.Pages.Addwork   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MainProject.Pages     5   	     � Title$  Addwork��5   	   $	��400��6   $	��400��6&    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�6X    � AllowsTransparency . 
������ .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.08* �6   �� 5      $��* �6   .+�5   
   �� -   5        
������� �� CornerRadius$ 	12 12 0 0��5   '   6@   �� 5   
   $ 	0 0 12 12��6    �� Padding$ 15q�6*   ���#ffffff$��1��6L   ._�5      �  5      �� 5      $��* �6$   �� 5      $
��0.2* �6$   .+�5      ��  �� Orientation$ Vertical=�6   $��0��64   .+�5      �� -   5         ��Name$ comboPerson��5   L   $��30��6   $	��300��6+   ���#ced0d5	 �� Text	 6a   �� *NamePlusJob+�� 5      $	��220��6   $��10q�6+   $��2q�68   ��6L   �� *Text+5      �� 5      $��1��6   $ 
Horizontal=�6*   $��Center=�6C   .+�5      �� -   5           DataButtons#��[  5      $	��150��6B   $��OK��6N   6[   �� 5      #��[  6   $	��150��6B   $��Cancel��6N   
 �� IsCancel
 . 6_   5       5!      5"      5#      5$      