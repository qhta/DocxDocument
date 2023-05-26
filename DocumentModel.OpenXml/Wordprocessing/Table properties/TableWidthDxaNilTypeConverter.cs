namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableWidthDxaNilType"/> class from/to OpenXml converter.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  #region Width conversion.
  private static Int16? GetWidth(DXW.TableWidthDxaNilType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.TableWidthDxaNilType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.TableWidthDxaNilType openXmlElement, Int64? value)
  {
    openXmlElement.Width = (Int16?)value;
  }
  #endregion

  #region Type conversion.
  private static DMW.TableWidthKind? GetType(DXW.TableWidthDxaNilType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthUnitType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    DMW.TableWidthKind? kind = (value == DocumentModel.Wordprocessing.TableWidthUnitType.Nil) ? DocumentModel.Wordprocessing.TableWidthKind.Nil 
      : (value == DocumentModel.Wordprocessing.TableWidthUnitType.Twips) ? DocumentModel.Wordprocessing.TableWidthKind.Twips : null;
    return EnumValueConverter.CmpValue<DXW.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value, kind, diffs, objName, propName);
  }
  
  private static void SetType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthUnitType? value)
  {
    DMW.TableWidthKind? kind = (value == DocumentModel.Wordprocessing.TableWidthUnitType.Nil) ? DocumentModel.Wordprocessing.TableWidthKind.Nil 
      : (value == DocumentModel.Wordprocessing.TableWidthUnitType.Twips) ? DocumentModel.Wordprocessing.TableWidthKind.Twips : null;
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.TableWidthValues, DMW.TableWidthKind>(kind);
  }
  #endregion

  #region TableWidthDxaNilType model conversion
  public static DMW.TableWidth? CreateModelElement(DXW.TableWidthDxaNilType? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.TableWidthDxaNilType? openXmlElement, DMW.TableWidth? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, model.Value, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, model.Type, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidth model)
    where OpenXmlElementType: DXW.TableWidthDxaNilType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidth model)
  {
    SetWidth(openXmlElement, model?.Value);
    SetType(openXmlElement, model?.Type);
  }
  #endregion
}
