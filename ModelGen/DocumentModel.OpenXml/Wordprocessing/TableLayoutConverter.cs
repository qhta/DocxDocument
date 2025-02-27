namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public static class TableLayoutConverter
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  private static DMW.TableLayoutKind? GetType(DXW.TableLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DMW.TableLayoutKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableLayout openXmlElement, DMW.TableLayoutKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DMW.TableLayoutKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.TableLayout openXmlElement, DMW.TableLayoutKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DMW.TableLayoutKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableLayout? CreateModelElement(DXW.TableLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableLayout();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableLayout? openXmlElement, DMW.TableLayout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableLayout value)
    where OpenXmlElementType: DXW.TableLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableLayout openXmlElement, DMW.TableLayout value)
  {
    SetType(openXmlElement, value?.Type);
  }
}
