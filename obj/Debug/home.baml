   M S B A M L   `   `   `  ����P  LTotally Not a Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Totally_Not_a_ProgramTotally_Not_a_Program  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5           Totally_Not_a_Program.home   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Totally_Not_a_Program     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      $	��951��5	   #   $	��523��6/   .��5
      � -   5          �Name$  
usrctrHome��5
      $	��951��6   $	��523��6+   ���	#FFD2D2D2.+�5   
   � -   5        $  gdrCPUUsage��5      $
��Left=�6$   $	��249��6?   $��	10,10,0,0q�6L   $	��Top=�6_   $	��249��6w   
����p��.+�5        LiveCharts.Wpf.PieChart  -   5          Name$ CPUChart��5   4   &   LiveCharts.Wpf.Charts.Base.Chart   DisableAnimations .    	Hoverable .  $��0,26,0,0q�6o      DataTooltip 6X   Z� 5      A� 5      ���	#FFF4F4F5$��49,61,50,38q�6'   
���   �$��Center=�6K   $��Center=�6f   $	��150��6�   $	��150��6�   �� 5      -   5         ��Name$ lblCPUUsage��5      $
��Left=�6-   $
��Wrap=�6H   $��
Uso de CPU��6\   $	��Top=�6n   $��26��6�   $	��249��6�   
�������$��Microsoft Sans Serif)�6�   $��24(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   �� 5      -   5         ��Name$ lblCPUUsageLabel��5      $��8%��6.   $��Center=�6;   $��0,26,0,0q�6X   $��Center=�6j    J� RenderTransformOrigin$ -1.026,-1.365&�6�   $��24(�6�   5      � 5   
   -   5        $  gdrRAMUsage��5      $
��Left=�6$   $	��249��6?   $��
264,10,0,0q�6L   $	��Top=�6`   $	��249��6x   
����p��.+�5        -   5        $ RAMChart��5   4    .  .  $��0,26,0,0q�6o    6X   Z� 5*      A� 5+      ���	#FFF4F4F5$��49,61,50,38q�6'   
���   �$��Center=�6K   $��Center=�6f   $	��150��6�   $	��150��6�   �� 5,      -   5        $ lblRAMUsage��5,      $
��Left=�6-   $
��Wrap=�6H   $��
Uso de RAM��6\   $	��Top=�6n   $��26��6�   $	��249��6�   
�������$��Microsoft Sans Serif)�6�   $��24(�6�   $
��Bold"�6�   $ Center=�6�   �� 5-      -	   5        $ lblRAMUsageLabel��5-      $��8%��6.   $��Center=�6;   $��0,26,0,0q�6X   $��Center=�6j   $ -1.026,-1.365&�6�   $��24(�6�   5.      � 5/   
   -
   5        $  gdrHDDUsage��5/      $
��Left=�6$   $	��249��6?   $��
10,264,0,0q�6L   $	��Top=�6`   $	��249��6x   
����p��.+�50        -   5        $ HDDChart��50   4    .  .  $��0,26,0,0q�6o    6X   Z� 5?      A� 5@      ���	#FFF4F4F5$��49,61,50,38q�6'   
���   �$��Center=�6K   $��Center=�6f   $	��150��6�   $	��150��6�   �� 5A      -   5        $ lblHDDUsage��5A      $
��Left=�6-   $
��Wrap=�6H   $��
Uso do HDD��6\   $	��Top=�6n   $��26��6�   $	��249��6�   
�������$��Microsoft Sans Serif)�6�   $��24(�6�   $
��Bold"�6�   $ Center=�6�   �� 5B      -   5        $ lblHDDUsageLabel��5B      $��8%��6.   $��Center=�6;   $��0,26,0,0q�6X   $��Center=�6j   $ -1.026,-1.365&�6�   $��24(�6�   5C      � 5D   
   -   5        $  gdrInternetUsage��5D      $
��Left=�6)   $	��249��6D   $��264,264,0,0q�6Q   $	��Top=�6f   $	��249��6~   
����p��.+�5E      �� -   5        $ lblInternetUsage��5E      $
��Left=�62   $
��Wrap=�6M   $��Uso de Internet��6a   $	��Top=�6x   $��26��6�   $	��249��6�   
�������$��Microsoft Sans Serif)�6�   $��24(�6�   $
��Bold"�6�   $ Center=�6�   �� 5F      -   5        $ lblNetUpload��5F      $��Upload:��6*   $��Center=�6<   $��10,66,148,141q�6Y   $��Center=�6p   $ -1.026,-1.365&�6�   $��24(�6�   $��91��6�   �� 5G      -   5        $ lblNetUploadA��5G      $
��Mbps��6+   $��Center=�6:   $��106,66,10,141q�6W   $��Center=�6n   $ -1.026,-1.365&�6�   $��24(�6�   $	��133��6�   5H      � 5I   
   -   5        $  gdrNetworkUsage��5I      $
��Left=�6(   $	��503��6C   $��
518,10,0,0q�6P   $	��Top=�6d   $	��423��6|   
����p��.+�5J      �� -   5        $ lblNetworkUsage��5J      $
��Left=�61   $
��Wrap=�6L   $��Uso de Internet��6`   $	��Top=�6w   $��26��6�   $	��423��6�   
�������$��Microsoft Sans Serif)�6�   $��24(�6�   $
��Bold"�6�   $ Center=�6�   5L      5M      5N      