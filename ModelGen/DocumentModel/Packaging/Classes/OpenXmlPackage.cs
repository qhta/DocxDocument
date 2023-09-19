namespace DocumentModel.Packaging;


/// <summary>
///   Represents a base class for strong typed Open XML document classes.
/// </summary>
public partial class OpenXmlPackage
{
  
  /// <summary>
  ///   Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public Boolean? StrictRelationshipFound { get; set; }
  
  
  /// <summary>
  ///   Gets the package of the document.
  /// </summary>
  [Obsolete("This property will be removed in a future version as an implementation detail", (Boolean)True)]
  public Package? Package { get; set; }
  
  
  /// <summary>
  ///   Gets the FileAccess setting for the document.
  ///               The current I/O access settings are: Read, Write, or ReadWrite.
  /// </summary>
  public FileAccess? FileOpenAccess { get; set; }
  
  
  /// <summary>
  ///   Gets the core package properties of the Open XML document.
  /// </summary>
  public PackageProperties? PackageProperties { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the compression level for the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption { get; set; }
  
  
  /// <summary>
  ///   Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public Dictionary? PartExtensionProvider { get; set; }
  
  public Collection? DataParts { get; set; }
  
  
  /// <summary>
  ///   Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public DocumentModel.Packaging.MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get; set; }
  
  
  /// <summary>
  ///   Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public Boolean? AutoSave { get; set; }
  
}
