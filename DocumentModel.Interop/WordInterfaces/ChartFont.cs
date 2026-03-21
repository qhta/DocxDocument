namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains the font attributes (font name, font size, color, and so on) for an object chart.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont?view=word-pia"/>
public interface ChartFont : InteropObject
{
  /// <summary>
  /// The background.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.background?view=word-pia"/>
  public object Background { get; set; }
  /// <summary>
  /// The bold.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.bold?view=word-pia"/>
  public object Bold { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The font style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.fontstyle?view=word-pia"/>
  public object FontStyle { get; set; }
  /// <summary>
  /// The italic.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.italic?view=word-pia"/>
  public object Italic { get; set; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.name?view=word-pia"/>
  public object Name { get; set; }
  /// <summary>
  /// The outline font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.outlinefont?view=word-pia"/>
  public object OutlineFont { get; set; }
  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.shadow?view=word-pia"/>
  public object Shadow { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.size?view=word-pia"/>
  public object Size { get; set; }
  /// <summary>
  /// The strike through.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.strikethrough?view=word-pia"/>
  public object StrikeThrough { get; set; }
  /// <summary>
  /// The subscript.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.subscript?view=word-pia"/>
  public object Subscript { get; set; }
  /// <summary>
  /// The superscript.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.superscript?view=word-pia"/>
  public object Superscript { get; set; }
  /// <summary>
  /// The underline.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.underline?view=word-pia"/>
  public object Underline { get; set; }

}
