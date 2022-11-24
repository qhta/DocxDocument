namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master ID.
/// </summary>
public interface IHandoutMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
