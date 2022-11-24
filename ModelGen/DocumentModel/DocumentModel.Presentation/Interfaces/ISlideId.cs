namespace DocumentModel.Presentation;

/// <summary>
/// Slide ID.
/// </summary>
public interface ISlideId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Identifier
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
