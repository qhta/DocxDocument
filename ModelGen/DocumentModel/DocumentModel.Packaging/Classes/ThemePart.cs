namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public class ThemePart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme
  {
    get;
    set;
  }
  
}
