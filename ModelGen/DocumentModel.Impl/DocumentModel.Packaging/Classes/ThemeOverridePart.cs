namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public class ThemeOverridePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, ThemeOverridePart
{
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ThemeOverride? ThemeOverride
  {
    get;
    set;
  }
  
}
