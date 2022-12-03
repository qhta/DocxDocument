namespace DocumentModel.Presentation;

/// <summary>
/// Slide Timing Information for a Slide.
/// </summary>
public interface Timing // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// TimeNodeList.
  /// </summary>
  public TimeNodeList? TimeNodeList { get ; set; }
  
  /// <summary>
  /// Build List.
  /// </summary>
  public BuildList? BuildList { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
