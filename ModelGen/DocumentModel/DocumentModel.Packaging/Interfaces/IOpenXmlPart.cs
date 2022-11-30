namespace DocumentModel.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public interface IOpenXmlPart // : DocumentModel.Packaging.IOpenXmlPartContainer
{
  /// <summary>
  /// Gets the public part path in the package.
  /// </summary>
  public System.Uri? Uri { get ; set; }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets a value indicating whether the ContentType for the current part is fixed.
  /// </summary>
  public System.Boolean? IsContentTypeFixed { get ; set; }
  
  /// <summary>
  /// Gets the public path to be used for the part name.
  /// </summary>
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets the public path (Word specific TargetPath) to be used for the part name.
  /// </summary>
  public System.String? TargetPathOfWord { get ; set; }
  
  /// <summary>
  /// Gets the public path (Excel specific TargetPath) to be used for the part name.
  /// </summary>
  public System.String? TargetPathOfExcel { get ; set; }
  
  /// <summary>
  /// Gets the public path (PPT specific TargetPath) to be used for the part name.
  /// </summary>
  public System.String? TargetPathOfPPT { get ; set; }
  
  /// <summary>
  /// Gets the file base name to be used for the part name in the package.
  /// </summary>
  public System.String? TargetName { get ; set; }
  
  /// <summary>
  /// Gets the file extension to be used for the part in the package.
  /// </summary>
  public System.String? TargetFileExtension { get ; set; }
  
  /// <summary>
  /// Gets the root element of the current part.
  /// </summary>
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public DocumentModel.Packaging.IOpenXmlPackage? InternalOpenXmlPackage { get ; set; }
  
  public DocumentModel.Packaging.IMarkupCompatibilityProcessSettings? MCSettings { get ; set; }
  
}
