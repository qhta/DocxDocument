namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public interface IWebSettingsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IWebSettings? WebSettings { get ; set; }
  
}
