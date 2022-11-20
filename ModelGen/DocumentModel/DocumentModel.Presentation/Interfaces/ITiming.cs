namespace DocumentModel.Presentation;

/// <summary>
/// Slide Timing Information for a Slide.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeNodeList))]
public interface ITiming // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// TimeNodeList.
  /// </summary>
  public ITimeNodeList? TimeNodeList { get ; set; }
  
  /// <summary>
  /// Build List.
  /// </summary>
  public IBuildList? BuildList { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
