namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
public interface ISlideMasterExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
