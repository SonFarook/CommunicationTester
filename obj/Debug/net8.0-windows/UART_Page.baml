   M S B A M L   `   `   `  ����N  JCommunicationTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CommunicationTesterCommunicationTester  5      #    CommunicationTester.UART_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CommunicationTester     5        N� Title$  	UART_Page��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��	Baundrate��6   $��80��6,   $
��Left=�67   $��
50,30,0,10q�6R   �� 5      -   5        $��BR_comboBox��5   }   $	��120��6   $��20��6'   $
��Left=�63   $��	50,0,10,0q�6N   6}   �� 5      $��Com Port��6   $��70��6+   $
��Left=�66   $��	50,20,0,0q�6Q   �� 5      -   5        $��COM_comboBox��5   }   $	��120��6   $��20��6'   $
��Left=�63   $��50,5,0,0q�6N   6}   �� 5      -   5        $��Connect_btn��5   ~   $��25��6   $��80��6%   $��Connect��60   $��12(�6B   $
��Left=�6P   $��	70,10,0,0q�6k   6�   5      5      � 5   
   $��1��6   .+�5      �� $ Vertical=�6   .+�5      �� $��Send Message��6   $��
50,30,0,10q�6/   $	��100��6C   $
��Left=�6O   �� 5      -   5        $��Send_textBox��5   `   $��20��6   $	��100��6&   $��	50,0,10,0q�62   $
��Left=�6E   6`   �� 5      -   5        $
��Send��5      $��25��6(   $��80��64   $��
58,10,10,0q�6?   $��12(�6S   $
��Left=�6a   6|   5       5!      � 5"   
   $��2��6   .+�5#      �� .+�5$      �� $��Get Message��6   $��
50,30,0,10q�6*   $	��100��6>   $
��Left=�6J   �� 5%      -   5        $��Get_listBox��5%   ]   $	��150��6   $	��100��6#   $��	50,0,10,0q�6/   $
��Left=�6B   6]   �� 5&      -   5        $	��Get��5&      $��25��6#   $��80��6/   $��
58,10,10,0q�6:   $��12(�6N   $
��Left=�6\   6w   5'      5(      5)      5*      