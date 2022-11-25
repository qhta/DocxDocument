namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master ID.
/// </summary>
public interface INotesMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
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
