namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.Numbering"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingConverter
{
  #region NumberingPictureBullets
  private static DMW.NumberingPictureBullets? GetNumberingPictureBullets(DXW.Numbering openXmlElement)
  {
    var collection = new DMW.NumberingPictureBullets();
    foreach (var item in openXmlElement.Elements<DXW.NumberingPictureBullet>())
    {
      var newItem = DMXW.NumberingPictureBulletConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
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
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
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
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region AbstractNums 
  private static DMW.AbstractNums? GetAbstractNums(DXW.Numbering openXmlElement)
  {
    var collection = new DMW.AbstractNums();
    foreach (var item in openXmlElement.Elements<DXW.AbstractNum>())
    {
      var newItem = DMXW.AbstractNumConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
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
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
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
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region NumberingInstances 
  private static DMW.NumberingInstances? GetNumberingInstances(DXW.Numbering openXmlElement)
  {
    var collection = new DMW.NumberingInstances();
    foreach (var item in openXmlElement.Elements<DXW.NumberingInstance>())
    {
      var newItem = DMXW.NumberingInstanceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
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
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
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
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region NumberingIdMacAtCleanup 
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
    SimpleValueConverter.SetValue<DXW.NumberingIdMacAtCleanup, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region Numbering model conversion
  public static DMW.Numbering? CreateModelElement(DXW.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Numbering();
      model.NumberingPictureBullets = GetNumberingPictureBullets(openXmlElement);
      model.AbstractNums = GetAbstractNums(openXmlElement);
      model.NumberingInstances = GetNumberingInstances(openXmlElement);
      model.NumberingIdMacAtCleanup = GetNumberingIdMacAtCleanup(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Numbering? openXmlElement, DMW.Numbering? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpNumberingPictureBullets(openXmlElement, model.NumberingPictureBullets, diffs, objName))
        ok = false;
      if (!CmpAbstractNums(openXmlElement, model.AbstractNums, diffs, objName))
        ok = false;
      if (!CmpNumberingInstances(openXmlElement, model.NumberingInstances, diffs, objName))
        ok = false;
      if (!CmpNumberingIdMacAtCleanup(openXmlElement, model.NumberingIdMacAtCleanup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.Numbering CreateOpenXmlElement(DMW.Numbering model)
  {
    var openXmlElement = new DXW.Numbering();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Numbering openXmlElement, DMW.Numbering model)
  {
    SetNumberingPictureBullets(openXmlElement, model?.NumberingPictureBullets);
    SetAbstractNums(openXmlElement, model?.AbstractNums);
    SetNumberingInstances(openXmlElement, model?.NumberingInstances);
    SetNumberingIdMacAtCleanup(openXmlElement, model?.NumberingIdMacAtCleanup);
  }
  #endregion
}
