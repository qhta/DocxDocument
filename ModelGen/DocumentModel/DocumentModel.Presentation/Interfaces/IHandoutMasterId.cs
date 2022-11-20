namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master ID.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface IHandoutMasterId // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
