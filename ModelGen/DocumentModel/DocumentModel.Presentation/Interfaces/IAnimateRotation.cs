namespace DocumentModel.Presentation;

/// <summary>
/// Animate Rotation.
/// </summary>
public interface IAnimateRotation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// by
  /// </summary>
  public Int32? By { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public Int32? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public Int32? To { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
}
