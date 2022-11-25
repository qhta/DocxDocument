namespace DocumentModel.Presentation;

/// <summary>
/// Animate Motion.
/// </summary>
public interface IAnimateMotion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// origin
  /// </summary>
  public DocumentModel.Presentation.AnimateMotionBehaviorOriginKind? Origin { get ; set; }
  
  /// <summary>
  /// path
  /// </summary>
  public System.String? Path { get ; set; }
  
  /// <summary>
  /// pathEditMode
  /// </summary>
  public DocumentModel.Presentation.AnimateMotionPathEditMode? PathEditMode { get ; set; }
  
  /// <summary>
  /// rAng
  /// </summary>
  public System.Int32? RelativeAngle { get ; set; }
  
  /// <summary>
  /// ptsTypes
  /// </summary>
  public System.String? PointTypes { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// ByPosition.
  /// </summary>
  public DocumentModel.Presentation.ITimeListType? ByPosition { get ; set; }
  
  /// <summary>
  /// FromPosition.
  /// </summary>
  public DocumentModel.Presentation.ITimeListType? FromPosition { get ; set; }
  
  /// <summary>
  /// ToPosition.
  /// </summary>
  public DocumentModel.Presentation.ITimeListType? ToPosition { get ; set; }
  
  /// <summary>
  /// RotationCenter.
  /// </summary>
  public DocumentModel.Presentation.ITimeListType? RotationCenter { get ; set; }
  
}
