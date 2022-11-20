namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Author Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.IExtensionList))]
public interface IAuthor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// initials, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Initials { get ; set; }
  
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserId { get ; set; }
  
  /// <summary>
  /// providerId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? ProviderId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.IExtensionList? ExtensionList { get ; set; }
  
}
