   M S B A M L   `   `   `  ����P  LBACS387Group10Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BACS387Group10ProjectBACS387Group10Project  5   	   &     BACS387Group10Project.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:BACS387Group10Project     5   	     � Title$  
UserWindow��5   	   $	��400��6   $	��600��6)   .��5	      �� $
��Auto=�6   $
��Auto=�68   $��0,0,2,0q�6[   $	��368��6l   $	��Top=�6y   .��5
   
   �� $	��326��6   $	��562��6"   .+�5      �� ���	#99FFFFFF$��2q�6-   $
��Left=�6A    �� Padding$ 0q�6\   $��0q�6h   $	��562��6s   $	��344��6   ._�5      �� -   5         ��Name$ Tabs1��5       �� TabStripPlacement$	 Top=�6,   
�������$��	0,8,-10,8q�6\   $
��Auto��6o   $��Right=�6}   $	��560��6�   $��Stretch=�6�   .@�5      �� -   5         ��Name$ allBooks��5      $��	All Books��60    �� 
IsSelected . 
�������$��0q�6h   $	��125��6s   $��29��6   $
��Left=�6�   .��5      � $��0,0,0,0q�6   .+�5      �� -   5         ��Name$ bookDisplay��5   &   $��10,10,19,57q�6;   �� 5      -   5         ��Name$ getBooks��5   %   $��Show All Books��67   $
��Left=�6P   $��407,235,0,0q�6k   $	��Top=�6�   $	��128��6�   $��42��6�   6�   5      5      �� 5      $��Search��6   
�������$	��125��6@   $��29��6L   $��0q�6X   $
��Left=�6c   .��5      � $��0,0,0,0q�6   .+�5      �� -   5         ��Name$ 
ISBNsearch��5   $   $��Search ISBN:��68   $��132,32,343,232q�6O   �� 5      -   5        	 ��Name$	 	ISBNInput��5   &   $
��Left=�69   $��23��6T   $��
232,32,0,0q�6`   
 �� TextWrapping$

 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��178��6�   �� 5      -   5        $ Search��5   %   $��Search��65   $��330,234,104,30q�6F   6^   �� 5      -   5        $ searchResult��5   &   $
��Left=�6<   $	��126��6W   $��	35,81,0,0q�6d   $	��Top=�6w   $	��477��6�   5      5       5!      5"      5#      5$      5%      