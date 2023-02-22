namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public static class ImageLayerConverter
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetEmbed(DXO2010Draw.ImageLayer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO2010Draw.ImageLayer openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO2010Draw.ImageLayer openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDraws.ImageEffect>? GetImageEffects(DXO2010Draw.ImageLayer openXmlElement)
  {
    var collection = new Collection<DMDraws.ImageEffect>();
    foreach (var item in openXmlElement.Elements<DXO2010Draw.ImageEffect>())
    {
      var newItem = DMXDraws.ImageEffectConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpImageEffects(DXO2010Draw.ImageLayer openXmlElement, Collection<DMDraws.ImageEffect>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010Draw.ImageEffect>();
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
        if (!DMXDraws.ImageEffectConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetImageEffects(DXO2010Draw.ImageLayer openXmlElement, Collection<DMDraws.ImageEffect>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010Draw.ImageEffect>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ImageEffectConverter.CreateOpenXmlElement<DXO2010Draw.ImageEffect>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ImageLayer? CreateModelElement(DXO2010Draw.ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageLayer();
      value.Embed = GetEmbed(openXmlElement);
      value.ImageEffects = GetImageEffects(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ImageLayer? openXmlElement, DMDraws.ImageLayer? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName))
        ok = false;
      if (!CmpImageEffects(openXmlElement, value.ImageEffects, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ImageLayer value)
    where OpenXmlElementType: DXO2010Draw.ImageLayer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ImageLayer openXmlElement, DMDraws.ImageLayer value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetImageEffects(openXmlElement, value?.ImageEffects);
    }
  }
