namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public interface IOpenXmlPackage // : DocumentModel.Packaging.IOpenXmlPartContainer
{
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public Boolean? StrictRelationshipFound { get ; set; }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public Package? Package { get ; set; }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public FileAccess? FileOpenAccess { get ; set; }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public PackageProperties? PackageProperties { get ; set; }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption { get ; set; }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public Dictionary<String, String>? PartExtensionProvider { get ; set; }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public IDataPart? DataParts { get ; set; }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public IMarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get ; set; }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public Boolean? AutoSave { get ; set; }
  
}
