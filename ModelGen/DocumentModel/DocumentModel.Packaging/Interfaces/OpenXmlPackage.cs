namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public partial interface OpenXmlPackage
{
  /// <summary>
  /// Gets the root part for the package.
  /// </summary>
  public DocumentModel.Packaging.OpenXmlPart? RootPart { get; }
  
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public Boolean? StrictRelationshipFound { get; set; }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public Package? Package { get; }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public FileAccess? FileOpenAccess { get; }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public DocumentModel.Properties.CoreProperties? PackageProperties { get; }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption { get; set; }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public Dictionary<System.String, System.String>? PartExtensionProvider { get; }
  
  /// <summary>
  /// Gets a value that indicates the maximum allowable number of characters in an Open XML part. A zero (0) value indicates that there are no limits on the size
  /// </summary>
  public Int64? MaxCharactersInPart { get; }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public Collection<DocumentModel.Packaging.DataPart>? DataParts { get; }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public DocumentModel.Packaging.MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get; }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public Boolean? AutoSave { get; }
  
}
