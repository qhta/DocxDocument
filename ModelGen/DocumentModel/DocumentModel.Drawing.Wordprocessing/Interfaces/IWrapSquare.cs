namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Square Wrapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IEffectExtent))]
public interface IWrapSquare // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextValues? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public uint? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public uint? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public uint? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public uint? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public IEffectExtent? EffectExtent { get ; set; }
  
}
