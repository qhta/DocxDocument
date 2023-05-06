namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingInstance"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingInstanceConverter
{

  #region numId
  private static Int32? GetNumberID(DXW.NumberingInstance openXmlElement)
  {
    return openXmlElement?.NumberID?.Value;
  }
  
  private static bool CmpNumberID(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NumberID?.Value == value) return true;
    diffs?.Add(objName, "NumberID", openXmlElement?.NumberID?.Value, value);
    return false;
  }
  
  private static void SetNumberID(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.NumberID = value;
  }
#endregion

  #region durableId
  private static Int32? GetDurableId(DXW.NumberingInstance openXmlElement)
  {
    return openXmlElement?.DurableId?.Value;
  }
  
  private static bool CmpDurableId(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DurableId?.Value == value) return true;
    diffs?.Add(objName, "DurableId", openXmlElement?.DurableId?.Value, value);
    return false;
  }
  
  private static void SetDurableId(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.DurableId = value;
  }
#endregion

  #region AbstractNumId.
  private static Int32? GetAbstractNumId(DXW.NumberingInstance openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.AbstractNumId>()?.Val);
  }
  
  private static bool CmpAbstractNumId(DXW.NumberingInstance openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.AbstractNumId>()?.Val, value, diffs, objName, "AbstractNumId");
  }
  
  private static void SetAbstractNumId(DXW.NumberingInstance openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.AbstractNumId,System.Int32>(openXmlElement, value);
  }
  
  private static DMW.NumLevelOverrides? GetLevelOverrides(DXW.NumberingInstance openXmlElement)
  {
    var collection = new DMW.NumLevelOverrides();
    foreach (var item in openXmlElement.Elements<DXW.LevelOverride>())
    {
      var newItem = DMXW.LevelOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLevelOverrides(DXW.NumberingInstance openXmlElement, Collection<DMW.NumLevelOverride>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.LevelOverride>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.LevelOverrideConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLevelOverrides(DXW.NumberingInstance openXmlElement, Collection<DMW.NumLevelOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.LevelOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LevelOverrideConverter.CreateOpenXmlElement<DXW.LevelOverride>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingInstance value)
    where OpenXmlElementType: DXW.NumberingInstance, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingInstance openXmlElement, DMW.NumberingInstance value)
  {
    SetNumberID(openXmlElement, value?.NumberID);
    SetDurableId(openXmlElement, value?.DurableId);
    SetAbstractNumId(openXmlElement, value?.AbstractNumId);
    SetLevelOverrides(openXmlElement, value?.LevelOverrides);
  }
#endregion
}
