   M S B A M L   `   `   `  ����P  LTotally Not a Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Totally_Not_a_ProgramTotally_Not_a_Program  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   &     Totally_Not_a_Program.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Totally_Not_a_Program     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   -   5          �Name$  MainForm��5   	    � Title$ 
MainWindow��5	   	   $	��573��6   $
��1169��6)    � 
ResizeMode$ NoResize=�66    � WindowStyle$
 None=�6L   .��5
      � -   5         �Name$ MainGrid��5
      ��. $
��Auto=�6B   $	��573��6t   $	��Top=�6�   $
��Left=�6�   $
��1169��6�   .+�5   
   � $
��Left=�6   $��36��6*   $	��Top=�66   $	��204��6N   
����p��6Z   � 5   
   $
��Left=�6   $	��537��6*   $��0,36,0,0q�67   $	��Top=�6I   $	��204��6a   ���	#FF292728.+�5      � -   5        $ 
gdrBtnHome��5      $
��Left=�6'   $��44��6B   $��0,10,0,0q�6N   $	��Top=�6`   $	��204��6x    J� RenderTransformOrigin$ 0.5,0.5&�6�   .+�5      �� -   5         ��Name$ lblHome��5      $
��Home��6)   $
��Left=�68   $��	41,10,0,0q�6S   $	��148��6f   
�������$��Microsoft Sans Serif)�6�   $��20(�6�   $
��Bold"�6�   $��30��6�   $	��Top=�6�   ��6r   Z� 6�   �� 5      -   5         ��Name$ 
imgHomeIMG��5   F    �� BitmapScalingMode$ HighQuality=�6   $
��Left=�6Z   $��36��6u   $	��Top=�6�   $��36��6�   $,��&Resources/baseline_home_white_48dp.png��6�   $��0,4,0,0q�6�   $
��Fill=�6�   5      � 5      -   5        $ gdrSpeedTestBtn��5      $
��Left=�6,   $��44��6G   $��0,59,0,0q�6S   $	��Top=�6e   $	��204��6}   .+�5      �� -   5        $ lblSpeedTest��5      $��	SpeedTest��6.   $
��Left=�6B   $��	41,10,0,0q�6]   $	��143��6p   
�������$��Microsoft Sans Serif)�6�   $��20(�6�   $
��Bold"�6�   $��30��6�   $	��Top=�6�   ��6|   Z� 6�   �� 5      -   5        $ imgSpeedTest��5   F   $ HighQuality=�6   $
��Left=�6\   $��36��6w   $	��Top=�6�   $��36��6�   $%��Resources/speedometer_white.png��6�   $��0,4,0,0q�6�   $
��Fill=�6�   5      � 5      -	   5        $ gdrPasswordBtn��5      $
��Left=�6+   $��44��6F   $��	0,108,0,0q�6R   $	��Top=�6e   $	��204��6}   .+�5      �� -
   5        $ lblPassword��5      $��Password��6-   $
��Left=�6@   $��	41,10,0,0q�6[   $	��153��6n   
�������$��Microsoft Sans Serif)�6�   $��20(�6�   $
��Bold"�6�   $��30��6�   $	��Top=�6�   ��6z   Z� 6�   �� 5      -   5        $ imgPassword��5   F   $ HighQuality=�6   $
��Left=�6[   $��36��6v   $	��Top=�6�   $��36��6�   $,��&Resources/baseline_lock_white_48dp.png��6�   $��0,4,0,0q�6�   $
��Fill=�6�   5      5      � 5   
   -   5        $ 	gdrTopBar��5      $
��Left=�6"   $��36��6=   $��	204,0,0,0q�6I   $	��Top=�6\   $	��965��6t   
�������.+�5      �� -   5        	 ��Name$	 btnClose��5      $�� ��6'   $
��Left=�62      ButtonStyleClose#���   6M   $��	925,3,0,0q�6y   $	��Top=�6�   $��30��6�   $��30��6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ HighQuality=�6!   
 �� ImageSource$,
 &Resources/outline_close_black_48dp.png��6O   5      �� 5       -   5        $	 btnHelp��5       $�� ��6&     ButtonStyleHelp#���  61   $
��Left=�6[   $��	855,3,0,0q�6v   $	��Top=�6�   $��30��6�   $��30��6�   ��6�   Z� ��6�   Z� ��5!      �� 5"      $ HighQuality=�6!   $3
 -Resources/outline_help_outline_black_48dp.png��6O   5$      �� 5%      -   5        $	 btnMinimize��5%      $�� ��6*   $
��Left=�65     ButtonStyleMinimize#���  6P   $��	890,3,0,0q�6~   $	��Top=�6�   $��30��6�   $��30��6�   ��6�   Z� ��6�   Z� ��5&      �� 5'      $ HighQuality=�6!   $0
 *Resources/baseline_minimize_black_48dp.png��6O   5)      5*          Totally_Not_a_Program.home  5+   
   -   5          Name$ 
usrCtrHome��5+      $
��Left=�6)   $	��523��6D   $��
209,41,0,0q�6Q   $	��Top=�6e   $	��951��6}   %   Totally_Not_a_Program.speedtest  5,   
   -   5          Name$ usrCtrSpeedTest��5,      $
��Left=�63   $��
209,41,0,0q�6N   $	��Top=�6b   5.      5/      