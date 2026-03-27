namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents line and arrowhead formatting. For a line, the LineFormat object contains formatting information for the line itself; for a shape with a border, this object contains formatting information for the shape's border.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat?view=word-pia"/>
public interface LineFormat : InteropObject
{
  /// <summary>
  /// Returns a color format object that represents the background color for the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.backcolor?view=word-pia"/>
  public ColorFormat BackColor { get; }
  /// <summary>
  /// Returns or sets the length of the begin arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadlength?view=word-pia"/>
  public Drw.ArrowheadLength BeginArrowheadLength { get; set; }
  /// <summary>
  /// Returns or sets the style of the begin arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadstyle?view=word-pia"/>
  public Drw.ArrowheadStyle BeginArrowheadStyle { get; set; }
  /// <summary>
  /// Returns or sets the width of the begin arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadwidth?view=word-pia"/>
  public Drw.ArrowheadWidth BeginArrowheadWidth { get; set; }
  /// <summary>
  /// Returns or sets the dash style for the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.dashstyle?view=word-pia"/>
  public Drw.LineDashStyle DashStyle { get; set; }
  /// <summary>
  /// Returns or sets the length of the end arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadlength?view=word-pia"/>
  public Drw.ArrowheadLength EndArrowheadLength { get; set; }
  /// <summary>
  /// Returns or sets the style of the end arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadstyle?view=word-pia"/>
  public Drw.ArrowheadStyle EndArrowheadStyle { get; set; }
  /// <summary>
  /// Returns or sets the width of the end arrowhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadwidth?view=word-pia"/>
  public Drw.ArrowheadWidth EndArrowheadWidth { get; set; }
  /// <summary>
  /// Returns a color format object that represents the foreground color for the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }
  /// <summary>
  /// Returns or sets the fill pattern for the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.pattern?view=word-pia"/>
  public Drw.PatternType Pattern { get; set; }
  /// <summary>
  /// Returns or sets the style of the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.style?view=word-pia"/>
  public LineStyle Style { get; set; }
  /// <summary>
  /// Returns or sets the transparency of the line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Returns or sets whether the line is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.visible?view=word-pia"/>
  public TriState Visible { get; set; }
  /// <summary>
  /// Returns or sets the weight of the line, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.weight?view=word-pia"/>
  public float Weight { get; set; }
  /// <summary>
  /// Returns or sets whether the stroke is drawn inside the shape boundary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.insetpen?view=word-pia"/>
  public TriState InsetPen { get; set; }

}
