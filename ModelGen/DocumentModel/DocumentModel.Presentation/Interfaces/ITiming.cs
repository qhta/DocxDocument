namespace DocumentModel.Presentation;

/// <summary>
/// Slide Timing Information for a Slide.
/// </summary>
public interface ITiming // : DocumentModel.ITypedOpenXmlCompositeElement
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
