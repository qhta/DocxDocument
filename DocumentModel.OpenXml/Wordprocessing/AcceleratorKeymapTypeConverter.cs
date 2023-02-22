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
    return StringValueConverter.GetValue(openXmlElement?.AcceleratorName);
  }
  
  private static bool CmpAcceleratorName(DXOW.AcceleratorKeymapType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AcceleratorName, value, diffs, objName, "AcceleratorName");
  }
  
  private static void SetAcceleratorName(DXOW.AcceleratorKeymapType openXmlElement, String? value)
  {
    openXmlElement.AcceleratorName = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.AcceleratorKeymapType? CreateModelElement(DXOW.AcceleratorKeymapType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AcceleratorKeymapType();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AcceleratorKeymapType value)
    where OpenXmlElementType: DXOW.AcceleratorKeymapType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.AcceleratorKeymapType openXmlElement, DMW.AcceleratorKeymapType value)
  {
    SetAcceleratorName(openXmlElement, value?.AcceleratorName);
    }
  }
