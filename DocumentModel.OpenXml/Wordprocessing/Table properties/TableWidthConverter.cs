namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableWidthType"/> class from/to OpenXml converter.
/// </summary>
public static class TableWidthTypeConverter
{
  #region Width conversion.
  private static Int64? GetWidth(DXW.TableWidthType openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.TableWidthType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value.ToString(), diffs, objName, "Value");
  }
  
  private static void SetWidth(DXW.TableWidthType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value!=null ? StringValueConverter.CreateStringValue(value.ToString()) : null;
  }
  #endregion

  #region Type conversion.
  private static DMW.TableWidthUnitType? GetType(DXW.TableWidthType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.TableWidthUnitValues, DMW.TableWidthUnitType>(value);
  }
  #endregion

  #region TableWidth value conversion.
  public static DMW.TableWidth? GetValue(DX.StringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var width = Int64ValueConverter.GetValue(openXmlElement);
      var model = new DMW.TableWidth(width);
      return model;
    }
    return null;
  }
  
  public static bool CmpValue(DX.StringValue? openXmlElement, DMW.TableWidth? model, DiffList? diffs, string? objName, string? propName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!Int64ValueConverter.CmpValue(openXmlElement, model.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DX.StringValue? CreateStringValue(DMW.TableWidth? model)
  {
    var openXmlElement = new DX.StringValue();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DX.StringValue openXmlElement, DMW.TableWidth? model)
  {
    Int64ValueConverter.SetStringValue(openXmlElement, model?.Value);
  }
  #endregion

  #region TableWidthType model conversion.
  public static DMW.TableWidth? CreateModelElement(DXW.TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var width = GetWidth(openXmlElement);
      var type = GetType(openXmlElement);
      var model = new DMW.TableWidth(width, type);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableWidthType? openXmlElement, DMW.TableWidth? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, model.Value, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, model.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidth model)
    where OpenXmlElementType: DXW.TableWidthType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthType openXmlElement, DMW.TableWidth model)
  {
    SetWidth(openXmlElement, model?.Value);
    SetType(openXmlElement, model?.Type);
  }
  #endregion
}
