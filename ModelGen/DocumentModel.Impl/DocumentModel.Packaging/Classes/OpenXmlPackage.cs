namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public class OpenXmlPackageImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, OpenXmlPackage
{
  public new DocumentFormat.OpenXml.Packaging.OpenXmlPackage? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPackage?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlPackageImpl(): base() {}
  
  public OpenXmlPackageImpl(DocumentFormat.OpenXml.Packaging.OpenXmlPackage openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public Boolean? StrictRelationshipFound
  {
    get => (Boolean?)OpenXmlElement?.StrictRelationshipFound;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("StrictRelationshipFound").SetValue(OpenXmlElement, (System.Boolean?)value);
    }
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public Package? Package
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public FileAccess? FileOpenAccess
  {
    get => (FileAccess?)OpenXmlElement?.FileOpenAccess;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("FileOpenAccess").SetValue(OpenXmlElement, (System.IO.FileAccess?)value);
    }
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public PackageProperties? PackageProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption
  {
    get => (CompressionOption?)OpenXmlElement?.CompressionOption;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("CompressionOption").SetValue(OpenXmlElement, (System.IO.Packaging.CompressionOption?)value);
    }
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public Dictionary<String, String>? PartExtensionProvider
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public DataPart? DataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public Boolean? AutoSave
  {
    get => (Boolean?)OpenXmlElement?.AutoSave;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("AutoSave").SetValue(OpenXmlElement, (System.Boolean?)value);
    }
  }
  
}
