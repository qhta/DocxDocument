namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public interface IOpenXmlPackage // : DocumentModel.Packaging.IOpenXmlPartContainer
{
  public DocumentModel.Packaging.IOpenSettings? OpenSettings { get ; set; }
  
  public DocumentModel.ApplicationType? ApplicationType { get ; set; }
  
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public System.Boolean? StrictRelationshipFound { get ; set; }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public System.IO.Packaging.Package? Package { get ; set; }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public System.IO.FileAccess? FileOpenAccess { get ; set; }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public System.IO.Packaging.PackageProperties? PackageProperties { get ; set; }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public System.IO.Packaging.CompressionOption? CompressionOption { get ; set; }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public System.Collections.Generic.Dictionary<System.String,System.String>? PartExtensionProvider { get ; set; }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public DocumentModel.Packaging.IDataPart? DataParts { get ; set; }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public DocumentModel.Packaging.IMarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get ; set; }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public System.Boolean? AutoSave { get ; set; }
  
  /// <summary>
  /// Gets the relationship type of the main part.
  /// </summary>
  public System.String? MainPartRelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the content type of the main part of the package.
  /// </summary>
  public System.String? MainPartContentType { get ; set; }
  
  /// <summary>
  /// Gets the list of valid content types for the main part.
  /// </summary>
  public System.Collections.Generic.ICollection<System.String>? ValidMainPartContentTypes { get ; set; }
  
  public DocumentModel.Packaging.IOpenXmlPackage? InternalOpenXmlPackage { get ; set; }
  
}
