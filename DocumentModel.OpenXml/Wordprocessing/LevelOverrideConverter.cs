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
  
  private static void SetLevelIndex(DXW.LevelOverride openXmlElement, Int32? value)
  {
    openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  private static Int32? GetStartOverrideNumberingValue(DXW.LevelOverride openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StartOverrideNumberingValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Level>();
    if (itemElement != null)
      return DMXW.LevelConverter.CreateModelElement(itemElement);
    return null;
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
