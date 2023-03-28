namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Text.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// space
  /// </summary>
  private static DM.SpaceProcessingMode? GetSpace(DXMath.Text openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  private static bool CmpSpace(DXMath.Text openXmlElement, DM.SpaceProcessingMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value, value, diffs, objName);
  }
  
  private static void SetSpace(DXMath.Text openXmlElement, DM.SpaceProcessingMode? value)
  {
    openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(value);
  }
  
  public static DMMath.Text? CreateModelElement(DXMath.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Text();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Text? openXmlElement, DMMath.Text? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Text value)
    where OpenXmlElementType: DXMath.Text, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Text openXmlElement, DMMath.Text value)
  {
    SetSpace(openXmlElement, value?.Space);
  }
}
