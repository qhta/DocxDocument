namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master ID.
/// </summary>
public interface IHandoutMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
