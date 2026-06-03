namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the Office Art formatting for chart elements.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat?view=word-pia"/>
public class ChartFormat : InteropObject
{
  /// <summary>
  /// Gets the fill formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.fill?view=word-pia"/>
  public FillFormat Fill { get; set; }
  /// <summary>
  /// Gets the glow formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.glow?view=word-pia"/>
  public GlowFormat Glow { get; set; }
  /// <summary>
  /// Gets the line formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.line?view=word-pia"/>
  public LineFormat Line { get; set; }
  /// <summary>
  /// Gets the picture formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; set; }
  /// <summary>
  /// Gets the shadow formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; set; }
  /// <summary>
  /// Gets the soft-edge formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; set; }
  /// <summary>
  /// Gets the `TextFrame2` object for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.textframe2?view=word-pia"/>
  public Core.ITextFrame2 TextFrame2 { get; set; }
  /// <summary>
  /// Gets the 3-D formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; set; }
  /// <summary>
  /// Gets the adjustments collection for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; set; }
  /// <summary>
  /// Gets or sets the AutoShape type for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.autoshapetype?view=word-pia"/>
  public Core.AutoShapeType AutoShapeType { get; set; }

}
