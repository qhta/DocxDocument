namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public static class TableRowHeightConverter
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  private static UInt32? GetVal(DXW.TableRowHeight openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.TableRowHeight openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.TableRowHeight openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  private static DMW.HeightRuleKind? GetHeightType(DXW.TableRowHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  private static bool CmpHeightType(DXW.TableRowHeight openXmlElement, DMW.HeightRuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value, value, diffs, objName);
  }
  
  private static void SetHeightType(DXW.TableRowHeight openXmlElement, DMW.HeightRuleKind? value)
  {
    openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(value);
  }
  
  public static DMW.TableRowHeight? CreateModelElement(DXW.TableRowHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var val = GetVal(openXmlElement);
      var type = GetHeightType(openXmlElement);
      var value = new DMW.TableRowHeight(val, type);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowHeight? openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Value, diffs, objName))
        ok = false;
      if (!CmpHeightType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowHeight value)
    where OpenXmlElementType: DXW.TableRowHeight, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowHeight openXmlElement, DMW.TableRowHeight value)
  {
    SetVal(openXmlElement, value?.Value);
    SetHeightType(openXmlElement, value?.Type);
  }
}
