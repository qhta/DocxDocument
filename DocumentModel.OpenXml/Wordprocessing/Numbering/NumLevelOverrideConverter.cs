namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumLevelOverride"/> class from/to OpenXml converter.
/// </summary>
public static class LevelOverrideConverter
{
  #region LevelIndex conversion.
  private static Int32? GetLevelIndex(DXW.LevelOverride openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }
  
  private static bool CmpLevelIndex(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LevelIndex?.Value == value) return true;
    diffs?.Add(objName, "LevelIndex", openXmlElement?.LevelIndex?.Value, value);
    return false;
  }
  
  private static void SetLevelIndex(DXW.LevelOverride openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
#endregion

  #region StartOverrideNumberingValue conversion.
  private static Int32? GetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val);
  }
  
  private static bool CmpStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val, value, diffs, objName, "StartOverrideNumberingValue");
  }
  
  private static void SetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.StartOverrideNumberingValue,System.Int32>(openXmlElement, value);
  }
#endregion

  #region NumLevel conversion
  private static DMW.NumLevel? GetLevel(DXW.LevelOverride openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Level>();
    if (element != null)
      return DMXW.LevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel(DXW.LevelOverride openXmlElement, DMW.NumLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.LevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Level>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel(DXW.LevelOverride openXmlElement, DMW.NumLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Level>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LevelConverter.CreateOpenXmlElement<DXW.Level>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region NumLevelOverride model conversion
  public static DMW.NumLevelOverride? CreateModelElement(DXW.LevelOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumLevelOverride();
      model.LevelIndex = GetLevelIndex(openXmlElement);
      model.StartOverrideNumberingValue = GetStartOverrideNumberingValue(openXmlElement);
      model.Level = GetLevel(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LevelOverride? openXmlElement, DMW.NumLevelOverride? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLevelIndex(openXmlElement, model.LevelIndex, diffs, objName, propName))
        ok = false;
      if (!CmpStartOverrideNumberingValue(openXmlElement, model.StartOverrideNumberingValue, diffs, objName, propName))
        ok = false;
      if (!CmpLevel(openXmlElement, model.Level, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumLevelOverride model)
    where OpenXmlElementType: DXW.LevelOverride, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LevelOverride openXmlElement, DMW.NumLevelOverride model)
  {
    SetLevelIndex(openXmlElement, model?.LevelIndex);
    SetStartOverrideNumberingValue(openXmlElement, model?.StartOverrideNumberingValue);
    SetLevel(openXmlElement, model?.Level);
  }
  #endregion

}