namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout Id.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface ISlideLayoutId // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ID Tag
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// ID Tag
  /// </summary>
  public string? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
