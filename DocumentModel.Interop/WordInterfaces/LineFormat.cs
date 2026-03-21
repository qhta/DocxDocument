namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents line and arrowhead formatting. For a line, the LineFormat object contains formatting information for the line itself; for a shape with a border, this object contains formatting information for the shape's border.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat?view=word-pia"/>
public interface LineFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.backcolor?view=word-pia"/>
  public ColorFormat BackColor { get; }
  /// <summary>
  /// The begin arrowhead length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadlength?view=word-pia"/>
  public Core.MsoArrowheadLength BeginArrowheadLength { get; set; }
  /// <summary>
  /// The begin arrowhead style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadstyle?view=word-pia"/>
  public Core.MsoArrowheadStyle BeginArrowheadStyle { get; set; }
  /// <summary>
  /// The begin arrowhead width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.beginarrowheadwidth?view=word-pia"/>
  public Core.MsoArrowheadWidth BeginArrowheadWidth { get; set; }
  /// <summary>
  /// The dash style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.dashstyle?view=word-pia"/>
  public Core.MsoLineDashStyle DashStyle { get; set; }
  /// <summary>
  /// The end arrowhead length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadlength?view=word-pia"/>
  public Core.MsoArrowheadLength EndArrowheadLength { get; set; }
  /// <summary>
  /// The end arrowhead style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadstyle?view=word-pia"/>
  public Core.MsoArrowheadStyle EndArrowheadStyle { get; set; }
  /// <summary>
  /// The end arrowhead width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.endarrowheadwidth?view=word-pia"/>
  public Core.MsoArrowheadWidth EndArrowheadWidth { get; set; }
  /// <summary>
  /// The fore color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }
  /// <summary>
  /// The pattern.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.pattern?view=word-pia"/>
  public Core.MsoPatternType Pattern { get; set; }
  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.style?view=word-pia"/>
  public Core.MsoLineStyle Style { get; set; }
  /// <summary>
  /// The transparency.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }
  /// <summary>
  /// The weight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.weight?view=word-pia"/>
  public float Weight { get; set; }
  /// <summary>
  /// The inset pen.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lineformat.insetpen?view=word-pia"/>
  public Core.MsoTriState InsetPen { get; set; }

}
