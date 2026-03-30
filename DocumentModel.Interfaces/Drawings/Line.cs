namespace DocumentModel.Drawings;

/// <summary>
/// Represents an individual line in a Rectangle object of type wdTextRectangle.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line?view=word-pia"/>
public interface ILine : IModelObject
{
  /// <summary>
  /// Returns the type of line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.linetype?view=word-pia"/>
  public LineType LineType { get; }
  /// <summary>
  /// Returns the horizontal position of the line, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.left?view=word-pia"/>
  public int Left { get; }
  /// <summary>
  /// Returns the vertical position of the line, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.top?view=word-pia"/>
  public int Top { get; }
  /// <summary>
  /// Returns the width of the line, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.width?view=word-pia"/>
  public int Width { get; }
  /// <summary>
  /// Returns the height of the line, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.height?view=word-pia"/>
  public int Height { get; }
  /// <summary>
  /// Returns a range object that represents the line in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Returns a rectangles collection that includes the rectangle objects in the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.rectangles?view=word-pia"/>
  public IRectangles Rectangles { get; }

}
