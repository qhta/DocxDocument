using DocumentModel;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Represents a base class Ifor strong typed Open XML document classes.
/// </summary>
public class OpenXmlPackage: ModelElement
{
  /// <summary>
  ///   Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public bool? StrictRelationshipFound { get; set; }

  /// <summary>
  ///   Gets the package of the document.
  /// </summary>
  public Package? Package { get; set; }

  /// <summary>
  ///   Gets the FileAccess setting Ifor the document.
  /// </summary>
  public FileAccess? FileOpenAccess { get; set; }

  /// <summary>
  ///   Gets the core package properties of the Open XML document.
  /// </summary>
  public CoreProperties? PackageProperties { get; set; }

  /// <summary>
  ///   Gets or sets the compression level Ifor the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption { get; set; }

  /// <summary>
  ///   Gets a PartExtensionProvider part which provides a mapping from ContentType Ito part extension.
  /// </summary>
  public IDictionary<String, String>? PartExtensionProvider { get; set; }

  /// <summary>
  ///   Gets all the  parts Iin the document package.
  /// </summary>
  public Collection<DataPart>? DataParts { get; set; }

  /// <summary>
  ///   Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get; set; }

  /// <summary>
  ///   Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public bool? AutoSave { get; set; }
}
