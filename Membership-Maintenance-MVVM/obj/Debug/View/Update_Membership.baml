   M S B A M L   `   `   `  ����V  RMembership-Maintenance-MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Membership_Maintenance_MVVM.View Membership_Maintenance_MVVM.View  5   	   8    2Membership_Maintenance_MVVM.View.Update_Membership   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Membership_Maintenance_MVVM.View     5   	     � Title$  Update_Membership��5   	   $��206.763��6#   $	��300��64    � DataContext 5	   	   �� *UpdateViewModel+   Locator �� Source# [  .��5
      � .+�5   
   �� -   5         ��Name$ 
fNameLabel��5      $��
First Name��6$   $
��Left=�69   $��	28,11,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ 
lNameLabel��5      $��	Last Name��6$   $��28,49,198,0q�68   $	��Top=�6M    J� RenderTransformOrigin$ 0.499,-0.318&�6e   �� 5   
   -   5        $ 
EmailLabel��5      $��E-Mail��6$   $
��Left=�65   $��	28,89,0,0q�6P   $	��Top=�6c   �� 5   
   -   5         ��Name$ 	FirstName��5      $
��Left=�6%   $��22��6@   $��
124,15,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6�   $	��140��6�   ��6t   �� *	FirstName+6�   �� 5   
   -   5        $ LastName��5      $
��Left=�6$   $��22��6?   $��
124,53,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $	��140��6�   ��6s   �� *
LastName+6�   �� 5   
   -   5        $ Email��5      $
��Left=�6!   $��22��6<   $��
124,93,0,0q�6H   $
 Wrap=�6\   $	��Top=�6�   $	��140��6�   ��6p   �� *Email+6�   �� 5   
   -   5         ��Name$
 Save��5      $
��Save��6   $
��Left=�6O   $��
28,127,0,0q�6j   $	��Top=�6~   $��75��6�   ��6.   �� *
saveButton+6�   �� 5   
   -   5        $ Delete��5      $��Delete��6!   $
��Left=�6S   $��108,127,0,0q�6n   $	��Top=�6�   $��75��6�   ��62   �� *deleteButton+6�   �� 5   
   -	   5        $ Cancel��5      $��Cancel��6!   $
��Left=�6T   $��189,127,0,0q�6o   $	��Top=�6�   $��75��6�   ��62   �� *cancelButton+6�   5      5      