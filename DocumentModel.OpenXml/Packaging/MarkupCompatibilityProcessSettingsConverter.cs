using DocumentModel.Packaging;
using MarkupCompatibilityProcessSettings = DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Represents markup compatibility processing settings.
/// </summary>
public static class MarkupCompatibilityProcessSettingsConverter
{
  /// <summary>
  ///   Gets the markup compatibility process mode.
  /// </summary>
  public static MarkupCompatibilityProcessMode? GetProcessMode(MarkupCompatibilityProcessSettings? openXmlElement)
  {
    if (openXmlElement?.ProcessMode != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode, MarkupCompatibilityProcessMode>(openXmlElement.ProcessMode);
    return null;
  }

  /// <summary>
  ///   Gets the target file format versions.
  /// </summary>
  public static FileFormatVersions? GetTargetFileFormatVersions(MarkupCompatibilityProcessSettings? openXmlElement)
  {
    if (openXmlElement?.TargetFileFormatVersions != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.FileFormatVersions, FileFormatVersions>(openXmlElement.TargetFileFormatVersions);
    return null;
  }

  public static DocumentModel.Packaging.MarkupCompatibilityProcessSettings? CreateModelElement(MarkupCompatibilityProcessSettings? openXmlElement)
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
    where OpenXmlElementType : MarkupCompatibilityProcessSettings, new()
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