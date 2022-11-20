namespace DocumentModel.Presentation;

/// <summary>
/// Animate Scale.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IByPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IFromPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IToPosition))]
public interface IAnimateScale // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// zoomContents
  /// </summary>
  public bool? ZoomContents { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BounceEnd { get ; set; }
  
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
