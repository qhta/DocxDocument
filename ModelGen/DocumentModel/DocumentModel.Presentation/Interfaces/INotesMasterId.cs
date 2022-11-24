namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master ID.
/// </summary>
public interface INotesMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
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
