namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents markup compatibility processing settings.
/// </summary>
public static class MarkupCompatibilityProcessSettingsConverter
{
  /// <summary>
  /// Gets the markup compatibility process mode.
  /// </summary>
  public static DocumentModel.Packaging.MarkupCompatibilityProcessMode? GetProcessMode(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: 1");
  }
  
  public static void SetProcessMode(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement, DocumentModel.Packaging.MarkupCompatibilityProcessMode? value)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: 1");
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  public static DocumentModel.FileFormatVersions? GetTargetFileFormatVersions(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: 1");
  }
  
  public static void SetTargetFileFormatVersions(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement, DocumentModel.FileFormatVersions? value)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: 1");
  }
  
  public static DocumentModel.Packaging.MarkupCompatibilityProcessSettings? CreateModelElement(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.MarkupCompatibilityProcessSettings();
      value.ProcessMode = GetProcessMode(openXmlElement);
      value.TargetFileFormatVersions = GetTargetFileFormatVersions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.MarkupCompatibilityProcessSettings? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
