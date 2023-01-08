namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public static class OpenXmlPackageConverter
{
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public static Boolean? GetStrictRelationshipFound(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStrictRelationshipFound(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public static System.IO.Packaging.Package? GetPackage(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public static System.IO.FileAccess? GetFileOpenAccess(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GenerateEnumPropertyGetCode");
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public static DocumentModel.Properties.CoreProperties? GetPackageProperties(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public static System.IO.Packaging.CompressionOption? GetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GenerateEnumPropertyGetCode");
  }
  
  public static void SetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement, System.IO.Packaging.CompressionOption? value)
  {
    throw new NotImplementedException("Not implemented 1 in GenerateEnumPropertySetCode");
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public static System.Collections.Generic.Dictionary<String, String>? GetPartExtensionProvider(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DataPart>? GetDataParts(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public static DocumentModel.Packaging.MarkupCompatibilityProcessSettings? GetMarkupCompatibilityProcessSettings(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public static Boolean? GetAutoSave(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
}
