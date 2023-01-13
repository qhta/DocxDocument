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
    return openXmlElement?.StrictRelationshipFound;
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public static System.IO.Packaging.Package? GetPackage(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    return openXmlElement?.Package;
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public static System.IO.FileAccess? GetFileOpenAccess(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    if (openXmlElement?.FileOpenAccess != null)
      return EnumValueConverter.GetValue<System.IO.FileAccess, System.IO.FileAccess>(openXmlElement.FileOpenAccess);
    return null;
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public static DocumentModel.Properties.CoreProperties? GetPackageProperties(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    return DocumentModel.OpenXml.Properties.CorePropertiesConverter.CreateModelElement(openXmlElement?.PackageProperties);
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public static System.IO.Packaging.CompressionOption? GetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    if (openXmlElement?.CompressionOption != null)
      return EnumValueConverter.GetValue<System.IO.Packaging.CompressionOption, System.IO.Packaging.CompressionOption>(openXmlElement.CompressionOption);
    return null;
  }
  
  public static void SetCompressionOption(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement, System.IO.Packaging.CompressionOption? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CompressionOption = 
          (System.IO.Packaging.CompressionOption)EnumValueConverter.GetValue<System.IO.Packaging.CompressionOption, System.IO.Packaging.CompressionOption>(value);
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public static System.Collections.Generic.Dictionary<String, String>? GetPartExtensionProvider(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    return openXmlElement.PartExtensionProvider;
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
    return DocumentModel.OpenXml.Packaging.MarkupCompatibilityProcessSettingsConverter.CreateModelElement(openXmlElement?.MarkupCompatibilityProcessSettings);
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public static Boolean? GetAutoSave(DocumentFormat.OpenXml.Packaging.OpenXmlPackage? openXmlElement)
  {
    return openXmlElement?.AutoSave;
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
      //SetStrictRelationshipFound(openXmlElement, value?.StrictRelationshipFound);
      //SetPackage(openXmlElement, value?.Package);
      //SetFileOpenAccess(openXmlElement, value?.FileOpenAccess);
      //SetPackageProperties(openXmlElement, value?.PackageProperties);
      SetCompressionOption(openXmlElement, value?.CompressionOption);
      //SetPartExtensionProvider(openXmlElement, value?.PartExtensionProvider);
      //SetDataParts(openXmlElement, value?.DataParts);
      //SetMarkupCompatibilityProcessSettings(openXmlElement, value?.MarkupCompatibilityProcessSettings);
      //SetAutoSave(openXmlElement, value?.AutoSave);
      return openXmlElement;
    }
    return default;
  }
}
