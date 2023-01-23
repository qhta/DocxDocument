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
    return openXmlElement.LevelIndex?.Value;
  }
  
  private static bool CmpLevelIndex(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LevelIndex?.Value == value;
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
    return openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val?.Value;
  }
  
  private static bool CmpStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>()?.Val?.Value == value;
  }
  
  private static void SetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartOverrideNumberingValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StartOverrideNumberingValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  private static DMW.Level? GetLevel(DXW.LevelOverride openXmlElement)
  {
    return DMXW.LevelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Level>());
  }
  
  private static bool CmpLevel(DXW.LevelOverride openXmlElement, DMW.Level? value, DiffList? diffs, string? objName)
  {
    return DMXW.LevelConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Level>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLevel(DXW.LevelOverride openXmlElement, DMW.Level? value)
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
  
  public static DMW.LevelOverride? CreateModelElement(DXW.LevelOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LevelOverride();
      value.LevelIndex = GetLevelIndex(openXmlElement);
      value.StartOverrideNumberingValue = GetStartOverrideNumberingValue(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LevelOverride? openXmlElement, DMW.LevelOverride? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LevelOverride? value)
    where OpenXmlElementType: DXW.LevelOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLevelIndex(openXmlElement, value?.LevelIndex);
      SetStartOverrideNumberingValue(openXmlElement, value?.StartOverrideNumberingValue);
      SetLevel(openXmlElement, value?.Level);
      return openXmlElement;
    }
    return default;
  }
}
