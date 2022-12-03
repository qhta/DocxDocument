namespace DocumentModel.Presentation;

/// <summary>
/// Animate Scale.
/// </summary>
public interface AnimateScale // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// zoomContents
  /// </summary>
  public Boolean? ZoomContents { get ; set; }
  
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
  
}
