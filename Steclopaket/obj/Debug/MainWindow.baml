   M S B A M L   `   `   `  ����F  BSteclopaket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SteclopaketSteclopaket  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   1&clr-namespace:System;assembly=mscorlibSystem 5   	       Steclopaket.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Steclopaket     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   
�������.��5      �� -   5         ��Name$ 
tabControl��5      $��0,0,0,0q�6%   .@�5   
   �� -   5         ��Name$ 	TabOrders��5      $��Orders��6%   $
��-2,0q�65   .��5      � -   5         �Name$
 Grid��5      $��0,0,0,0q�6!   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrders��5      $��0,0,0,35q�6-      AutoGenerateColumns . 6?   �� 5      -   5         ��Name$ btnAddOrder��5      $��	Add order��6.   $
��Left=�6B   $��Bottom=�6]   $��75��6x   $��	10,0,0,10q�6�   6�   �� 5      -   5        $ btnDelOrder��5      $��Delete order��6.   $
��Left=�6E   $��90,0,0,10.04q�6`   $��Bottom=�6v   $��93.667��6�   5      5      �� 5   
   -   5        $ TabMaterials��5      $��	Materials��6(   $
��-2,0q�6`   .��5      � ���	#FFE5E5E5.+�5        -	   5        $ dgMaterials��5      $��0,0,0,39q�60      SelectionUnit$
 Cell=�6B    .    CanUserAddRows .  5   6   �� 5      -
   5        $ 	btnNewMat��5      $��Add new��6,   $
��Left=�6>   $��10,0,0,14.04q�6Y   $��Bottom=�6o   $��65��6�   6�   �� 5      -   5        $ button1��5      $��Delete��6*   $
��Left=�6;   $��80,0,0,14.04q�6V   $��Bottom=�6l   $��75��6�   5      5      �� 5   
   -   5        $ TabProducts��5      $��Products��6'   $
��-2,0q�69   .��5      � ���	#FFE5E5E5.+�5        -   5        $ 
dgProducts��5      $��0,0,0,39q�6/   $
 Cell=�6A    .  .  5   '   �� 5       -   5        $ 
btnNewProd��5       $��Add new��6-   $
��Left=�6?   $��10,0,0,14.04q�6Z   $��Bottom=�6p   $��65��6�   6�   �� 5!      -   5        $ 
btnDelProd��5!      $��Delete��6-   $
��Left=�6>   $��80,0,0,14.04q�6Y   $��Bottom=�6o   $��75��6�   5"      5#      5$      5%      