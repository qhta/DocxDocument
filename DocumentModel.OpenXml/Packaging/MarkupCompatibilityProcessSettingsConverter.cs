namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents markup compatibility processing settings.
/// </summary>
public static class MarkupCompatibilityProcessSettingsConverter
{
  /// <summary>
  /// Gets the markup compatibility process mode.
  /// </summary>
  private static DMPack.MarkupCompatibilityProcessMode? GetProcessMode(DXPack.MarkupCompatibilityProcessSettings openXmlElement)
  {
    if (openXmlElement?.ProcessMode != null)
      return EnumValueConverter.GetValue<DXPack.MarkupCompatibilityProcessMode, DMPack.MarkupCompatibilityProcessMode>(openXmlElement.ProcessMode);
    return null;
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  private static DM.FileFormatVersions? GetTargetFileFormatVersions(DXPack.MarkupCompatibilityProcessSettings openXmlElement)
  {
    if (openXmlElement?.TargetFileFormatVersions != null)
      return EnumValueConverter.GetValue<DX.FileFormatVersions, DM.FileFormatVersions>(openXmlElement.TargetFileFormatVersions);
    return null;
  }
  
  public static DMPack.MarkupCompatibilityProcessSettings? CreateModelElement(DXPack.MarkupCompatibilityProcessSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.MarkupCompatibilityProcessSettings();
      value.ProcessMode = GetProcessMode(openXmlElement);
      value.TargetFileFormatVersions = GetTargetFileFormatVersions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.MarkupCompatibilityProcessSettings? value)
    where OpenXmlElementType: DXPack.MarkupCompatibilityProcessSettings, new()
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
