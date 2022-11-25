namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HandoutMasterIdList Class.
/// </summary>
public interface IHandoutMasterIdList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Handout Master ID.
  /// </summary>
  public DocumentModel.Presentation.IHandoutMasterId? HandoutMasterId { get ; set; }
  
}
