namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the Office Art formatting for chart elements.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat?view=word-pia"/>
public interface ChartFormat : InteropObject
{
  /// <summary>
  /// Gets the fill formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.fill?view=word-pia"/>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the glow formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.glow?view=word-pia"/>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the line formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.line?view=word-pia"/>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets the picture formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// Gets the shadow formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the soft-edge formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// Gets the `TextFrame2` object for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the 3-D formatting for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the adjustments collection for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// Gets or sets the AutoShape type for the chart element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

}
