namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PresentationExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ISectionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ISectionProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.INotesGuideList))]
public interface IPresentationExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
