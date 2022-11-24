namespace DocumentModel.Presentation;

/// <summary>
/// Animate Motion.
/// </summary>
public interface IAnimateMotion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// origin
  /// </summary>
  public AnimateMotionBehaviorOriginValues? Origin { get ; set; }
  
  /// <summary>
  /// path
  /// </summary>
  public String? Path { get ; set; }
  
  /// <summary>
  /// pathEditMode
  /// </summary>
  public AnimateMotionPathEditModeValues? PathEditMode { get ; set; }
  
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
  public IByPosition? ByPosition { get ; set; }
  
  /// <summary>
  /// FromPosition.
  /// </summary>
  public IFromPosition? FromPosition { get ; set; }
  
  /// <summary>
  /// ToPosition.
  /// </summary>
  public IToPosition? ToPosition { get ; set; }
  
  /// <summary>
  /// RotationCenter.
  /// </summary>
  public IRotationCenter? RotationCenter { get ; set; }
  
}
