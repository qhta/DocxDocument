namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public static class OpenXmlPackageConverter
{
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  private static Boolean? GetStrictRelationshipFound(DXPack.OpenXmlPackage openXmlElement)
  {
    return openXmlElement?.StrictRelationshipFound;
  }
  
  private static bool CmpStrictRelationshipFound(DXPack.OpenXmlPackage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StrictRelationshipFound == value) return true;
    diffs?.Add(objName, "StrictRelationshipFound", openXmlElement?.StrictRelationshipFound, value);
    return false;
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  private static Package? GetPackage(DXPack.OpenXmlPackage openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: propertyType is System.IO.Packaging.Package");
  }
  
  private static bool CmpPackage(DXPack.OpenXmlPackage openXmlElement, Package? value, DiffList? diffs, string? objName)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyComparer: propertyType is System.IO.Packaging.Package");
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  private static FileAccess? GetFileOpenAccess(DXPack.OpenXmlPackage openXmlElement)
  {
    if (openXmlElement?.FileOpenAccess != null)
      return EnumValueConverter.GetValue<FileAccess, FileAccess>(openXmlElement?.FileOpenAccess);
    return null;
  }
  
  private static bool CmpFileOpenAccess(DXPack.OpenXmlPackage openXmlElement, FileAccess? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FileOpenAccess != null)
      return EnumValueConverter.CmpValue<FileAccess, FileAccess>(openXmlElement?.FileOpenAccess, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
    if (openXmlElement?.FileOpenAccess == null && value == null) return true;
    diffs?.Add(objName, "FileOpenAccess", openXmlElement?.FileOpenAccess, value);
    return false;
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  private static DMProps.CoreProperties? GetPackageProperties(DXPack.OpenXmlPackage openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: propertyType is System.IO.Packaging.PackageProperties");
  }
  
  private static bool CmpPackageProperties(DXPack.OpenXmlPackage openXmlElement, DMProps.CoreProperties? value, DiffList? diffs, string? objName)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyComparer: propertyType is System.IO.Packaging.PackageProperties");
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  private static CompressionOption? GetCompressionOption(DXPack.OpenXmlPackage openXmlElement)
  {
    if (openXmlElement?.CompressionOption != null)
      return EnumValueConverter.GetValue<CompressionOption, CompressionOption>(openXmlElement?.CompressionOption);
    return null;
  }
  
  private static bool CmpCompressionOption(DXPack.OpenXmlPackage openXmlElement, CompressionOption? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CompressionOption != null)
      return EnumValueConverter.CmpValue<CompressionOption, CompressionOption>(openXmlElement?.CompressionOption, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
    if (openXmlElement?.CompressionOption == null && value == null) return true;
    diffs?.Add(objName, "CompressionOption", openXmlElement?.CompressionOption, value);
    return false;
  }
  
  private static void SetCompressionOption(DXPack.OpenXmlPackage openXmlElement, CompressionOption? value)
  {
    if (value != null)
      openXmlElement.CompressionOption = EnumValueConverter.GetValue<CompressionOption, CompressionOption>(value);
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  private static Dictionary<String, String>? GetPartExtensionProvider(DXPack.OpenXmlPackage openXmlElement)
  {
  }
  
  private static bool CmpPartExtensionProvider(DXPack.OpenXmlPackage openXmlElement, Dictionary<String, String>? value, DiffList? diffs, string? objName)
  {
  }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  private static Collection<DMPack.DataPart>? GetDataParts(DXPack.OpenXmlPackage openXmlElement)
  {
    var collection = new Collection<DMPack.DataPart>();
    foreach (var item in openXmlElement.DataParts)
    {
      var newItem = DMXPack.DataPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDataParts(DXPack.OpenXmlPackage openXmlElement, Collection<DMPack.DataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  private static DMPack.MarkupCompatibilityProcessSettings? GetMarkupCompatibilityProcessSettings(DXPack.OpenXmlPackage openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: propertyType is DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings");
  }
  
  private static bool CmpMarkupCompatibilityProcessSettings(DXPack.OpenXmlPackage openXmlElement, DMPack.MarkupCompatibilityProcessSettings? value, DiffList? diffs, string? objName)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyComparer: propertyType is DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings");
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  private static Boolean? GetAutoSave(DXPack.OpenXmlPackage openXmlElement)
  {
    return openXmlElement?.AutoSave;
  }
  
  private static bool CmpAutoSave(DXPack.OpenXmlPackage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AutoSave == value) return true;
    diffs?.Add(objName, "AutoSave", openXmlElement?.AutoSave, value);
    return false;
  }
  
}
