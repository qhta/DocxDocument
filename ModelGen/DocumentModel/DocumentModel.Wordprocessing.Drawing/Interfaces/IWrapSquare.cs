namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Square Wrapping.
/// </summary>
public interface IWrapSquare // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public IEffectExtent? EffectExtent { get ; set; }
  
}
