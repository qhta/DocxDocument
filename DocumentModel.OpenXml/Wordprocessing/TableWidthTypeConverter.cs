namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  private static String? GetWidth(DXW.TableWidthType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.TableWidthType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value, diffs, objName, "Width");
  }
  
  private static void SetWidth(DXW.TableWidthType openXmlElement, String? value)
  {
    openXmlElement.Width = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  private static DMW.TableWidthUnitKind? GetType(DXW.TableWidthType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableWidthType? CreateModelElement(DXW.TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableWidthType? openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidthType value)
    where OpenXmlElementType: DXW.TableWidthType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthType openXmlElement, DMW.TableWidthType value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetType(openXmlElement, value?.Type);
    }
  }
