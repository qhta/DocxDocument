namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static DMW.ExtensionList? GetExtensions(DXO21WCE.ExtensionList openXmlElement)
  {
    var collection = new DMW.ExtensionList();
    foreach (var item in openXmlElement.Elements<DXO21WEL.Extension>())
    {
      var newItem = DMXW.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }

  public static bool CmpExtensions(DXO21WCE.ExtensionList? openXmlElement, Collection<DMW.Extension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    int origElementsCount = 0;
    if (openXmlElement != null)
    {
      var origElements = openXmlElement.Elements<DXO21WEL.Extension>();
      origElementsCount = origElements.Count();
      var modelElementsCount = value?.Count() ?? 0;
      if (value != null)
      {
        if (origElementsCount != modelElementsCount)
        {
          diffs?.Add(objName, propName ?? openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
          return false;
        }
        var ok = true;
        var modelEnumerator = value.GetEnumerator();
        foreach (var origItem in origElements)
        {
          modelEnumerator.MoveNext();
          var modelItem = modelEnumerator.Current;
          if (!DMXW.ExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
            ok = false;
        }
        return ok;
      }
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static void SetExtensions(DXO21WCE.ExtensionList openXmlElement, Collection<DMW.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO21WEL.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ExtensionConverter.CreateOpenXmlElement<DXO21WEL.Extension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }

  public static DMW.ExtensionList? CreateModelElement(DXO21WCE.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      return GetExtensions(openXmlElement);
    }
    return null;
  }

  public static bool CompareModelElement(DXO21WCE.ExtensionList? openXmlElement, DMW.ExtensionList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpExtensions(openXmlElement, model, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtensionList model)
    where OpenXmlElementType : DXO21WCE.ExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXO21WCE.ExtensionList openXmlElement, DMW.ExtensionList model)
  {
    SetExtensions(openXmlElement, model);
  }
}
