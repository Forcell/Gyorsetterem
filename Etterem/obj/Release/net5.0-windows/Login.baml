   M S B A M L   `   `   `  ���� B  >Etterem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EtteremEtterem      Etterem.Login   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Etterem     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Login��$	��500��$	��350�� � 
ResizeMode$ NoResize=� � Icon$ Images/Logo.png�� � WindowStartupLocation$ CenterScreen=�$��Segoe UI Emoji)�.��� .+��� $��50��$	��Top=�$��1������ .���  � Color$ 
GhostWhite���� $	��280��$	��Top=�$��1������ .��� $ #5796fa���� $	��280��$	��240��$��Bottom=�$
��0,80q� �� RadiusY$ 0�� �� RadiusX$ 0��
�������$��1�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q�	   	Direction$	 0Q�
   RenderingBias$
 Quality=�   ShadowDepth$ 1Q�   Color$ 	#FFBBBBBB���� $��Images/McTomlek.png��$	��120��$	��120��$	��Top=�$��30q�$��1��� -    �Name$ 
Loginablak��$y�Visible=�.+�� $��Bottom=�$��35,80q�$	��240��$��1��.+��� $��BEJELENTKEZÉS��$��Center=�$	��Top=�$��5q�
�������$��18(��� $��Center=�$��15q�.+��� $
��0,10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ FELHASZNÁLÓNÉV�� %  !MaterialDesignFloatingHintTextBox#��[  $��Champagne & Limousines)�$��18(�G� $
��0,10q�$ JELSZÓ�� ) %MaterialDesignFloatingHintPasswordBox#��[ $��Champagne & Limousines)�$��18(��� $	��150��$��Center=�$��Bottom=�$
��0,65q�$��BEJELENTKEZÉS��$��1���� -   $��Regisztráció��$��Center=�$��	0,409,0,0q�$	��Top=�$��20��$��10(�
������ 
�������
������ �� -   $��Elfelejtett jelszó��$��Center=�$��	0,434,0,0q�$	��Top=�$��20��$��10(�
������ 
�������
������ � -   $ regablak��$y�	Collapsed=�.+�� $��Bottom=�$��35,80q�$	��240��$��1��.+��� $��REGISZTRÁCIÓ��$��Center=�$	��Top=�$��5q�
�������$��18(��� $��Center=�$��15q�.+��� $
��0,10q�$ FELHASZNÁLÓNÉV��#��[  $��Champagne & Limousines)�$��18(��� $
��0,10q�$ EMAIL��#��[  $��Champagne & Limousines)�$��18(�G� $
��0,10q�$ JELSZÓ��#��[ $��Champagne & Limousines)�$��18(��� -    ��Name$ Regisztráció��$	��150��$��Center=�$��Bottom=�$
��0,65q�$��Regisztráció��$��1��� -   $ ElfelejtettAblak��$y�	Collapsed=�.+�� $��Bottom=�$��35,80q�$	��240��$��1��.+��� $��ELFELEJTETT JELSZÓ��$��Center=�$	��Top=�$��5q�
�������$��18(��� $	��Top=�$��35q�.+��� $
��0,10q�$ EMAIL��#��[  $��Champagne & Limousines)�$��18(�� -   $ JelszoEleje��$y�	Collapsed=�.+��� $!��Jelszó első pár betűje:���� -   $ ElfelejtettJelszó��$	��150��$��Center=�$��Bottom=�$
��0,65q�$��Kérem a jelszót!��$��1��