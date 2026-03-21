namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a portion of text or a graphic in a page. Use the Rectangle object and related methods and properties for programmatically defining page layout in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle?view=word-pia"/>
public interface Rectangle : InteropObject
{
  /// <summary>
  /// Returns the rectangle type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.rectangletype?view=word-pia"/>
  public WdRectangleType RectangleType { get; }
  /// <summary>
  /// Returns the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.left?view=word-pia"/>
  public int Left { get; }
  /// <summary>
  /// Returns the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.top?view=word-pia"/>
  public int Top { get; }
  /// <summary>
  /// Returns the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.width?view=word-pia"/>
  public int Width { get; }
  /// <summary>
  /// Returns the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.height?view=word-pia"/>
  public int Height { get; }
  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Returns the lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.lines?view=word-pia"/>
  public Lines Lines { get; }

}
