   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   #    WpfApp1.Windows.Authorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	   -   5          � Title$  Authorization��5   	   $	��250��6   $��367.333��6,   $	��250��6<   $��367.333��6L   $	��250��6`   $��367.333��6p    � WindowStartupLocation$ CenterScreen=�5	       � AllowsTransparency .  � WindowStyle$
 None=�5   
    � 
ResizeMode$ CanResizeWithGrip=�6      newFont#��[  6S   ��6<   Z� .��5      �� ���#272537 �� CornerRadius$ 20��6"   ._�5   
   � .+�5      �� $ 20��6   ._�5      o� $	��Top=�6   $��Stretch=�6/   $��20��6M   $��
10,10,10,0q�6Z   ��6n   Z� .@�5      m� $��Файл��6   
���������6.   Z� .@�5      m� -   5        $��
Выход��5   #    m� InputGestureText$ ALT + F4��62   
���   ���6a   Z� 6w   5      m� 5      -   5        $��О программе...��5      
�������6J   5      5      �� 5      $��
70,53,70,0q�6   $��Логин (email)��6,   $	��Top=�6A    �� TextAlignment$ Center=�6Y   
�������6p   �� 5      -   5         ��Name$ loginBox��5      $��1q�6(   $��
70,72,70,0q�64   $	��Top=�6H   ��6`   �� *Login1+�� 5      $��70,123,70,0q�6   $��Пароль��6-   $	��Top=�6;   $ Center=�6S   
�������5       �� 5!      -   5        $ passwordBox��5!      $"��/WpfApp1;component/#password)�6+   $��1q�6V   $��70,142,70,0q�6b   $	��Top=�6w   ��6�   �� *
Password+�� 5#      -   5        $��
Войти��5#      $��10, 1q�6%   $
��Left=�66   $��
140,0,0,40q�6Q   $��Bottom=�6e   	 �� 	IsDefault	 .   OrangeButton#��[ 6�   $��85��6�   5%      5&      5'      