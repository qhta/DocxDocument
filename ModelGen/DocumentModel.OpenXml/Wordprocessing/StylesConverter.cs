namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public static class StylesConverter
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  private static DMW.DocDefaults? GetDocDefaults(DXW.Styles openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocDefaults>();
    if (element != null)
      return DMXW.DocDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocDefaults(DXW.Styles openXmlElement, DMW.DocDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocDefaults(DXW.Styles openXmlElement, DMW.DocDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocDefaultsConverter.CreateOpenXmlElement<DXW.DocDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  private static DMW.LatentStyles? GetLatentStyles(DXW.Styles openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LatentStyles>();
    if (element != null)
      return DMXW.LatentStylesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLatentStyles(DXW.Styles openXmlElement, DMW.LatentStyles? value, DiffList? diffs, string? objName)
  {
    return DMXW.LatentStylesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LatentStyles>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLatentStyles(DXW.Styles openXmlElement, DMW.LatentStyles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LatentStyles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LatentStylesConverter.CreateOpenXmlElement<DXW.LatentStyles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.Style>? GetItems(DXW.Styles openXmlElement)
  {
    var collection = new Collection<DMW.Style>();
    foreach (var item in openXmlElement.Elements<DXW.Style>())
    {
      var newItem = DMXW.StyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.Styles openXmlElement, Collection<DMW.Style>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Style>();
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
        if (!DMXW.StyleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Styles openXmlElement, Collection<DMW.Style>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Style>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.StyleConverter.CreateOpenXmlElement<DXW.Style>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Styles? CreateModelElement(DXW.Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Styles();
      value.DocDefaults = GetDocDefaults(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Styles? openXmlElement, DMW.Styles? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocDefaults(openXmlElement, value.DocDefaults, diffs, objName))
        ok = false;
      if (!CmpLatentStyles(openXmlElement, value.LatentStyles, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Styles value)
    where OpenXmlElementType: DXW.Styles, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Styles openXmlElement, DMW.Styles value)
  {
    SetDocDefaults(openXmlElement, value?.DocDefaults);
    SetLatentStyles(openXmlElement, value?.LatentStyles);
    SetItems(openXmlElement, value?.Items);
  }
}
