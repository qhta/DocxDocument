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
    if (openXmlElement?.ProcessMode != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode, DocumentModel.Packaging.MarkupCompatibilityProcessMode>(openXmlElement.ProcessMode);
    return null;
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  public static DocumentModel.FileFormatVersions? GetTargetFileFormatVersions(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? openXmlElement)
  {
    if (openXmlElement?.TargetFileFormatVersions != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.FileFormatVersions, DocumentModel.FileFormatVersions>(openXmlElement.TargetFileFormatVersions);
    return null;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetProcessMode(openXmlElement, value?.ProcessMode);
      //SetTargetFileFormatVersions(openXmlElement, value?.TargetFileFormatVersions);
      return openXmlElement;
    }
    return default;
  }
}
