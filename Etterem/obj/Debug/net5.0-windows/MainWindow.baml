   M S B A M L   `   `   `  ����B  >Etterem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EtteremEtterem  5   	       Etterem.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Etterem     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Icon$  Images/Logo.png��5   	    � Title$ 	McTömlek��5
   	   $	��600��6   $
��1200��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   .��5      � .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5       �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ KERESÉS��6   $��Center=�6G   
�������$	��300��6u   $��15(�6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 �����6�   '  !MaterialDesignThemes.Wpf.PackIcon  5!      
   Kind$
 Magnify=�6.   
�������$��25��6P   $��25��6[   $��Center=�6g   $��5q�6�   5"      �� 5&      $ 
Horizontal=�6   $��Center=�66   $��Right=�6Q   $��50, 0q�6m   .+�5'      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6.   $��Right=�6W      	StaysOpen$ False��6s      ToggleContent 5(        5*      -   5        $

 Cart=�5*   6   
�������$��25��6U   $��25��6`   $��Center=�6l   $��5q�6�   6�      PopupContent. 5,      �� $	��200��6%   .+�5-      �� -   5         ��Name$ 
KosarLista��5-   &   5.      �� 50      -   5        $��Urites��50   %   $��	Ürítés��63   $��Center=�6Y   �� 52      -   5        $��Fizetes��52   %   $��Fizetés��64   $��Center=�6F   6j   53      54      �� 55      -   5         ��Name$ KosarOsszesDarab��55   \   $��Center=�6    
�������$��18(�6N   $��0��6v   6   56      �� 5:      $��Right=�6   $��10q�69   .+�5;        $ BottomAndAlignRightEdges=�6.   $��Right=�6W   $ False��6s   . 5<      �� $	��150��6%   .+�5=      �� -   5        $��btLogin��5=   %   $��Login��64   6D   �� 5>      -   5        $��btExit��5>   %   $
��Exit��63   6B   5?      5@      5A      5D      5E      � 5I   
   $��Stretch=�6   $��1��6-      PrimaryHueMidBrush#��[  6:    5J      �� 5K      $��8* �6#   �� 5L      $	��17* �6#    5N      �� 5O      $��70 �6    �� 5P      $	��53* �6    .+�5U      � -   5         �Name$ LogoRow��5U      $��0��6$   
�������$��2��6D   .+�5V      �� -	   5         ��Name$ HomeLogo��5V      $��Images/McTomlek2.png��6*   5W      �� 5[      $��Disabled=�6   $
��Auto=�6D   $��1��6g   $��2��6t   .��5\      �� -
   5         ��Name$
 Menu��5\      $��10q�6+   5]      5_      � 5c   
   $��1��6   $��1��6   .+�5d      �� $��Center=�6   $	��950��68   $	��538��6D   $	��Top=�6Q   $��Hidden=�6i   .��5e      �� -   5        $ StackPanelMain��5e      $��1��65   $��1��6B   $��Stretch=�6R   5g      5h      5i      5k      5l      