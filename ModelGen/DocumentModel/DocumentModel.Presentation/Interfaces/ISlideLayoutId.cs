namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout Id.
/// </summary>
public interface ISlideLayoutId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ID Tag
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// ID Tag
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
