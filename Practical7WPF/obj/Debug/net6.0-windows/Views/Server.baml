   M S B A M L   `   `   `  ����H  DPractical7WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practical7WPF.ViewsPractical7WPF.Views  5   	        Practical7WPF.Views.Server   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Practical7WPF.Views     5   	     � Title$  Server��5   	   $	��450��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ��  �� IsCancel$
 True��6   $��1��6!   $��2��61   $��
Выйти��6>   $��40��6N   $��18(�6Z   �� 5   
   $��2��6   $��Логи чата��6!   $��40��65   $��18(�6A   �� 5   
   $��3��6/   $��2��6?   $��Отправить��6L   $��40��6`   $��18(�6l   ��6   ��  �� Path$
 Send�6l   �� 5   
   $��2��6(   $��2��68   $��18(�6E   $��40��6S   ��6   �� *Text+6S   �� 5   
   $��1��62   $��1��6?   $��3��6O   ��6   �� *	Message+6O   �� 5   
   $��1��60   $��2��6=   $
��Left=�6N   $	��133��6i   ��6   �� *Users+6i   �� 5   
   -   5         ��Name$ TextTB��5      $��Пользователи:��6$   $��Center=�69   $��Center=�6T   $��20(�6q   $��40��6   5      5      