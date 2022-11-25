namespace DocumentModel.Presentation;

/// <summary>
/// Animate Rotation.
/// </summary>
public interface IAnimateRotation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// by
  /// </summary>
  public System.Int32? By { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public System.Int32? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public System.Int32? To { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
}
