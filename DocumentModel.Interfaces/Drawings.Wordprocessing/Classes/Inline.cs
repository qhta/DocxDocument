namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Inline DrawingML Object.
/// </summary>
public class Inline: ModelElement
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public EMU? DistanceFromTop { get; set; }
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public EMU? DistanceFromBottom { get; set; }
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public EMU? DistanceFromLeft { get; set; }
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public EMU? DistanceFromRight { get; set; }
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexInt? AnchorId { get; set; }
  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexInt? EditId { get; set; }
  /// <summary>
  ///   Drawing Object Size.
  /// </summary>
  public Extent? Extent { get; set; }
  /// <summary>
  ///   Inline Wrapping Extent.
  /// </summary>
  public EffectExtent? EffectExtent { get; set; }
  /// <summary>
  ///   Drawing Object Non-Visual Properties.
  /// </summary>
  public DocProperties? DocProperties { get; set; }
  /// <summary>
  ///   Common DrawingML Non-Visual Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }
  /// <summary>
  ///   Graphic.
  /// </summary>
  public Graphic? Graphic { get; set; }
}