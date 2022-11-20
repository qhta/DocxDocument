namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IEffectExtent))]
public interface IWrapTopBottom // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public uint? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public uint? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  public IEffectExtent? EffectExtent { get ; set; }
  
}
