   M S B A M L   `   `   `  ����N  JNetGamingManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NetGamingManagementNetGamingManagement  5   	   (    "NetGamingManagement.CustomerDetail   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:NetGamingManagement     5   	     � Title$  CustomerDetail��5   	   $	��450��6    $	��800��60    � 	Resources 5	         LabelContent �� 
TargetType �� Property �� Value��%7  &	        �� 5
   
   " ��6%   .�5      ��  � ��$
 Left=�69   �� 5       � ��$ Center=�69   �� 5       � ��$ TimeNewRoman)�69   �� 5       � ��$ 13(�69   �� 5       � ��$ 5q�69   �� 5       � ��$ 5q�69   �� 5       � ��$ 0��69   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5       $
��Auto �6   6,   �� 5!      $
��Auto �6   6,   �� 5"      $
��Auto �6   6,   .+�5%   
   �� $��Customer ID��6   #��[  6&   $��0��6L   6[   �� 5&   
   $��
First Name��6   #��[  6%   $��1��6K   6Z   �� 5'   
   $��	Last Name��6   #��[  6%   $��2��6K   6Z   �� 5(   
   $��Account��6   #��[  6%   $��3��6K   6Z   �� 5)   
   $��Email��6   #��[  6%   $��4��6K   6Z   �� 5*   
   $��Phone��6   #��[  6%   $��5��6K   6Z   �� 5,   
   $��0��6   $��1��6    �� TextWrapping$
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   ��  �� Path$ CustomerIdDetail�6�   �� 5-   
   $��1��6   $��1��6   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ FirstNameDetail�6�   �� 5.   
   $��2��6   $��1��6   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ LastNameDetail�6�   �� 5/   
   $��1��6   $��3��6"   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ AccountDetail�6�   �� 50   
   $��1��6   $��4��6"   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ EmailDetail�6�   �� 51   
   $��1��6   $��5��6"   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ PhoneDetail�6�   �� 53   
   $
��Save��6   $��0��6    $��7��60   $��6q�6=   $��Right=�6H   $	��100��6d   ��6p   �� *SaveCommand+6�   �� 54   
   $��Cancel��6   $��1��6"   $��7��62   $��6q�6?   $
��Left=�6J   $	��100��6e   ��6q   �� *CancelCommand+6�   56      58      