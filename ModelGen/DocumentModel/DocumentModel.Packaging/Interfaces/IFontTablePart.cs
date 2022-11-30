namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public interface IFontTablePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public DocumentModel.Packaging.IFontPart? FontParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IFonts? Fonts { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
