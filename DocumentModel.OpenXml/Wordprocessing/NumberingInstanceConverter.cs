namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public static class NumberingInstanceConverter
{
  /// <summary>
  /// numId
  /// </summary>
  private static Int32? GetNumberID(DXW.NumberingInstance openXmlElement)
  {
    return openXmlElement.NumberID?.Value;
  }
  
  private static bool CmpNumberID(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.NumberID?.Value == value;
  }
  
  private static void SetNumberID(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.NumberID = value;
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  private static Int32? GetDurableId(DXW.NumberingInstance openXmlElement)
  {
    return openXmlElement.DurableId?.Value;
  }
  
  private static bool CmpDurableId(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DurableId?.Value == value;
  }
  
  private static void SetDurableId(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.DurableId = value;
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  private static Int32? GetAbstractNumId(DXW.NumberingInstance openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.AbstractNumId>()?.Val?.Value;
  }
  
  private static bool CmpAbstractNumId(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.AbstractNumId>()?.Val?.Value == value;
  }
  
  private static void SetAbstractNumId(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AbstractNumId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AbstractNumId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.LevelOverride> GetLevelOverrides(DXW.NumberingInstance openXmlElement)
  {
    var collection = new Collection<DMW.LevelOverride>();
    foreach (var item in openXmlElement.Elements<DXW.LevelOverride>())
    {
      var newItem = DMXW.LevelOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLevelOverrides(DXW.NumberingInstance openXmlElement, Collection<DMW.LevelOverride>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetLevelOverrides(DXW.NumberingInstance openXmlElement, Collection<DMW.LevelOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.LevelOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LevelOverrideConverter.CreateOpenXmlElement<DXW.LevelOverride>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.NumberingInstance? CreateModelElement(DXW.NumberingInstance? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingInstance();
      value.NumberID = GetNumberID(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      value.AbstractNumId = GetAbstractNumId(openXmlElement);
      value.LevelOverrides = GetLevelOverrides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingInstance? openXmlElement, DMW.NumberingInstance? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberID(openXmlElement, value.NumberID, diffs, objName))
        ok = false;
      if (!CmpDurableId(openXmlElement, value.DurableId, diffs, objName))
        ok = false;
      if (!CmpAbstractNumId(openXmlElement, value.AbstractNumId, diffs, objName))
        ok = false;
      if (!CmpLevelOverrides(openXmlElement, value.LevelOverrides, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingInstance? value)
    where OpenXmlElementType: DXW.NumberingInstance, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberID(openXmlElement, value?.NumberID);
      SetDurableId(openXmlElement, value?.DurableId);
      SetAbstractNumId(openXmlElement, value?.AbstractNumId);
      SetLevelOverrides(openXmlElement, value?.LevelOverrides);
      return openXmlElement;
    }
    return default;
  }
}
