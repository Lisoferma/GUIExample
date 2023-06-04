using System;
using System.ComponentModel;

namespace GUIExample;

/// <summary>
/// Прямоугольник.
/// </summary>
public class Rectangle : INotifyPropertyChanged
{
    // Ширина.
    private double _width;

    // Высота.
    private double _height;


    /// <summary>
    /// Ширина.
    /// </summary>
    public double Width
    {
        get => _width;

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Width), "Width cannot be < 0");

            _width = value;

            RaisePropertyChanged(nameof(Width));
            RaisePropertyChanged(nameof(Area));
        }
    }


    /// <summary>
    /// Высота.
    /// </summary>
    public double Height
    {
        get => _height;

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Width), "Height cannot be < 0");

            _height = value;

            RaisePropertyChanged(nameof(Height));
            RaisePropertyChanged(nameof(Area));
        }
    }


    /// <summary>
    /// Инициализирует прямоугольник нулевой шириной и высотой.
    /// </summary>
    public Rectangle() : this(0, 0) { }


    /// <summary>
    /// Инициализирует прямоугольник заданной шириной и высотой.
    /// </summary>
    /// <param name="width">Ширина.</param>
    /// <param name="height">Высота</param>
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }


    /// <summary>
    /// Вычислиить площадь прямоугольника.
    /// </summary>
    /// <returns>Площадь прямоугольника.</returns>
    public double Area
    {
        get => _width * _height;
    }

    
    /// <summary>
    /// Обработчики которые нужно вызвать при изменении.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged; 


    /// <summary>
    /// Вызывать обработчики которые подписаны на изменение свойств.
    /// </summary>
    /// <param name="propertyName">Название свойства.</param>
    public void RaisePropertyChanged(string propertyName)
    {
        // Если кто-то на него подписан, то вызывем его
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
