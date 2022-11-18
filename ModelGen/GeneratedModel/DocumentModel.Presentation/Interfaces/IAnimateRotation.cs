namespace DocumentModel.Presentation;

/// <summary>
/// Animate Rotation.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public interface IAnimateRotation // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// by
  /// </summary>
  public int? By { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public int? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public int? To { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
}
