   M S B A M L   `   `   `  ����D  @Exercise1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exercise1	Exercise1  5   	       Exercise1.Student_Detail   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exercise1     5   	     � Title$  Student_Detail��5   	   $	��450��6    $	��800��6-    � 	Resources 5	      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��
Student ID��6   $
��Left=�6%   $��5q�6@   $��0��6K   $��5q�6X   $��Center=�6l   6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��5q�6@   $��1��6K   $��5q�6X   $��Center=�6l   6�   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��5q�6?   $��2��6J   $��5q�6W   $��Center=�6k   6�   �� 5   
   $��Gender��6   $
��Left=�6!   $��5q�6<   $��3��6G   $��5q�6T   $��Center=�6h   6�   �� 5    
   $��Class��6   $
��Left=�6    $��5q�6;   $��4��6F   $��5q�6S   $��Center=�6g   6�   �� 5!   
   $��Email��6   $
��Left=�6    $��5q�6;   $��5��6F   $��5q�6S   $��Center=�6g   6�   �� 5#   
   $��0��6   $��2��6    �� TextWrapping$
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   ��  �� Path$ StudentIdDetail�6�   �� 5$   
   $��1��6   $��2��6   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ FirstNameDetail�6�   �� 5%   
   $��2��6   $��2��6   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ LastNameDetail�6�   	� 5'   
   $
��Male��6   $��1��6%   $��3��66   $	��Top=�6C   $��5,5,-5,0q�6x    d� 	IsChecked 6[   �� *IsMale+6�   	� 5(   
   $��Female��6   $��1��6'   $��3��68   $	��Top=�6E   $��	5,25,-5,0q�6|    6]   �� *
IsFemale+6|   �� 5*   
   $��2��6   $��4��6#   $��5q�60   $��Center=�6;    �� Text 6V   �� $ ClassDetail�.@�5+      ��  �� 
IsSelected$
 true��6   ��6-   �� $ Class�6N   �� 5,      .��6   
19DTHQA16%   �� 5-      .��6   
19DTHQA26%   �� 5.      .��6   
19DTHQA36%   5/      �� 51   
   $��2��6   $��5��6"   $
 Wrap=�6/   $��5q�6C   $��1q�6N   ��6b   �� $ EmailDetail�6�   �� 53   
   $
��Save��6   $��0��6    $��6��60   $��5q�6=   $��Right=�6H   $	��100��6d   ��6p   �� *SaveCommand+6�   �� 54   
   $��Cancel��6   $��1��6"   $��6��62   $��5q�6?   $
��Left=�6J   $	��100��6e   ��6q   �� *CancelCommand+6�   56      57      