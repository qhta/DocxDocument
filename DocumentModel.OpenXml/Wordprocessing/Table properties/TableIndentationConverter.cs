namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public static class TableIndentationConverter
{
  #region Width conversion.
  private static Int32? GetWidth(DXW.TableIndentation openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.TableIndentation openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.TableIndentation openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  #endregion

  #region Type conversion.
  private static DMW.TableWidthUnitType? GetType(DXW.TableIndentation openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(value);
  }
  
  public static DMW.TableWidth? CreateModelElement(DXW.TableIndentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var width = GetWidth(openXmlElement);
      var type = GetType(openXmlElement);
      var value = new DMW.TableWidth(width, type);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableIndentation? openXmlElement, DMW.TableWidth? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, (Int32)value.Value, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidth value)
    where OpenXmlElementType: DXW.TableIndentation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableIndentation openXmlElement, DMW.TableWidth value)
  {
    SetWidth(openXmlElement, (Int32)value.Value);
    SetType(openXmlElement, value.Type);
  }
  #endregion
}
