namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public static class TableIndentationConverter
{
  /// <summary>
  /// w
  /// </summary>
  private static Int32? GetWidth(DXW.TableIndentation openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.TableIndentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Width?.Value == value;
  }
  
  private static void SetWidth(DXW.TableIndentation openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// type
  /// </summary>
  private static DMW.TableWidthUnitKind? GetType(DXW.TableIndentation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.TableIndentation openXmlElement, DMW.TableWidthUnitKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(value);
  }
  
  public static DMW.TableIndentation? CreateModelElement(DXW.TableIndentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableIndentation();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableIndentation? openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableIndentation? value)
    where OpenXmlElementType: DXW.TableIndentation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
