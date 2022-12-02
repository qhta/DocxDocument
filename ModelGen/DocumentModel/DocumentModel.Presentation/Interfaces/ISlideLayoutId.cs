namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout Id.
/// </summary>
public interface ISlideLayoutId // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ID Tag
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// ID Tag
  /// </summary>
  public String? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
