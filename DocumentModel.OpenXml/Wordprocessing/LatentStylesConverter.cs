namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Latent Style Information converter from/to OpenXml.
///</summary>
public static class LatentStylesConverter
{
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  private static Boolean? GetDefaultLockedState(DXW.LatentStyles openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DefaultLockedState);
  }
  
  private static bool CmpDefaultLockedState(DXW.LatentStyles openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DefaultLockedState, value, diffs, objName, "DefaultLockedState");
  }
  
  private static void SetDefaultLockedState(DXW.LatentStyles openXmlElement, Boolean? value)
  {
    openXmlElement.DefaultLockedState = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  private static Int32? GetDefaultUiPriority(DXW.LatentStyles openXmlElement)
  {
    return openXmlElement?.DefaultUiPriority?.Value;
  }
  
  private static bool CmpDefaultUiPriority(DXW.LatentStyles openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DefaultUiPriority?.Value == value) return true;
    diffs?.Add(objName, "DefaultUiPriority", openXmlElement?.DefaultUiPriority?.Value, value);
    return false;
  }
  
  private static void SetDefaultUiPriority(DXW.LatentStyles openXmlElement, Int32? value)
  {
    openXmlElement.DefaultUiPriority = value;
  }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  private static Boolean? GetDefaultSemiHidden(DXW.LatentStyles openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DefaultSemiHidden);
  }
  
  private static bool CmpDefaultSemiHidden(DXW.LatentStyles openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DefaultSemiHidden, value, diffs, objName, "DefaultSemiHidden");
  }
  
  private static void SetDefaultSemiHidden(DXW.LatentStyles openXmlElement, Boolean? value)
  {
    openXmlElement.DefaultSemiHidden = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  private static Boolean? GetDefaultUnhideWhenUsed(DXW.LatentStyles openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DefaultUnhideWhenUsed);
  }
  
  private static bool CmpDefaultUnhideWhenUsed(DXW.LatentStyles openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DefaultUnhideWhenUsed, value, diffs, objName, "DefaultUnhideWhenUsed");
  }
  
  private static void SetDefaultUnhideWhenUsed(DXW.LatentStyles openXmlElement, Boolean? value)
  {
    openXmlElement.DefaultUnhideWhenUsed = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  private static Boolean? GetDefaultPrimaryStyle(DXW.LatentStyles openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DefaultPrimaryStyle);
  }
  
  private static bool CmpDefaultPrimaryStyle(DXW.LatentStyles openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DefaultPrimaryStyle, value, diffs, objName, "DefaultPrimaryStyle");
  }
  
  private static void SetDefaultPrimaryStyle(DXW.LatentStyles openXmlElement, Boolean? value)
  {
    openXmlElement.DefaultPrimaryStyle = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  private static Int32? GetTotalCount(DXW.LatentStyles openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }
  
  private static bool CmpTotalCount(DXW.LatentStyles openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Count?.Value == value) return true;
    diffs?.Add(objName, "Count", openXmlElement?.Count?.Value, value);
    return false;
  }
  
  private static void SetTotalCount(DXW.LatentStyles openXmlElement, Int32? value)
  {
    openXmlElement.Count = value;
  }
  
  private static Collection<DMW.LatentStyleExceptionInfo>? GetItems(DXW.LatentStyles openXmlElement)
  {
    var collection = new Collection<DMW.LatentStyleExceptionInfo>();
    foreach (var item in openXmlElement.Elements<DXW.LatentStyleExceptionInfo>())
    {
      var newItem = DMXW.LatentStyleExceptionInfoConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.LatentStyles openXmlElement, Collection<DMW.LatentStyleExceptionInfo>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.LatentStyleExceptionInfo>();
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
        if (!DMXW.LatentStyleExceptionInfoConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.LatentStyles openXmlElement, Collection<DMW.LatentStyleExceptionInfo>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.LatentStyleExceptionInfo>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LatentStyleExceptionInfoConverter.CreateOpenXmlElement<DXW.LatentStyleExceptionInfo>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.LatentStyles? CreateModelElement(DXW.LatentStyles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LatentStyles();
      value.DefaultLockedState = GetDefaultLockedState(openXmlElement);
      value.DefaultUiPriority = GetDefaultUiPriority(openXmlElement);
      value.DefaultSemiHidden = GetDefaultSemiHidden(openXmlElement);
      value.DefaultUnhideWhenUsed = GetDefaultUnhideWhenUsed(openXmlElement);
      value.DefaultPrimaryStyle = GetDefaultPrimaryStyle(openXmlElement);
      value.TotalCount = GetTotalCount(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LatentStyles? openXmlElement, DMW.LatentStyles? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDefaultLockedState(openXmlElement, value.DefaultLockedState, diffs, objName))
        ok = false;
      if (!CmpDefaultUiPriority(openXmlElement, value.DefaultUiPriority, diffs, objName))
        ok = false;
      if (!CmpDefaultSemiHidden(openXmlElement, value.DefaultSemiHidden, diffs, objName))
        ok = false;
      if (!CmpDefaultUnhideWhenUsed(openXmlElement, value.DefaultUnhideWhenUsed, diffs, objName))
        ok = false;
      if (!CmpDefaultPrimaryStyle(openXmlElement, value.DefaultPrimaryStyle, diffs, objName))
        ok = false;
      if (!CmpTotalCount(openXmlElement, value.TotalCount, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LatentStyles value)
    where OpenXmlElementType: DXW.LatentStyles, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LatentStyles openXmlElement, DMW.LatentStyles value)
  {
    SetDefaultLockedState(openXmlElement, value?.DefaultLockedState);
    SetDefaultUiPriority(openXmlElement, value?.DefaultUiPriority);
    SetDefaultSemiHidden(openXmlElement, value?.DefaultSemiHidden);
    SetDefaultUnhideWhenUsed(openXmlElement, value?.DefaultUnhideWhenUsed);
    SetDefaultPrimaryStyle(openXmlElement, value?.DefaultPrimaryStyle);
    SetTotalCount(openXmlElement, value?.TotalCount);
    SetItems(openXmlElement, value?.Items);
  }
}
