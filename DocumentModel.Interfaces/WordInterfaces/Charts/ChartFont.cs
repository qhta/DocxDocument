namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains the font attributes (font name, font size, color, and so on) for an object chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont?view=word-pia"/>
public interface ChartFont : InteropObject
{
  /// <summary>
  /// Gets or sets the background fill type for the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.background?view=word-pia"/>
  public object Background { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is bold.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.bold?view=word-pia"/>
  public object Bold { get; set; }
  /// <summary>
  /// Gets or sets the primary color of the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the color index of the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the style of the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.fontstyle?view=word-pia"/>
  public object FontStyle { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is italic.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.italic?view=word-pia"/>
  public object Italic { get; set; }
  /// <summary>
  /// Gets or sets the name of the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.name?view=word-pia"/>
  public object Name { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is outlined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.outlinefont?view=word-pia"/>
  public object OutlineFont { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.shadow?view=word-pia"/>
  public object Shadow { get; set; }
  /// <summary>
  /// Gets or sets the size of the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.size?view=word-pia"/>
  public object Size { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is struck through.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.strikethrough?view=word-pia"/>
  public object StrikeThrough { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is subscript.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.subscript?view=word-pia"/>
  public object Subscript { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether the chart font is superscript.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.superscript?view=word-pia"/>
  public object Superscript { get; set; }
  /// <summary>
  /// Gets or sets the underline style for the chart font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfont.underline?view=word-pia"/>
  public object Underline { get; set; }

}
