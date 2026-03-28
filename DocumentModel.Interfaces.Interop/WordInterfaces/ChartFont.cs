namespace DocumentModel.Interop;

/// <summary>
/// Contains the font attributes (font name, font size, color, and so on) for an object chart.
/// </summary>
public interface ChartFont : InteropObject
{
  /// <summary>
  /// The background.
  /// </summary>
  public object Background { get; set; }
  /// <summary>
  /// The bold.
  /// </summary>
  public object Bold { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The font style.
  /// </summary>
  public object FontStyle { get; set; }
  /// <summary>
  /// The italic.
  /// </summary>
  public object Italic { get; set; }
  /// <summary>
  /// The name.
  /// </summary>
  public object Name { get; set; }
  /// <summary>
  /// The outline font.
  /// </summary>
  public object OutlineFont { get; set; }
  /// <summary>
  /// The shadow.
  /// </summary>
  public object Shadow { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  public object Size { get; set; }
  /// <summary>
  /// The strike through.
  /// </summary>
  public object StrikeThrough { get; set; }
  /// <summary>
  /// The subscript.
  /// </summary>
  public object Subscript { get; set; }
  /// <summary>
  /// The superscript.
  /// </summary>
  public object Superscript { get; set; }
  /// <summary>
  /// The underline.
  /// </summary>
  public object Underline { get; set; }

}
