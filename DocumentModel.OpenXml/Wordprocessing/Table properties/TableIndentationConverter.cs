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
  
  private static bool CmpWidth(DXW.TableIndentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitType>(value);
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
  
  public static bool CompareModelElement(DXW.TableIndentation? openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, (Int32)value.Value, diffs, objName))
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
