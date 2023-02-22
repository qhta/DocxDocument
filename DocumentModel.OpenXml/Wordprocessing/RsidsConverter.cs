namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  private static HexInt? GetRsidRoot(DXW.Rsids openXmlElement)
  {
    return HexIntConverter.GetValue(openXmlElement?.RsidRoot?.Val?.Value);
  }
  
  private static bool CmpRsidRoot(DXW.Rsids openXmlElement, HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRoot?.Val?.Value, value, diffs, objName, "RsidRoot");
  }
  
  private static void SetRsidRoot(DXW.Rsids openXmlElement, HexInt? value)
  {
    openXmlElement.RsidRoot = HexIntConverter.CreateValue<DXW.RsidRoot>(value);
  }
  
  private static Collection<HexInt> GetItems(DXW.Rsids openXmlElement)
  {
    var collection = new Collection<HexInt>();
    foreach (var item in openXmlElement.Elements<DXW.Rsid>())
    {
      var newItem = HexIntConverter.GetValue(item);
      if (newItem != null)
        collection.Add((HexInt)newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.Rsids openXmlElement, IEnumerable<HexInt>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.Rsid>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Rsids openXmlElement, IEnumerable<HexInt>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Rsid>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXW.Rsid>(item);
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
      var rsidRoot = GetRsidRoot(openXmlElement);
      if (rsidRoot!=null)
        value.Add((uint)rsidRoot);
      var rsIdItems = GetItems(openXmlElement);
      foreach (var item in rsIdItems)
        value.Add(item);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Rsids? openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidRoot(openXmlElement, value.FirstOrDefault(), diffs, objName))
        ok = false;
      var items = value.ToList();
      if (items.Count>0)
        items.RemoveAt(0);
      if (!CmpItems(openXmlElement, items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Rsids? value)
    where OpenXmlElementType: DXW.Rsids, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRoot(openXmlElement, value.FirstOrDefault());
            var items = value.ToList();
      if (items.Count>0)
        items.RemoveAt(0);
      SetItems(openXmlElement, items);
      return openXmlElement;
    }
    return default;
  }
}
