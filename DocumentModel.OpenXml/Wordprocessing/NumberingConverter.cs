namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public static class NumberingConverter
{
  private static Collection<DMW.NumberingPictureBullet>? GetNumberingPictureBullets(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.NumberingPictureBullet>();
    foreach (var item in openXmlElement.Elements<DXW.NumberingPictureBullet>())
    {
      var newItem = DMXW.NumberingPictureBulletConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumberingPictureBullets(DXW.Numbering openXmlElement, Collection<DMW.NumberingPictureBullet>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.NumberingPictureBullet>();
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
        if (!DMXW.NumberingPictureBulletConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
  
  private static Collection<DMW.AbstractNum>? GetAbstractNums(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.AbstractNum>();
    foreach (var item in openXmlElement.Elements<DXW.AbstractNum>())
    {
      var newItem = DMXW.AbstractNumConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAbstractNums(DXW.Numbering openXmlElement, Collection<DMW.AbstractNum>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.AbstractNum>();
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
        if (!DMXW.AbstractNumConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
  
  private static Collection<DMW.NumberingInstance>? GetNumberingInstances(DXW.Numbering openXmlElement)
  {
    var collection = new Collection<DMW.NumberingInstance>();
    foreach (var item in openXmlElement.Elements<DXW.NumberingInstance>())
    {
      var newItem = DMXW.NumberingInstanceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumberingInstances(DXW.Numbering openXmlElement, Collection<DMW.NumberingInstance>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.NumberingInstance>();
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
        if (!DMXW.NumberingInstanceConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingIdMacAtCleanup>()?.Val);
  }
  
  private static bool CmpNumberingIdMacAtCleanup(DXW.Numbering openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingIdMacAtCleanup>()?.Val, value, diffs, objName, "NumberingIdMacAtCleanup");
  }
  
  private static void SetNumberingIdMacAtCleanup(DXW.Numbering openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingIdMacAtCleanup,System.Int32>(openXmlElement, value);
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Numbering value)
    where OpenXmlElementType: DXW.Numbering, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Numbering openXmlElement, DMW.Numbering value)
  {
    SetNumberingPictureBullets(openXmlElement, value?.NumberingPictureBullets);
    SetAbstractNums(openXmlElement, value?.AbstractNums);
    SetNumberingInstances(openXmlElement, value?.NumberingInstances);
    SetNumberingIdMacAtCleanup(openXmlElement, value?.NumberingIdMacAtCleanup);
  }
}
