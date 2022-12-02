namespace DocumentModel.Presentation;

/// <summary>
/// Animate Motion.
/// </summary>
public interface IAnimateMotion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// origin
  /// </summary>
  public AnimateMotionBehaviorOriginKind? Origin { get ; set; }
  
  /// <summary>
  /// path
  /// </summary>
  public String? Path { get ; set; }
  
  /// <summary>
  /// pathEditMode
  /// </summary>
  public AnimateMotionPathEditMode? PathEditMode { get ; set; }
  
  /// <summary>
  /// rAng
  /// </summary>
  public Int32? RelativeAngle { get ; set; }
  
  /// <summary>
  /// ptsTypes
  /// </summary>
  public String? PointTypes { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// ByPosition.
  /// </summary>
  public ITimeListType? ByPosition { get ; set; }
  
  /// <summary>
  /// FromPosition.
  /// </summary>
  public ITimeListType? FromPosition { get ; set; }
  
  /// <summary>
  /// ToPosition.
  /// </summary>
  public ITimeListType? ToPosition { get ; set; }
  
  /// <summary>
  /// RotationCenter.
  /// </summary>
  public ITimeListType? RotationCenter { get ; set; }
  
}
