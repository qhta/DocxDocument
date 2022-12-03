namespace DocumentModel.Presentation;

/// <summary>
/// Animate Motion.
/// </summary>
public interface AnimateMotion // : DocumentModel.BaseTypes.ModelElement
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
  public CommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// ByPosition.
  /// </summary>
  public TimeListType? ByPosition { get ; set; }
  
  /// <summary>
  /// FromPosition.
  /// </summary>
  public TimeListType? FromPosition { get ; set; }
  
  /// <summary>
  /// ToPosition.
  /// </summary>
  public TimeListType? ToPosition { get ; set; }
  
  /// <summary>
  /// RotationCenter.
  /// </summary>
  public TimeListType? RotationCenter { get ; set; }
  
}
