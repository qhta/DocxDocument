namespace DocumentModel.Presentation;

/// <summary>
/// Slide View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface ISlideViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommonSlideViewProperties.
  /// </summary>
  public ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
