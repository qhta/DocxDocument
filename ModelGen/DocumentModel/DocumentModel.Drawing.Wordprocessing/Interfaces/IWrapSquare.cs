namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Square Wrapping.
/// </summary>
public interface IWrapSquare // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public System.UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public System.UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public System.UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public System.UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IEffectExtent? EffectExtent { get ; set; }
  
}
