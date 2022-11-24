namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master ID.
/// </summary>
public interface ISlideMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Master Identifier
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public String? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
