namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the Office Art formatting for chart elements.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat?view=word-pia"/>
public interface ChartFormat : InteropObject
{
  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.fill?view=word-pia"/>
  public FillFormat Fill { get; }
  /// <summary>
  /// The glow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.glow?view=word-pia"/>
  public GlowFormat Glow { get; }
  /// <summary>
  /// The line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.line?view=word-pia"/>
  public LineFormat Line { get; }
  /// <summary>
  /// The picture format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; }
  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// The soft edge.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }
  /// <summary>
  /// The text frame2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.textframe2?view=word-pia"/>
  public Core.TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// The three d.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// The adjustments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.adjustments?view=word-pia"/>
  public Adjustments Adjustments { get; }
  /// <summary>
  /// The auto shape type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartformat.autoshapetype?view=word-pia"/>
  public Core.MsoAutoShapeType AutoShapeType { get; set; }

}
