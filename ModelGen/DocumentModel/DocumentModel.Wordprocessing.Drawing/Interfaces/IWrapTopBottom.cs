namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public interface IWrapTopBottom // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public System.UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public System.UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.IEffectExtent? EffectExtent { get ; set; }
  
}
