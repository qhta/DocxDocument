namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Inline DrawingML Object.
/// </summary>
public partial class Inline
{
  
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? AnchorId { get; set; }
  
  
  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? EditId { get; set; }
  
  
  /// <summary>
  ///   Drawing Object Size.
  /// </summary>
  public DMDW.Extent? Extent { get; set; }
  
  
  /// <summary>
  ///   Inline Wrapping Extent.
  /// </summary>
  public DMDW.EffectExtent? EffectExtent { get; set; }
  
  
  /// <summary>
  ///   Drawing Object Non-Visual Properties.
  /// </summary>
  public DMDW.DocProperties? DocProperties { get; set; }
  
  
  /// <summary>
  ///   Common DrawingML Non-Visual Properties.
  /// </summary>
  public DMDW.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }
  
  
  /// <summary>
  ///   Graphic.
  /// </summary>
  public DMD.Graphic? Graphic { get; set; }
  
}
