namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a portion of text or a graphic in a page. Use the Rectangle object and related methods and
/// properties for programmatically defining page layout in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle?view=word-pia"/>
public interface Rectangle : InteropObject
{
  /// <summary>
  /// Returns a RectangleType constant that represents the type for the specified rectangle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.rectangletype?view=word-pia"/>
  public RectangleType RectangleType { get; }
  /// <summary>
  /// Returns or sets an integer that represents the horizontal position of the specified rectangle, measured in
  /// points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.left?view=word-pia"/>
  public int Left { get; }
  /// <summary>
  /// Returns or sets the vertical position of the specified rectangle, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.top?view=word-pia"/>
  public int Top { get; }
  /// <summary>
  /// Returns or sets the width of the specified rectangle, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.width?view=word-pia"/>
  public int Width { get; }
  /// <summary>
  /// Returns or sets the height of the specified rectangle, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.height?view=word-pia"/>
  public int Height { get; }
  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Returns a Lines collection that represents the lines in a specified portion of text in a page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.lines?view=word-pia"/>
  public Lines Lines { get; }

}
