namespace DocumentModel.Presentation;

/// <summary>
/// Slide ID.
/// </summary>
public interface ISlideId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Identifier
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
