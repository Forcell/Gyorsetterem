   M S B A M L   `   `   `  ����B  >Etterem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EtteremEtterem  5           Etterem.UserControlFizetes   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Etterem     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��700 �6   �� 5      $��* �6   .+�5   
   � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgFizetes��5      $	��700��6*   $
��Left=�66      AutoGenerateColumns$
 True��6Q      
IsReadOnly$
 True��6l   $
��auto��6~   5      5      (  "MaterialDesignThemes.Wpf.ColorZone  5   
      Mode$ 
PrimaryMid=�6#   $��1��65   $��Stretch=�6E   $��Stretch=�6c   .��5      �  � RowDefinitions 5      �� 5      $	��388 �6$   �� 5      $	��100 �6$   �� 5      $��* �6$   .+�5!      �� -   5         ��Name$ 	spFizetes��5!      $��1��60   $��10q�6@   $��Center=�6L   .+�5"      �� $��
Összesen:��6    $��Center=�61   $��Center=�6L   $��30(�6i   $��Bahnschrift Condensed)�6w   �� 5#      -   5         ��Name$ tbVegosszeg��5#       $��Center=�65   $�� ��6P   $��50(�6X   $��Center=�6f   $��Bahnschrift Condensed)�6�   5$      �� 5%      -   5         ��Name$ 	btKifizet��5%      $��1��6,   $��Center=�69   $��Center=�6V   $��Fizetés��6q   $��50��6�   $	��120��6�   
������� #  MaterialDesignRaisedLightButton#���   6�   6�   �� 5&      -   5        $ btVissza��5&      $��2��6+   $��Vissza��68   $��Bahnschrift Condensed)�6I   $
��Bold"�6l   $��Bottom=�6~   
�������  MaterialDesignFlatButton#���  6�   6�   5'      5(      5*      5+      