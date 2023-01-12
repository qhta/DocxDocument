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
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is System.Boolean");
  }
  
  public static void SetStrictRelationshipFound(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is System.Boolean");
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public static System.IO.Packaging.Package? GetPackage(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public static System.IO.FileAccess? GetFileOpenAccess(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: 1");
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public static DocumentModel.Properties.CoreProperties? GetPackageProperties(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public static System.IO.Packaging.CompressionOption? GetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: 1");
  }
  
  public static void SetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement, System.IO.Packaging.CompressionOption? value)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: 1");
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public static System.Collections.Generic.Dictionary<String, String>? GetPartExtensionProvider(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DataPart>? GetDataParts(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.DataPart>();
      foreach (var item in openXmlElement.DataParts)
      {
        var newItem = DocumentModel.OpenXml.Packaging.DataPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public static DocumentModel.Packaging.MarkupCompatibilityProcessSettings? GetMarkupCompatibilityProcessSettings(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public static Boolean? GetAutoSave(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is System.Boolean");
  }
  
  public static DocumentModel.Packaging.OpenXmlPackage? CreateModelElement(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.OpenXmlPackage();
      value.StrictRelationshipFound = GetStrictRelationshipFound(openXmlElement);
      value.Package = GetPackage(openXmlElement);
      value.FileOpenAccess = GetFileOpenAccess(openXmlElement);
      value.PackageProperties = GetPackageProperties(openXmlElement);
      value.CompressionOption = GetCompressionOption(openXmlElement);
      value.PartExtensionProvider = GetPartExtensionProvider(openXmlElement);
      value.DataParts = GetDataParts(openXmlElement);
      value.MarkupCompatibilityProcessSettings = GetMarkupCompatibilityProcessSettings(openXmlElement);
      value.AutoSave = GetAutoSave(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.OpenXmlPackage? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.OpenXmlPackage, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStrictRelationshipFound(openXmlElement, value?.StrictRelationshipFound);
      SetCompressionOption(openXmlElement, value?.CompressionOption);
      return openXmlElement;
    }
    return default;
  }
}
