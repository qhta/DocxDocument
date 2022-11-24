namespace DocumentModel.Presentation;

/// <summary>
/// Animate Scale.
/// </summary>
public interface IAnimateScale // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
}
