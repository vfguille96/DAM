   M S B A M L   `   `   `  ����   PROG_REL9_Ej3_Vera_Guillermo-    'PROG_REL9_Ej3_Vera_Guillermo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Acierta mi número��5   	   $��285.821��6#   $	��542��64    � 
ResizeMode$ CanMinimize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5	      $	��69* �6   .+�5   
   �� -   5         ��Name$ btnGenerarNumero��5      $��Generar número��6+   $
��Left=�6D   $��	85,64,0,0q�6_   $	��Top=�6r   $	��120��6�    � ToolTip$2 ,Se generará un número random del 0 al 100.��6�    � Cursor$
 Hand��6�   �� 5   
   -   5        $ 	btnProbar��5      $��Probar��6$   $
��Left=�65   $��
349,31,0,0q�6P   $	��Top=�6d   $��75��6|   $&  Probar si el número es correcto��6�   $��1��6�   $
 Hand��6�   �� 5   
   -   5         ��Name$ txbxEscribirNumero��5      $
��Left=�6.   $��23��6I   $��	85,31,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $��54��6�   $' !Escribe un número entre 0 y 100.��6�    �� 	MaxLength$ 3��6�   $��1��6�   	 � ForceCursor	 . 6�   �� 5   
   -   5        
 ��Name$
 chbxVerNumero��5      $��Ver número��6*   $
��Left=�6?   $��
349,67,0,0q�6Z   $	��Top=�6n   $ Ver el número generado.��6�   6�   �� 5   
   $
��Left=�6   $��85,7,0,0q�6/   $
��Wrap=�6A   $	��Top=�6U   $��19��6m   $	��120��6y   $��1��6�   �� 6�    � Language$ es-es�6�   $�Acierta el número��6�   �� 6�   �� 6�   $ es-es�6�   6�   �� 5   
   -   5         ��Name$ txbkResultado��5      $
��Left=�6+   $��	85,80,0,0q�6F   $
��Wrap=�6Y   $	��Top=�6m   $��32��6�   $	��339��6�   $��16(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -   5        $ txtbkVerNumero��5      $
��Left=�6,   $��
445,67,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o    J� IsHitTestVisible . $y�Hidden=�6�   �� 6�   $ es-es�6�   $
�==> ��6�   6�   �� 5   
   -   5        $ txtbkNumero��5      $
��Left=�6)   $��
445,67,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $��50��6�   $��19��6�   5      5      