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
    return DMXW.DocDefaultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocDefaults>());
  }
  
  private static bool CmpDocDefaults(DXW.Styles openXmlElement, DMW.DocDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocDefaults>(), value, diffs, objName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  private static DMW.LatentStyles? GetLatentStyles(DXW.Styles openXmlElement)
  {
    return DMXW.LatentStylesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.LatentStyles>());
  }
  
  private static bool CmpLatentStyles(DXW.Styles openXmlElement, DMW.LatentStyles? value, DiffList? diffs, string? objName)
  {
    return DMXW.LatentStylesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LatentStyles>(), value, diffs, objName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.DefinedStyles GetItems(DXW.Styles openXmlElement)
  {
    var collection = new DMW.DefinedStyles();
    foreach (var item in openXmlElement.Elements<DXW.Style>())
    {
      var newItem = DMXW.StyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.Styles openXmlElement, DMW.DefinedStyles? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.Style>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count;
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelStyles = value.ToArray();
      var origStyles = origElements.ToArray();
      for (int i = 0; i<System.Math.Min(modelStyles.Length, origStyles.Length); i++)
      {
        var modelStyle = modelStyles[i];
        var origStyle = origStyles[i];
        if (!DMXW.StyleConverter.CompareModelElement(origStyle, modelStyle, diffs, $"Style[{i}]"))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Styles openXmlElement, DMW.DefinedStyles? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Style>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.StyleConverter.CreateOpenXmlElement<DXW.Style>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.Styles? CreateModelElement(DXW.Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Styles();
      value.DocDefaults = GetDocDefaults(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.DefinedStyles = GetItems(openXmlElement);
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
      if (!CmpItems(openXmlElement, value.DefinedStyles, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.Styles? CreateOpenXmlElement(DMW.Styles? value)
  {
    if (value != null)
    {
      var openXmlElement = new DXW.Styles();
      SetDocDefaults(openXmlElement, value?.DocDefaults);
      SetLatentStyles(openXmlElement, value?.LatentStyles);
      SetItems(openXmlElement, value?.DefinedStyles);
      return openXmlElement;
    }
    return default;
  }
}
