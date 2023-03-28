namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public static class LevelOverrideConverter
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  private static Int32? GetLevelIndex(DXW.LevelOverride openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }
  
  private static bool CmpLevelIndex(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LevelIndex?.Value == value) return true;
    diffs?.Add(objName, "LevelIndex", openXmlElement?.LevelIndex?.Value, value);
    return false;
  }
  
  private static void SetLevelIndex(DXW.LevelOverride openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  private static Int32? GetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val);
  }
  
  private static bool CmpStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val, value, diffs, objName, "StartOverrideNumberingValue");
  }
  
  private static void SetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.StartOverrideNumberingValue,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  private static DMW.NumLevel? GetLevel(DXW.LevelOverride openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Level>();
    if (element != null)
      return DMXW.LevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel(DXW.LevelOverride openXmlElement, DMW.NumLevel? value, DiffList? diffs, string? objName)
  {
    return DMXW.LevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Level>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.NumLevelOverride? CreateModelElement(DXW.LevelOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumLevelOverride();
      value.LevelIndex = GetLevelIndex(openXmlElement);
      value.StartOverrideNumberingValue = GetStartOverrideNumberingValue(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LevelOverride? openXmlElement, DMW.NumLevelOverride? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLevelIndex(openXmlElement, value.LevelIndex, diffs, objName))
        ok = false;
      if (!CmpStartOverrideNumberingValue(openXmlElement, value.StartOverrideNumberingValue, diffs, objName))
        ok = false;
      if (!CmpLevel(openXmlElement, value.Level, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumLevelOverride value)
    where OpenXmlElementType: DXW.LevelOverride, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LevelOverride openXmlElement, DMW.NumLevelOverride value)
  {
    SetLevelIndex(openXmlElement, value?.LevelIndex);
    SetStartOverrideNumberingValue(openXmlElement, value?.StartOverrideNumberingValue);
    SetLevel(openXmlElement, value?.Level);
  }
}
