namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual line in a Rectangle object of type wdTextRectangle.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line?view=word-pia"/>
public interface Line : InteropObject
{
  /// <summary>
  /// The line type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.linetype?view=word-pia"/>
  public WdLineType LineType { get; }
  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.left?view=word-pia"/>
  public int Left { get; }
  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.top?view=word-pia"/>
  public int Top { get; }
  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.width?view=word-pia"/>
  public int Width { get; }
  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.height?view=word-pia"/>
  public int Height { get; }
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// The rectangles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.line.rectangles?view=word-pia"/>
  public Rectangles Rectangles { get; }

}
