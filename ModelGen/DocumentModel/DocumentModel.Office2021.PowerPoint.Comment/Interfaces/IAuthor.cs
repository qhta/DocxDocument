namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Author Class.
/// </summary>
public interface IAuthor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// initials, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Initials { get ; set; }
  
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserId { get ; set; }
  
  /// <summary>
  /// providerId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? ProviderId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
