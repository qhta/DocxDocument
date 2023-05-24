namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  private static DMW.Rsid? GetRsidRoot(DXW.Rsids openXmlElement)
  {
    var val = HexIntConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RsidRoot>()?.Val);
    if (val!=null)
      return new DMW.Rsid{ Id = (HexInt)val };
    return null;
  }

  private static bool CmpRsidRoot(DXW.Rsids openXmlElement, DMW.Rsid? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RsidRoot>()?.Val, value?.Id, diffs, objName, "RsidRoot");
  }

  private static void SetRsidRoot(DXW.Rsids openXmlElement, DMW.Rsid? value)
  {
    HexIntConverter.SetValue<DXW.RsidRoot>(openXmlElement, value?.Id);
  }

  private static void GetItems(DXW.Rsids openXmlElement, DMW.Rsids collection)
  {
    var rootId = GetRsidRoot(openXmlElement);
    if (rootId!=null)
      collection.Add(rootId);
    foreach (var item in openXmlElement.Elements<DXW.Rsid>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add(new DMW.Rsid{ Id = (HexInt)newItem });
    }
  }

  private static bool CmpItems(DXW.Rsids openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Rsid>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0 + 1;
    if (value != null)
    {
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      modelEnumerator.MoveNext();
      var modelItem = modelEnumerator.Current;
      if (!CmpRsidRoot(openXmlElement, modelItem, diffs, objName))
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        modelItem = modelEnumerator.Current;
        if (!HexIntConverter.CmpValue(origItem, modelItem.Id, diffs, objName))
          ok = false;
      }
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  private static void SetItems(DXW.Rsids openXmlElement, DMW.Rsids? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Rsid>();
    if (value != null)
    {
      var modelEnumerator = value.GetEnumerator();
      modelEnumerator.MoveNext();
      var modelItem = modelEnumerator.Current;
      SetRsidRoot(openXmlElement, modelItem);
      while (modelEnumerator.MoveNext())
      {
        modelItem = modelEnumerator.Current;
        var newItem = HexIntConverter.CreateOpenXmlElement<DXW.Rsid>(modelItem.Id);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }

  public static DMW.Rsids? CreateModelElement(DXW.Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Rsids();
      GetItems(openXmlElement, value);
      if (value.Count == 0)
        return null;
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Rsids? openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Rsids value)
    where OpenXmlElementType : DXW.Rsids, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Rsids openXmlElement, DMW.Rsids value)
  {
    SetItems(openXmlElement, value);
  }
}
