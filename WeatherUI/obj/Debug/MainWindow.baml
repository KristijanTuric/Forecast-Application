   M S B A M L   `   `   `  ����D  @WeatherUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WeatherUI	WeatherUI  5   	       WeatherUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WeatherUI     5   	     � Title$  Forecast��5   	   $	��450��5	   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5
   	   $��Cambria)�5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � -   5         �Name$
 main��5       � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $
��75px �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��5      $��Forecast��5      $��28(�5       $��3��5!      $��Center=�5"      $��Center=�5#      �� 5%   
   $��1��6   $��0��5&      $��Enter Location:��5'      $��Right=�5(      $��Center=�5)      $��18(�5*      $
��10pxq�5+      �� 5-   
   -   5        $��inputLocation��56      $��1��5-      $��1��5.      $	��230��5/      $
��30px��50      $��Center=�51      $��Center=�52      $
��10pxq�53      $��18(�54      $	��1pxq�55      56      �� 58   
   -   5        $��btn_Find��58      $��1��59      $��2��5:      $��Current��5;      $
��10pxq�5<      $��Center=�5=      $
��Left=�5>       �� 	IsDefault . 5@      �� 5B   
   -   5        $��btn_Forecast��5C      $��Forecast��5B      $��1��5D      $��2��5E      $��30 0 0 0q�5F      $��Center=�5G      $��Center=�5H      5I      �� 5M   
   -   5        $��cellOne��5O      $��2��5M      $��0��5N      $
��15px(�5P      $��Center=�5Q      $��Center=�5R       �� TextAlignment$ Center=�5S      �� 5V   
   -   5        $��cellTwo��5X      $��2��5V      $��1��5W      $
��15px(�5Y      $��Center=�5Z      $��Center=�5[      $ Center=�5\      �� 5_   
   -   5        $��	cellThree��5a      $��2��5_      $��2��5`      $
��15px(�5b      $��Center=�5c      $��Center=�5d      $ Center=�5e      �� 5h   
   -   5        $��cellFour��5j      $��3��5h      $��0��5i      $
��15px(�5k      $��Center=�5l      $��Center=�5m      $ Center=�5n      �� 5q   
   -	   5        $��cellFive��5s      $��3��5q      $��1��5r      $
��15px(�5t      $��Center=�5u      $��Center=�5v      $ Center=�5w      �� 5z   
   -
   5        $��cellSix��5|      $��3��5z      $��2��5{      $
��15px(�5}      $��Center=�5~      $��Center=�5      $ Center=�5�      5�      5�      