namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public static class TextTypeConverter
{
  /// <summary>
  /// space
  /// </summary>
  private static DM.SpaceProcessingMode? GetSpace(DXW.TextType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  private static bool CmpSpace(DXW.TextType openXmlElement, DM.SpaceProcessingMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpace(DXW.TextType openXmlElement, DM.SpaceProcessingMode? value)
  {
    openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(value);
  }
  
  public static DocumentModel.Wordprocessing.TextType? CreateModelElement(DXW.TextType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextType();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TextType? openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TextType value)
    where OpenXmlElementType: DXW.TextType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TextType openXmlElement, DMW.TextType value)
  {
    SetSpace(openXmlElement, value?.Space);
  }
}
