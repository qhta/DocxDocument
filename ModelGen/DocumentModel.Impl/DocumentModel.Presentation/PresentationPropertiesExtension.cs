namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PresentationPropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ITextMath))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IDefaultImageDpi))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IDiscardImageEditData))]
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IChartTrackingReferenceBased))]
public class PresentationPropertiesExtension: IPresentationPropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
