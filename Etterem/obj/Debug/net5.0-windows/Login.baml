   M S B A M L   `   `   `  ����B  >Etterem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EtteremEtterem  5   	       Etterem.Login   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Etterem     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Images/Logo.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $��50��6   $	��Top=�6    $��1��68   ��5      �� 5      .��5      �  � Color$ 
GhostWhite��6#   5      5      �� 5   
   $	��280��6   $	��Top=�6!   $��1��69   ��5      �� 5      .��5      � $ #5796fa��6#   5      5       �� 5#   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 0��6V    �� RadiusX$ 0��6b   
�������$��1��6�    J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5'      �� 5*   
   $��Images/McTomlek.png��6   $	��120��6-   $	��120��69   $	��Top=�6F   $��30q�6^   $��1��6j   � 5,   
   -   5         �Name$ 
Loginablak��5,      $y�Visible=�6#   .+�5/   
   � $��Bottom=�6   $��35,80q�6*   $	��240��69   $��1��6F   .+�50      �� $��BEJELENTKEZÉS��6   $��Center=�6,   $	��Top=�6I   $��5q�6a   
�������$��18(�6~   �� 51      $��Center=�6   $��15q�64   .+�52      �� $
��0,10q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ FELHASZNÁLÓNÉV��6(    %  !MaterialDesignFloatingHintTextBox#��[  6X   $��Champagne & Limousines)�6�   $��18(�6�   G� 53      $
��0,10q�6   $ JELSZÓ��6,    ) %MaterialDesignFloatingHintPasswordBox#��[ 6T   $��Champagne & Limousines)�6�   $��18(�6�   54      55      �� 58   
   $	��150��6   $��Center=�6   $��Bottom=�6:   $
��0,65q�6U   $��BEJELENTKEZÉS��6c   $��1��6{   �� 5;   
   -   5        $��Regisztráció��5;      $��Center=�6(   $��	0,409,0,0q�6E   $	��Top=�6X   $��20��6p   $��10(�6|   
������ 
�������
������ 6�   �� 5>   
   -   5        $��Elfelejtett jelszó��5>      $��Center=�6.   $��	0,434,0,0q�6K   $	��Top=�6^   $��20��6v   $��10(�6�   
������ 
�������
������ 6�   5@      � 5A   
   -   5        $ regablak��5A      $y�	Collapsed=�6!   .+�5D      � $��Bottom=�6   $��35,80q�6.   $	��240��6=   $��1��6J   .+�5E      �� $��REGISZTRÁCIÓ��6   $��Center=�6/   $	��Top=�6L   $��5q�6d   
�������$��18(�6�   �� 5F      $��Center=�6   $��15q�68   .+�5G      �� $
��0,10q�6   $ FELHASZNÁLÓNÉV��6,   #��[  6\   $��Champagne & Limousines)�6�   $��18(�6�   �� 5H      $
��0,10q�6   $ EMAIL��6,   #��[  6S   $��Champagne & Limousines)�6�   $��18(�6�   G� 5I      $
��0,10q�6"   $ JELSZÓ��60   #��[ 6X   $��Champagne & Limousines)�6�   $��18(�6�   5J      5K      �� 5N      -   5         ��Name$ Regisztráció��5N      $	��150��6+   $��Center=�67   $��Bottom=�6T   $
��0,65q�6o   $��Regisztráció��6}   $��1��6�   5O      � 5P   
   -   5        $ ElfelejtettAblak��5P      $y�	Collapsed=�6)   .+�5S      � $��Bottom=�6   $��35,80q�6.   $	��240��6=   $��1��6J   .+�5T      �� $��ELFELEJTETT JELSZÓ��6   $��Center=�65   $	��Top=�6R   $��5q�6j   
�������$��18(�6�   �� 5U      $	��Top=�6   $��35q�65   .+�5V      �� $
��0,10q�6   $ EMAIL��6,   #��[  6S   $��Champagne & Limousines)�6�   $��18(�6�   $��Center=�6�   � 5W      -   5        $ JelszoEleje��5W      $y�	Collapsed=�60   .+�5X      �� $!��Jelszó első pár betűje:��6$   5Y      5Z      5[      �� 5^      -   5        $ ElfelejtettJelszó��5^      $	��150��60   $��Center=�6<   $��Bottom=�6Y   $
��0,65q�6t   $��Kérem a jelszót!��6�   $��1��6�   6�   5b      5c      5d      