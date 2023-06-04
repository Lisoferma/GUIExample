using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;

namespace GUIExample;

/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Прямоугольник.
    private readonly Rectangle _rectangle;


    public MainWindow()
    {
        InitializeComponent();

        _rectangle = new();
        DataContext = _rectangle;
    }
}
