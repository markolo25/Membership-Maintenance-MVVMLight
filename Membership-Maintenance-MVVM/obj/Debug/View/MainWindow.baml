   M S B A M L   `   `   `  ����V  RMembership-Maintenance-MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Membership_Maintenance_MVVM.View Membership_Maintenance_MVVM.View  5   	   1    +Membership_Maintenance_MVVM.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Membership_Maintenance_MVVM.View     5   	     � Title$  Membership List��5   	   $	��350��6!   $	��525��6.    � DataContext 5	   	   �� *MainViewModel+   Locator �� Source# [  .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��251* �6   �� 5      $
��266* �6   .+�5   
   �� -   5         ��Name$ listBox��5       �� DisplayMemberPath$ GetDisplayText��6{   $
��Left=�6�   $	��282��6�   $��	18,18,0,0q�6�   $	��Top=�6�   $	��319��6�   $��2��6�   ��6#   �� *
MemberList+ �� SelectedItem 6F   �� *SelectedMember+ �� Mode$ TwoWay=�6�   �� 5   
   -   5         ��Name$ 
add_button��5      $	��Add��6%   $
��Left=�6Q   $��105.039,32,0,0q�6l   $	��Top=�6�   $	��138��6�   $��44��6�   $��1��6�   ��63   �� *	AddButton+6�   �� 5   
   -   5        $ close_button��5      $��Close��6'   $
��Left=�6X   $��
105,83,0,0q�6s   $	��Top=�6�   $	��138��6�   $��44��6�   $��1��6�   ��68   �� *CloseButton+6�   5      5      