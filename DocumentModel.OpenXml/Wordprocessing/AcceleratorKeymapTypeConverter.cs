namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AcceleratorKeymapType Class.
/// </summary>
public static class AcceleratorKeymapTypeConverter
{
  /// <summary>
  /// acdName
  /// </summary>
  private static String? GetAcceleratorName(DXOW.AcceleratorKeymapType openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }
  
  private static bool CmpAcceleratorName(DXOW.AcceleratorKeymapType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AcceleratorName?.Value == value;
  }
  
  private static void SetAcceleratorName(DXOW.AcceleratorKeymapType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AcceleratorName = new StringValue { Value = value };
    else
      openXmlElement.AcceleratorName = null;
  }
  
  public static DMW.AcceleratorKeymapType? CreateModelElement(DXOW.AcceleratorKeymapType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AcceleratorKeymapType();
      value.AcceleratorName = GetAcceleratorName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.AcceleratorKeymapType? openXmlElement, DMW.AcceleratorKeymapType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAcceleratorName(openXmlElement, value.AcceleratorName, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AcceleratorKeymapType? value)
    where OpenXmlElementType: DXOW.AcceleratorKeymapType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAcceleratorName(openXmlElement, value?.AcceleratorName);
      return openXmlElement;
    }
    return default;
  }
}
