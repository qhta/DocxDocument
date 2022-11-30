namespace DocumentModel.Presentation;

/// <summary>
/// Slide Timing Information for a Slide.
/// </summary>
public interface ITiming // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TimeNodeList.
  /// </summary>
  public DocumentModel.Presentation.ITimeNodeList? TimeNodeList { get ; set; }
  
  /// <summary>
  /// Build List.
  /// </summary>
  public DocumentModel.Presentation.IBuildList? BuildList { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
