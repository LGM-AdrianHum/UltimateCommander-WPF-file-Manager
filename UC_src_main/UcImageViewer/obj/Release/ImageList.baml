   M S B A M L   `   `   `  ����   UcImageViewer    UcImageViewer.ImageList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $	��300��$	��500��  N� Title$  	ImageList�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$
 Open��.��]� -   $��mainDockPanel��.+�o� -   $��mainMenu��$	��Top=�$y�Hidden=�.@�m� $��
Файлы��.@�m� $ ��Открыть файл...�� m� Command$
 Open���� m� $1��+Очистить представление��$ Close���� m� $��Сохранить��$
 Save��m� $"��Сохранить как...��$ SaveAs���� m� $#��Последние файлы��.@�m� $��Коллекция��m� $��Изображение��.@�m� -   $-��'Просмотр изображения��
 � Tag$ maximazeBtn��m� -   $/��)Следующее изображение��$ BrowseForward��$ 
forwardBtn��m� -   $1��+Предыдущее изображение��$ 
BrowseBack��$ backBtn���� m� -   $��Слайд шоу��$ playBtn��m� $"��Редактирование��.@�m� -	   $��Черно-белое��$ 	Grayscale��m� -
   $%��Отобразить цвета��$ 	Inversion���� m� -   $"��Повернуть на 180*��$ 	Rotate180��m� -   $5��/Повернуть на 90* по часовой��$ Rotate90��m� -   $=��7Повернуть на 90* против часовой��$ 	Rotate-90��m� -   $2��,Отразить по горизонтали��$ FlipHorizontal��m� -   $.��(Отразить по вертикали��$ FlipVertical��m� $��Настройки��.@�m� -   $��Список�� m� IsCheckable .  m� 	IsChecked . $
 List��m� -   $��Изображение�� .  . $ Image��m� -   $"��Редактирование�� .  . $ TabPanel��m� -   $��Панель кнопок�� .  . $ 	StatusBar���� -   $��	statusBar��$��Bottom=�$��Center=�.@��� -   $��backBtn��$��26��$��26��$��50�� � ToolTip$1 +Предыдущее изображение��.���� $R��Lpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/backward.png���� -   $��playBtn��$��26��$��26��$��50��$&  Автопроигрывание��.���� -   $��playStopImg��$N��Hpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/play.png���� -   $��
forwardBtn��$��26��$��26��$��50��$/ )Следующее изображение��.���� $Q��Kpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/forward.png���� -   $��maximazeBtn��$��26��$��26��$��50��$ На весь экран��.���� $O��Ipack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/paste.png���� -   $
��save��$��26��$��26��$��50��$��1q�$
��Save��$ Сохранить��.���� $N��Hpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/save.png���  � ColumnDefinitions �� -   	 �Name$	 listDef��$	��100��$	��20* ��� -   $	 splitDef��$
��auto ��� -   $	 imgDef��$	��100��$	��80* �
 � RowDefinitions
 �� .+�]� -   $��imgGrid��$��2��.+��� -   $��imageDescription��$	��Top=�$��0,3,0,3q�$��Verdana)�$��9(�$
��Bold"����	#FF9A9A9A$#��нет изображения��$��Center=��� -    $��
tabControl��$��Bottom=�.@��� $��Повороты�� �� 
IsSelected . .���� $��Center=� �� Orientation$ 
Horizontal=�.+��� -!   $��rotateMinus��$��5,2,0,2q�$��26��$��26��$��26��$��1q�$��Center=�$ Поворот на 90*��.���� $��3q�$T��Npack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/rotate_ccw.png���� -"   $��
rotatePlus��$��5,2,0,2q�$��26��$��26��$��26��$��1q�$��Center=�$ Поворот на -90*��.���� $��3q�$S��Mpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/rotate_cw.png���� -#   $��flipHor��$��5,2,0,2q�$��26��$��26��$��26��$��1q�$��Center=�$2 ,Отразить по горизонтали��.���� $��3q�$X��Rpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/flipHorizontal.png���� -$   $��flipVert��$��5,2,0,2q�$��26��$��26��$��26��$��1q�$��Center=�$. (Отразить по вертикали��.���� $��3q�$V��Ppack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/flipVertical.png���� $��5,0,0,0q�$��Center=�$��Center=�.��	угол:�� -%   $��angleSlider��$	��100��$��5,0,0,0q� � Minimum$ 0Q� � Maximum$	 360Q�$��Center=��� -&   $��angleTextBox��$��5,0,0,0q�$��45��$��22�� �� 	MaxLength$ 3�� �� TextAlignment$ Center=� �� 
IsReadOnly .  $��Center=��� $��2,0,5,0q�$��Center=�$��Center=�.��°�� $��Цвет��.���� $ 
Horizontal=�.+��� $��5q�$ Vertical=�$��Center=�.+��� -'   $��makeGray��$��0,2,0,2q�$��26��$��26��$��26��$��1q�$ Черно-белое��.���� $��3q�$N��Hpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/fill.png���� -(   $��makeBlackWhite��$��0,2,0,2q�$��26��$��26��$��26��$��1q�$ Инверсия��.���� $��3q�$S��Mpack://application:,,,/JoyOs.Media;component/img/Plugins/Photos/fillBlack.png���� $��60��$��60��$ Vertical=�$��Center=�.+��� -)   $��	colorRect��
���   �$��60��$��60��$��2������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� .+��� $��3,5,3,0q�$ 
Horizontal=�.+��� $��Center=�.��R:�� -*   $��redColorSlider��$��Center=�$��5,0,5,0q�$	��100��$	 255Q��� -+   $��redColorText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"��� $��3,5,3,0q�$ 
Horizontal=�.+��� $��Center=�.��G:�� -,   $��greenColorSlider��$��Center=�$��4,0,5,0q�$	��100��$	 255Q��� --   $��greenColorText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"��� $��3,5,3,5q�$ 
Horizontal=�.+��� $��Center=�.��B:�� -.   $��blueColorSlider��$��Center=�$��5,0,5,0q�$	��100��$	 255Q��� -/   $��blueColorText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"�A� $��Center=� A� Rows$ 0�� A� Columns$ 1��.+��� $��Яркость���� $ 
Horizontal=�.+��� -0   $��britnessColorSlider��$��0,0,5,0q�$��Center=�$	 255Q�$
 -255Q�$	��100���� -1   $��brigtnessColorText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"�.���� $ ��Контрастность���� $ 
Horizontal=�$��Stretch=�.+��� -2   $��contrastColorSlider��$ 1Q�$��0,0,5,0q�$��Center=�$ 0Q�$	��100���� -3   $��contrastColorText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"��� $��Прочее��.���� $ Vertical=�.+��� $��5,5,5,5q�$��Center=�$ 
Horizontal=�.+��� $��Center=�.��Скручивание:�� -4   $��twistedSlider��$��Center=�$��4,0,5,0q�$	��100��$
 -200Q�$	 200Q��� -5   $��twistedText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"��� $��Увеличение��.���� $ Vertical=�.+��� $��5,5,5,5q�$��Center=�$ 
Horizontal=�.+��� $��Center=�.��Увеличение:�� -6   $��
zoomSlider��$��Center=�$��4,0,5,0q�$	��100��$ 0Q�$	 400Q� �� IsSnapToTickEnabled .  {�. �� -7   $��zoomText��$��20��$��35��$ 3��$ Center=�$��10(�$
��Bold"��� -8   $��viewImg��$
��Auto=�$
��Auto=�.���� -9   $��bigImage��$9��3/JoyOs.Media;component/img/Plugins/Photos/PHOTO.ico��$��Uniform=��� -:   $��	gridSplit��$��3��$��1��$��Center=� �� ShowsPreview . �� -;   $��imgList��|�.  $��0��.��� -<   $��imgWrapList��