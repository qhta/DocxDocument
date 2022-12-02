namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public interface IThemePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public IImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.ITheme? Theme { get ; set; }
  
}
