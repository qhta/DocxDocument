namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableRowHeight"/> class from/to OpenXml converter.
/// </summary>
public static class TableRowHeightConverter
{
  #region Value conversion.
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
  #endregion

  #region HeightType conversion.
  private static DMW.HeightRuleKind? GetHeightType(DXW.TableRowHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  private static bool CmpHeightType(DXW.TableRowHeight openXmlElement, DMW.HeightRuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value, value, diffs, objName);
  }
  
  private static void SetHeightType(DXW.TableRowHeight openXmlElement, DMW.HeightRuleKind? value)
  {
    openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DXW.HeightRuleValues, DMW.HeightRuleKind>(value);
  }
  #endregion

  #region TableRowHeight model conversion.
  public static DMW.TableRowHeight? CreateModelElement(DXW.TableRowHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var val = GetVal(openXmlElement);
      var type = GetHeightType(openXmlElement);
      var model = new DMW.TableRowHeight(val, type);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowHeight? openXmlElement, DMW.TableRowHeight? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, model.Value, diffs, objName))
        ok = false;
      if (!CmpHeightType(openXmlElement, model.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowHeight model)
    where OpenXmlElementType: DXW.TableRowHeight, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowHeight openXmlElement, DMW.TableRowHeight model)
  {
    SetVal(openXmlElement, model?.Value);
    SetHeightType(openXmlElement, model?.Type);
  }
  #endregion
}
