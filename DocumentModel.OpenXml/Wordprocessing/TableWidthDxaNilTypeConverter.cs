namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  /// w
  /// </summary>
  private static Int16? GetWidth(DXW.TableWidthDxaNilType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.TableWidthDxaNilType openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.TableWidthDxaNilType openXmlElement, Int16? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// type
  /// </summary>
  private static DMW.TableWidthKind? GetType(DXW.TableWidthDxaNilType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableWidthDxaNilType? CreateModelElement(DXW.TableWidthDxaNilType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthDxaNilType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableWidthDxaNilType? openXmlElement, DMW.TableWidthDxaNilType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidthDxaNilType value)
    where OpenXmlElementType: DXW.TableWidthDxaNilType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthDxaNilType value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetType(openXmlElement, value?.Type);
  }
}
