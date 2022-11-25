namespace DocumentModel.Presentation;

/// <summary>
/// Animate Scale.
/// </summary>
public interface IAnimateScale // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// zoomContents
  /// </summary>
  public System.Boolean? ZoomContents { get ; set; }
  
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
  
}
