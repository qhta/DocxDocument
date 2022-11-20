namespace DocumentModel.Presentation;

/// <summary>
/// Animate Motion.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IByPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IFromPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IToPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRotationCenter))]
public class AnimateMotion: IAnimateMotion
{
  /// <summary>
  /// origin
  /// </summary>
  public AnimateMotionBehaviorOriginValues? Origin
  {
    get;
    set;
  }
  
  /// <summary>
  /// path
  /// </summary>
  public string? Path
  {
    get;
    set;
  }
  
  /// <summary>
  /// pathEditMode
  /// </summary>
  public AnimateMotionPathEditModeValues? PathEditMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// rAng
  /// </summary>
  public int? RelativeAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ptsTypes
  /// </summary>
  public string? PointTypes
  {
    get;
    set;
  }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BounceEnd
  {
    get;
    set;
  }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior
  {
    get;
    set;
  }
  
  /// <summary>
  /// ByPosition.
  /// </summary>
  public IByPosition? ByPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// FromPosition.
  /// </summary>
  public IFromPosition? FromPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// ToPosition.
  /// </summary>
  public IToPosition? ToPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// RotationCenter.
  /// </summary>
  public IRotationCenter? RotationCenter
  {
    get;
    set;
  }
  
}
