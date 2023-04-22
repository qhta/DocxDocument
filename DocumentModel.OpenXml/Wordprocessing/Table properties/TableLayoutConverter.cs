namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public static class TableLayoutConverter
{
  #region Table Layout Setting conversion.
  private static DMW.TableLayoutKind? GetType(DXW.TableLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableLayoutValues, DMW.TableLayoutKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableLayout openXmlElement, DMW.TableLayoutKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TableLayoutValues, DMW.TableLayoutKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.TableLayout openXmlElement, DMW.TableLayoutKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.TableLayoutValues, DMW.TableLayoutKind>(value);
  }
  
  public static DMW.TableLayoutKind? CreateModelElement(DXW.TableLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      return GetType(openXmlElement);
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableLayout? openXmlElement, DMW.TableLayoutKind? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableLayoutKind value)
    where OpenXmlElementType: DXW.TableLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableLayout openXmlElement, DMW.TableLayoutKind value)
  {
    SetType(openXmlElement, value);
  }
  #endregion
}
