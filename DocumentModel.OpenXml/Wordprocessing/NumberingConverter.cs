namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public static class NumberingConverter
{
  private static Collection<DMW.NumberingPictureBullet> GetNumberingPictureBullets(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.NumberingPictureBullet>();
    foreach (var item in openXmlElement.Elements<DXW.NumberingPictureBullet>())
    {
      var newItem = DMXW.NumberingPictureBulletConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumberingPictureBullets(DXW.Numbering openXmlElement, Collection<DMW.NumberingPictureBullet>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.NumberingPictureBullet>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.NumberingPictureBulletConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetNumberingPictureBullets(DXW.Numbering openXmlElement, Collection<DMW.NumberingPictureBullet>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.NumberingPictureBullet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.NumberingPictureBulletConverter.CreateOpenXmlElement<DXW.NumberingPictureBullet>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMW.AbstractNum> GetAbstractNums(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.AbstractNum>();
    foreach (var item in openXmlElement.Elements<DXW.AbstractNum>())
    {
      var newItem = DMXW.AbstractNumConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAbstractNums(DXW.Numbering openXmlElement, Collection<DMW.AbstractNum>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.AbstractNum>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.AbstractNumConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetAbstractNums(DXW.Numbering openXmlElement, Collection<DMW.AbstractNum>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.AbstractNum>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AbstractNumConverter.CreateOpenXmlElement<DXW.AbstractNum>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMW.NumberingInstance> GetNumberingInstances(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.NumberingInstance>();
    foreach (var item in openXmlElement.Elements<DXW.NumberingInstance>())
    {
      var newItem = DMXW.NumberingInstanceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumberingInstances(DXW.Numbering openXmlElement, Collection<DMW.NumberingInstance>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.NumberingInstance>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.NumberingInstanceConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetNumberingInstances(DXW.Numbering openXmlElement, Collection<DMW.NumberingInstance>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.NumberingInstance>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.NumberingInstanceConverter.CreateOpenXmlElement<DXW.NumberingInstance>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Int32? GetNumberingIdMacAtCleanup(DXW.Numbering openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.NumberingIdMacAtCleanup>()?.Val?.Value;
  }
  
  private static bool CmpNumberingIdMacAtCleanup(DXW.Numbering openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.NumberingIdMacAtCleanup>()?.Val?.Value == value;
  }
  
  private static void SetNumberingIdMacAtCleanup(DXW.Numbering openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingIdMacAtCleanup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingIdMacAtCleanup{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Numbering? CreateModelElement(DXW.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Numbering();
      value.NumberingPictureBullets = GetNumberingPictureBullets(openXmlElement);
      value.AbstractNums = GetAbstractNums(openXmlElement);
      value.NumberingInstances = GetNumberingInstances(openXmlElement);
      value.NumberingIdMacAtCleanup = GetNumberingIdMacAtCleanup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Numbering? openXmlElement, DMW.Numbering? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberingPictureBullets(openXmlElement, value.NumberingPictureBullets, diffs, objName))
        ok = false;
      if (!CmpAbstractNums(openXmlElement, value.AbstractNums, diffs, objName))
        ok = false;
      if (!CmpNumberingInstances(openXmlElement, value.NumberingInstances, diffs, objName))
        ok = false;
      if (!CmpNumberingIdMacAtCleanup(openXmlElement, value.NumberingIdMacAtCleanup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Numbering? value)
    where OpenXmlElementType: DXW.Numbering, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingPictureBullets(openXmlElement, value?.NumberingPictureBullets);
      SetAbstractNums(openXmlElement, value?.AbstractNums);
      SetNumberingInstances(openXmlElement, value?.NumberingInstances);
      SetNumberingIdMacAtCleanup(openXmlElement, value?.NumberingIdMacAtCleanup);
      return openXmlElement;
    }
    return default;
  }
}
