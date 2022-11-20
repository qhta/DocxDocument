namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HandoutMasterIdList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IHandoutMasterId))]
public interface IHandoutMasterIdList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Handout Master ID.
  /// </summary>
  public IHandoutMasterId? HandoutMasterId { get ; set; }
  
}
