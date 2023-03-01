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
      return EnumValueConverter.GetValue<DXPack.MarkupCompatibilityProcessMode, DMPack.MarkupCompatibilityProcessMode>(openXmlElement?.ProcessMode);
    return null;
  }
  
  private static bool CmpProcessMode(DXPack.MarkupCompatibilityProcessSettings openXmlElement, DMPack.MarkupCompatibilityProcessMode? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ProcessMode != null)
      return EnumValueConverter.CmpValue<DXPack.MarkupCompatibilityProcessMode, DMPack.MarkupCompatibilityProcessMode>(openXmlElement?.ProcessMode, value, diffs, objName);
    if (openXmlElement?.ProcessMode == null && value == null) return true;
    diffs?.Add(objName, "ProcessMode", openXmlElement?.ProcessMode, value);
    return false;
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  private static DM.FileFormatVersions? GetTargetFileFormatVersions(DXPack.MarkupCompatibilityProcessSettings openXmlElement)
  {
    if (openXmlElement?.TargetFileFormatVersions != null)
      return EnumValueConverter.GetValue<DX.FileFormatVersions, DM.FileFormatVersions>(openXmlElement?.TargetFileFormatVersions);
    return null;
  }
  
  private static bool CmpTargetFileFormatVersions(DXPack.MarkupCompatibilityProcessSettings openXmlElement, DM.FileFormatVersions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TargetFileFormatVersions != null)
      return EnumValueConverter.CmpValue<DX.FileFormatVersions, DM.FileFormatVersions>(openXmlElement?.TargetFileFormatVersions, value, diffs, objName);
    if (openXmlElement?.TargetFileFormatVersions == null && value == null) return true;
    diffs?.Add(objName, "TargetFileFormatVersions", openXmlElement?.TargetFileFormatVersions, value);
    return false;
  }
  
  public static DocumentModel.Packaging.MarkupCompatibilityProcessSettings? CreateModelElement(DXPack.MarkupCompatibilityProcessSettings? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.MarkupCompatibilityProcessSettings? openXmlElement, DMPack.MarkupCompatibilityProcessSettings? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProcessMode(openXmlElement, value.ProcessMode, diffs, objName))
        ok = false;
      if (!CmpTargetFileFormatVersions(openXmlElement, value.TargetFileFormatVersions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.MarkupCompatibilityProcessSettings value)
    where OpenXmlElementType: DXPack.MarkupCompatibilityProcessSettings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.MarkupCompatibilityProcessSettings openXmlElement, DMPack.MarkupCompatibilityProcessSettings value)
  {
    //SetProcessMode(openXmlElement, value?.ProcessMode);
    //SetTargetFileFormatVersions(openXmlElement, value?.TargetFileFormatVersions);
  }
}
