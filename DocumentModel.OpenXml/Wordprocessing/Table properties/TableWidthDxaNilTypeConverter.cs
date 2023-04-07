namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  /// w
  private static Int16? GetWidth(DXW.TableWidthDxaNilType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.TableWidthDxaNilType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.TableWidthDxaNilType openXmlElement, Int64? value)
  {
    openXmlElement.Width = (Int16?)value;
  }
  
  /// <summary>
  /// type
  private static DMW.TableWidthKind? GetType(DXW.TableWidthDxaNilType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs, string? objName)
  {
    DMW.TableWidthKind? kind = (value == DocumentModel.Wordprocessing.TableWidthUnitType.Nil) ? DocumentModel.Wordprocessing.TableWidthKind.Nil 
      : (value == DocumentModel.Wordprocessing.TableWidthUnitType.Twips) ? DocumentModel.Wordprocessing.TableWidthKind.Twips : null;
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value, kind, diffs, objName);
  }
  
  private static void SetType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthUnitType? value)
  {
    DMW.TableWidthKind? kind = (value == DocumentModel.Wordprocessing.TableWidthUnitType.Nil) ? DocumentModel.Wordprocessing.TableWidthKind.Nil 
      : (value == DocumentModel.Wordprocessing.TableWidthUnitType.Twips) ? DocumentModel.Wordprocessing.TableWidthKind.Twips : null;
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(kind);
  }
  
  public static DMW.TableWidth? CreateModelElement(DXW.TableWidthDxaNilType? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.TableWidthDxaNilType? openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXW.TableWidthDxaNilType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidth value)
  {
    SetWidth(openXmlElement, value?.Value);
    SetType(openXmlElement, value?.Type);
  }
}
