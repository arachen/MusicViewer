   M S B A M L   `   `   `  ����F  BMusicViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MusicViewer.ViewModelsMusicViewer.ViewModels  5   	   *    $MusicViewer.Views.UpdateorDeleteView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6local$clr-namespace:MusicViewer.ViewModels     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ UpdateorDeleteView��5   	   $	��600��6$   $	��350��61   .��5
      � -   5        $��UpdateorDeleteGrid��5
       � ColumnDefinitions 5   
   �� 5      $��14 �6   �� 5      $��93 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��2��6$   $��0��5      $��22,10,36,10q�5      $��Center=�5       $��20(�5!      $ ��View, Update, Delete Album��5"      �� 5$   
   $��0��6   $��1��5%      $��10q�5&      $��Select to View:��5'      $��2��6*   �� 5(   
   $��0��6   $��2��5)      $��10q�5*      $��Album Name:��5+      $��2��6&   �� 5,   
   $��0��6   $��4��5-      $��10q�5.      $��Artist Name:��5/      $��2��6'   �� 50   
   $��0��6   $��6��51      $��10q�52      $��Album Cover:��53      $��2��6'   �� 55   
   -   5        $��albumComboBox��55      $��2��56      $��1��57      $��
10,20,10,0q�58      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5;       �� SelectedIndex$ 0��5<       �� DisplayMemberPath$ 	AlbumName��5=      ��59      ��  �� Path$ NewAlbumsCollection� �� SelectedItem 5:      �� $ SelectedItem�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�5=      �� 5>   
   -   5        $��albumNameTextBox��5>      $��2��5?      $��2��5@      $��10q�5A      {�.  ��5C      ��  �� ElementName$ albumComboBox��$ SelectedItem.AlbumName�$	 PropertyChanged=�$
 TwoWay=�� 5E   
   -   5        $��Update1Grid��5E      $��2��5F      $��3��5G       5H      �� 5I      �� 5J      $
��Auto �6#    5L      �� 5M      $
��Auto �6    .+�5O      �� -   5        $��albumNameUpdateTextBox��5O      $��0��5P      $��0��5Q      $��10q�5R      ��5S      �� $ UpdatedAlbumName�$	 PropertyChanged=�$
 TwoWay=��� 5T      -   5        $��albumNameUpdateBtn��5T      $��1��5U      $��0��5V      $��10q�5W      $��60��5X      $��Update��5Y      ��5Z      �� $ UpdateAlbumNameCommand�5[      �� 5]   
   -   5        $��artistNameTextBox��5]      $��2��5^      $��4��5_      $��10q�5`      {�.  ��5b      �� $ albumComboBox��$ SelectedItem.ArtistName�$	 PropertyChanged=�$
 TwoWay=�� 5d   
   -   5        $��Update2Grid��5d      $��2��5e      $��5��5f       5g      �� 5h      �� 5i      $
��Auto �6#    5k      �� 5l      $
��Auto �6    .+�5n      �� -	   5        $��artistNameUpdateTextBox��5n      $��0��5o      $��0��5p      $��10q�5q      ��5r      �� $ UpdatedArtistName�$	 PropertyChanged=�$
 TwoWay=��� 5s      -
   5        $��artistNameUpdateBtn��5s      $��1��5t      $��0��5u      $��10q�5v      $��60��5w      $��Update��5x      ��5y      �� $ UpdateArtistNameCommand�5z      � 5|   
   -   5        $��	imageGrid��5|      $��2��5}      $��6��5~      $��2��6    5      �� 5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $��albumCoverImage��5�      $��2��5�      $��0��5�      $��0��5�      $��10q�5�      $	��150��5�      $	��150��5�      ��5�      �� $ albumComboBox��$! SelectedItem.AlbumCoverPath�$	 PropertyChanged=�$
 TwoWay=��� 5�      -   5        $��showCoverPath��5�      $��0��5�      $��2��5�      $��1��5�      $��10q�5�      {�.  ��5�      �� $! SelectedItem.AlbumCoverPath�$	 PropertyChanged=��� 5�      -   5        $��albumCoverBrowseBtn��5�      $��0��5�      $��2��5�      $��10q�5�      $��80��5�      $��	Browse...��5�      ��5�      �� *#!BrowseUpdateAlbumCoverPathCommand+�� 5�      -   5        $��clearAlbumCoverBtn��5�      $��1��5�      $��3��5�      $��10q�5�      $��80��5�      $��Clear��5�      ��5�      �� *ClearUpdateAlbumCoverCommand+5�      �� 5�   
   $��3��6   $��8��5�      $��Stretch=�5�      $��10q�5�      $��Delete Album��5�      ��5�      �� $ RemoveAlbumCommand�5�      5�      