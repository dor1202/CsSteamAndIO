   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject  5   	       project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:project     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	   	   ��    Locator �� Source# [   �� Path$
 Main�.��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $	��ID:��6   $��0��6   $��0��6/   $��Center=�6<   $��Center=�6W   $��48(�6t   �� 5   
   $��Name:��6   $��0��6!   $��1��61   $��Center=�6>   $��Center=�6Y   $��48(�6v   �� 5   
   $��Address:��6   $��0��6$   $��2��64   $��Center=�6A   $��Center=�6\   $��48(�6y   �� 5   
   $��1��6   $��0��6"   ��6/   �� *CurrentUser.Id+�� 5   
   $��2��6   $��1��6"   ��6/   �� *CurrentUser.Name+�� 5   
   $��3��6   $��2��6"   ��6/   �� *CurrentUser.Addrress+�� 5   
   $
��Load��6   $��0��6    $��3��60   $��48(�6=   ��6K   �� *Load+�� 5"   
   $
��Save��6   $��1��6    $��3��60   $��48(�6=   ��6K   �� *Save+�� 5$   
   -   5         ��Name$	 res��5$      $��4��67   $��2��6D   ��6   �� *Result+6D   5%      5&      