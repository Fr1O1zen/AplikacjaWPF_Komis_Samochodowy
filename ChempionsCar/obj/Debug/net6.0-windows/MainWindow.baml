   M S B A M L   `   `   `  ����G  CChempionsCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ChempionsCarChempionsCar  5   	       ChempionsCar.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ChempionsCar     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$
 Grid��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ ./Img/dashboard.jpg��6    j� Stretch$ UniformToFill=�6;    j� TileMode$
 None=�6S   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��
82,13,67,7q�6;   .+�5      �� -   5        $��Dodaj samochód��5      $��5q�6.   69   �� 5      -   5         ��Name$ SearchTextBox��5      $��5q�6-   $	��352��68   �� 5      -   5        $��Szukaj��5      $��95��68   $��39��6C   5      �� 5   
   -   5         ��Name$ CarListView��5      $��1��6R   $��172,10,214,30q�6_   $��1q�6v   	 �� View	 5      �� 5      .P�5      �� $��Marka��6%   
 �� Width$	
 120��6\    �� DisplayMemberBinding 65   �� *Brand+6\   �� 5      $��Model��6%   $	
 120��6[    64   �� *Model+6[   �� 5      $��Rocznik��6%   $
 80��6\    66   �� *Year+6\   �� 5      $
��Cena��6%   $
 80��6Z    63   �� *Price+6Z   5      5!      �� 5"   
   -   5        $	��IMG��5"      $
��Left=�69   $��26��6T   $��
60,308,0,0q�6`   $��1��6t   $	��Top=�6�   $��26��6�   �� 5#   
   -   5        $�� ��5#      $
��Left=�67   $��26��6R   
�������$��
93,308,0,0q�6q   $��1��6�   $	��Top=�6�   $��26��6�   �� 5$   
   -   5        $�� ��5$      $
��Left=�66   ���	#FF404040$��26��6h   $��
27,308,0,0q�6t   $��1��6�   $	��Top=�6�   $��26��6�   5%      5&      