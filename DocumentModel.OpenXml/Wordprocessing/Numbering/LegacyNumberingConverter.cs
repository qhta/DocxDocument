namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.LegacyNumbering"/> class from/to OpenXml converter.
/// </summary>
public static class LegacyNumberingConverter
{
  #region Legacy conversion.
  private static Boolean GetLegacy(DXW.LegacyNumbering openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Legacy) ?? true;
  }
  
  private static bool CmpLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Legacy, value, diffs, objName, "Use");
  }
  
  private static void SetLegacy(DXW.LegacyNumbering openXmlElement, Boolean? value)
  {
    openXmlElement.Legacy = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region LegacySpace conversion.
  private static Twips GetLegacySpace(DXW.LegacyNumbering openXmlElement)
  {
    if (openXmlElement?.LegacySpace!=null)
      return Int32ValueConverter.GetValue(openXmlElement.LegacySpace) ?? 0;
    return 0;
  }
  
  private static bool CmpLegacySpace(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LegacySpace, value, diffs, objName, "Space");
  }
  
  private static void SetLegacySpace(DXW.LegacyNumbering openXmlElement, String? value)
  {
    openXmlElement.LegacySpace = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region LegacyIndent conversion.
  private static Twips GetLegacyIndent(DXW.LegacyNumbering openXmlElement)
  {
    if (openXmlElement?.LegacyIndent!=null)
      return Int32ValueConverter.GetValue(openXmlElement.LegacyIndent) ?? 0;
    return 0;
  }

  private static bool CmpLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LegacyIndent, value, diffs, objName, "Indent");
  }
  
  private static void SetLegacyIndent(DXW.LegacyNumbering openXmlElement, String? value)
  {
    openXmlElement.LegacyIndent = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region LegacyNumbering model conversion
  public static DMW.LegacyNumbering? CreateModelElement(DXW.LegacyNumbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.LegacyNumbering();
      model.Use = GetLegacy(openXmlElement);
      model.Space = GetLegacySpace(openXmlElement);
      model.Indent = GetLegacyIndent(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LegacyNumbering? openXmlElement, DMW.LegacyNumbering? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLegacy(openXmlElement, model.Use, diffs, objName, propName))
        ok = false;
      if (!CmpLegacySpace(openXmlElement, model.Space, diffs, objName, propName))
        ok = false;
      if (!CmpLegacyIndent(openXmlElement, model.Indent, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LegacyNumbering model)
    where OpenXmlElementType: DXW.LegacyNumbering, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LegacyNumbering openXmlElement, DMW.LegacyNumbering model)
  {
    SetLegacy(openXmlElement, model.Use);
    SetLegacySpace(openXmlElement, model.Space);
    SetLegacyIndent(openXmlElement, model.Indent);
  }
  #endregion
}
