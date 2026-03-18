namespace DocumentModel.Interop;

/// <summary>
/// Represents line and arrowhead formatting. For a line, the LineFormat object contains formatting information for the line itself; for a shape with a border, this object contains formatting information for the shape's border.
/// </summary>
public interface LineFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  public ColorFormat BackColor { get; }
  /// <summary>
  /// The begin arrowhead length.
  /// </summary>
  public Core.MsoArrowheadLength BeginArrowheadLength { get; set; }
  /// <summary>
  /// The begin arrowhead style.
  /// </summary>
  public Core.MsoArrowheadStyle BeginArrowheadStyle { get; set; }
  /// <summary>
  /// The begin arrowhead width.
  /// </summary>
  public Core.MsoArrowheadWidth BeginArrowheadWidth { get; set; }
  /// <summary>
  /// The dash style.
  /// </summary>
  public Core.MsoLineDashStyle DashStyle { get; set; }
  /// <summary>
  /// The end arrowhead length.
  /// </summary>
  public Core.MsoArrowheadLength EndArrowheadLength { get; set; }
  /// <summary>
  /// The end arrowhead style.
  /// </summary>
  public Core.MsoArrowheadStyle EndArrowheadStyle { get; set; }
  /// <summary>
  /// The end arrowhead width.
  /// </summary>
  public Core.MsoArrowheadWidth EndArrowheadWidth { get; set; }
  /// <summary>
  /// The fore color.
  /// </summary>
  public ColorFormat ForeColor { get; }
  /// <summary>
  /// The pattern.
  /// </summary>
  public Core.MsoPatternType Pattern { get; set; }
  /// <summary>
  /// The style.
  /// </summary>
  public Core.MsoLineStyle Style { get; set; }
  /// <summary>
  /// The transparency.
  /// </summary>
  public float Transparency { get; set; }
  /// <summary>
  /// The visible.
  /// </summary>
  public Core.MsoTriState Visible { get; set; }
  /// <summary>
  /// The weight.
  /// </summary>
  public float Weight { get; set; }
  /// <summary>
  /// The inset pen.
  /// </summary>
  public Core.MsoTriState InsetPen { get; set; }

}
