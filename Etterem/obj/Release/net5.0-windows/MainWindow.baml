   M S B A M L   `   `   `  ���� B  >Etterem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EtteremEtterem      Etterem.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Etterem     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Icon$  Images/Logo.png�� � Title$ 	McTömlek��$	��600��$
��1200�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��auto ��� $��* � � ColumnDefinitions �� $	��250 ��� $��* �.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��2��$��Stretch=�.��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ KERESÉS��$��Center=�
�������$	��300��$��15(�.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 �����'  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Magnify=�
�������$��25��$��25��$��Center=�$��5q��� $ 
Horizontal=�$��Center=�$��Right=�$��50, 0q�.+�'  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�$��Right=�   	StaysOpen$ False��   ToggleContent   -   $

 Cart=�
�������$��25��$��25��$��Center=�$��5q�   PopupContent. �� $	��200��.+��� -    ��Name$ 
KosarLista���� -   $��Urites��$��	Ürítés��$��Center=��� -   $��Fizetes��$��Fizetés��$��Center=��� -    ��Name$ KosarOsszesDarab��$��Center=�
�������$��18(�$��0���� $��Right=�$��10q�.+�  $ BottomAndAlignRightEdges=�$��Right=�$ False��. �� $	��150��.+��� -   $��btLogin��$��Login���� -   $��btExit��$
��Exit��� $��Stretch=�$��1��   PrimaryHueMidBrush#��[   �� $��8* ��� $	��17* � �� $��70 ��� $	��53* �.+�� -    �Name$ LogoRow��$��0��
�������$��2��.+��� -	    ��Name$ HomeLogo��$��Images/McTomlek2.png���� $��Disabled=�$
��Auto=�$��1��$��2��.���� -
    ��Name$
 Menu��$��10q�� $��1��$��1��.+��� $��Center=�$	��950��$	��538��$	��Top=�$��Hidden=�.���� -   $ StackPanelMain��$��1��$��1��$��Stretch=�