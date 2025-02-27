namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public static class ImageLayerConverter
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetEmbed(DXO10D.ImageLayer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO10D.ImageLayer openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO10D.ImageLayer openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMD.ImageEffect>? GetImageEffects(DXO10D.ImageLayer openXmlElement)
  {
    var collection = new Collection<DMD.ImageEffect>();
    foreach (var item in openXmlElement.Elements<DXO10D.ImageEffect>())
    {
      var newItem = DMXD.ImageEffectConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpImageEffects(DXO10D.ImageLayer openXmlElement, Collection<DMD.ImageEffect>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO10D.ImageEffect>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.ImageEffectConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetImageEffects(DXO10D.ImageLayer openXmlElement, Collection<DMD.ImageEffect>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10D.ImageEffect>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ImageEffectConverter.CreateOpenXmlElement<DXO10D.ImageEffect>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.ImageLayer? CreateModelElement(DXO10D.ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ImageLayer();
      value.Embed = GetEmbed(openXmlElement);
      value.ImageEffects = GetImageEffects(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ImageLayer? openXmlElement, DMD.ImageLayer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName, propName))
        ok = false;
      if (!CmpImageEffects(openXmlElement, value.ImageEffects, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ImageLayer value)
    where OpenXmlElementType: DXO10D.ImageLayer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ImageLayer openXmlElement, DMD.ImageLayer value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetImageEffects(openXmlElement, value?.ImageEffects);
  }
}
