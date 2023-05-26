namespace DocumentModel.OpenXml.Wordprocessing;


/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumLevelText"/> class from/to OpenXml converter.
/// </summary>
public static class LevelTextConverter
{

  #region LevelText conversion.
  private static String? GetVal(DXW.LevelText openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }

  private static bool CmpVal(DXW.LevelText openXmlElement, string? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Text");
  }

  private static void SetVal(DXW.LevelText openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Level Text Is Null Character conversion
  private static Boolean GetNull(DXW.LevelText openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Null) ?? false;
  }

  private static bool CmpNull(DXW.LevelText openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Null ?? false, value, diffs, objName, "Null");
  }

  private static void SetNull(DXW.LevelText openXmlElement, Boolean? value)
  {
    openXmlElement.Null = BooleanValueConverter.CreateOnOffValue(value, null, "1");
  }
  #endregion

  #region NumLevelText model conversion
  public static DMW.NumLevelText? CreateModelElement(DXW.LevelText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumLevelText();
      model.Text = GetVal(openXmlElement);
      model.IsNull = GetNull(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.LevelText? openXmlElement, DMW.NumLevelText? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, model.Text, diffs, objName, propName))
        ok = false;
      if (!CmpNull(openXmlElement, model.IsNull, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumLevelText model)
    where OpenXmlElementType : DXW.LevelText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.LevelText openXmlElement, DMW.NumLevelText model)
  {
    SetVal(openXmlElement, model?.Text);
    SetNull(openXmlElement, model?.IsNull);
  }
  #endregion
}
