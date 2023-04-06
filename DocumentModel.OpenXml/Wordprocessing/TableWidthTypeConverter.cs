namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  private static Int64? GetWidth(DXW.TableWidthType openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.TableWidthType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value.ToString(), diffs, objName, "Value");
  }
  
  private static void SetWidth(DXW.TableWidthType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value!=null ? StringValueConverter.CreateStringValue(value.ToString()) : null;
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  private static DMW.TableWidthUnitType? GetType(DXW.TableWidthType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(value);
  }
  
  public static DMW.TableWidth? CreateModelElement(DXW.TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var width = GetWidth(openXmlElement);
      if (width == 5000)
        Debug.Assert(true);
      var type = GetType(openXmlElement);
      var value = new DMW.TableWidth(width, type);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableWidthType? openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Value, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidth value)
    where OpenXmlElementType: DXW.TableWidthType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthType openXmlElement, DMW.TableWidth value)
  {
    SetWidth(openXmlElement, value?.Value);
    SetType(openXmlElement, value?.Type);
  }
}
