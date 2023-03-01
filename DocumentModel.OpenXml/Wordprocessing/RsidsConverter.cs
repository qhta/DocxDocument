namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  private static DM.HexInt? GetRsidRoot(DXW.Rsids openXmlElement)
  {
    return HexIntConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RsidRoot>()?.Val);
  }
  
  private static bool CmpRsidRoot(DXW.Rsids openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RsidRoot>()?.Val, value, diffs, objName, "RsidRoot");
  }
  
  private static void SetRsidRoot(DXW.Rsids openXmlElement, DM.HexInt? value)
  {
    HexIntConverter.SetValue<DXW.RsidRoot>(openXmlElement, value);
  }
  
  private static Collection<DM.HexInt>? GetItems(DXW.Rsids openXmlElement)
  {
    var collection = new Collection<DM.HexInt>();
    foreach (var item in openXmlElement.Elements<DXW.Rsid>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((HexInt)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.Rsids openXmlElement, Collection<DM.HexInt>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Rsid>();
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
        if (!HexIntConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Rsids openXmlElement, Collection<DM.HexInt>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Rsid>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = HexIntConverter.CreateOpenXmlElement<DXW.Rsid>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Rsids? CreateModelElement(DXW.Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Rsids();
      value.RsidRoot = GetRsidRoot(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Rsids? openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidRoot(openXmlElement, value.RsidRoot, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Rsids value)
    where OpenXmlElementType: DXW.Rsids, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Rsids openXmlElement, DMW.Rsids value)
  {
    SetRsidRoot(openXmlElement, value?.RsidRoot);
    SetItems(openXmlElement, value?.Items);
  }
}
