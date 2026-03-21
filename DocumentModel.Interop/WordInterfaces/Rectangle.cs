namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a portion of text or a graphic in a page. Use the Rectangle object and related methods and properties for programmatically defining page layout in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle?view=word-pia"/>
public interface Rectangle : InteropObject
{
  /// <summary>
  /// The rectangle type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.rectangletype?view=word-pia"/>
  public WdRectangleType RectangleType { get; }
  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.left?view=word-pia"/>
  public int Left { get; }
  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.top?view=word-pia"/>
  public int Top { get; }
  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.width?view=word-pia"/>
  public int Width { get; }
  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.height?view=word-pia"/>
  public int Height { get; }
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// The lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangle.lines?view=word-pia"/>
  public Lines Lines { get; }

}
