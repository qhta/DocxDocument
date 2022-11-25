namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master ID.
/// </summary>
public interface ISlideMasterId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Master Identifier
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
