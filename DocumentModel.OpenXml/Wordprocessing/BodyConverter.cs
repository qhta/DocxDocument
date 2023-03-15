namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Body class conversion methods
/// </summary>
public static class BodyConverter
{
  #region Body elements conversion
  public static DMW.IBodyElement? CreateBodyElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateModelElement(sectionProperties);
    if (openXmlElement is DXW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateModelElement(altChunk);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);
    if (openXmlElement is DXW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(stdBlock);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Body.CreateModelElement method");
    return null;
  }

  public static bool CompareBodyElement(DX.OpenXmlElement? openXmlElement, DMW.IBodyElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && value is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && value is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.SectionProperties sectionProperties && value is DMW.SectionProperties sectionPropertiesModel)
        return DMXW.SectionPropertiesConverter.CompareModelElement(sectionProperties, sectionPropertiesModel, diffs, objName);
      if (openXmlElement is DXW.AltChunk altChunk && value is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && value is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock stdBlock && value is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(stdBlock, stdBlockModel, diffs, objName);

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;

    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  public static OpenXmlElement CreateOpenXmlElement(DMW.IBodyElement value)
  {
    if (value is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (value is DMW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateOpenXmlElement(sectionProperties);
    if (value is DMW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateOpenXmlElement(altChunk);
    if (value is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);
    if (value is DMW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(stdBlock);
    
    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (commonMarker != null) return commonMarker;

    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in BodyConverter.CreateOpenXmlParagraphElement method");
  }
  #endregion

  #region Body conversion
  public static DMW.Body? CreateModelElement(DXW.Body? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Body();
      var elements = openXmlElement.Elements();
      foreach (var element in elements)
      {
        var item = CreateBodyElement(element);
        if (item != null)
          value.Add(item);
        if (element is DXW.SectionProperties)
          break;
      }
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Body? openXmlElement, DMW.Body? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      var bodyItems = value.ToArray();
      var elements = openXmlElement.Elements().ToArray();
      for (int i = 0; i < System.Math.Min(bodyItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = bodyItems[i];
        if (!CompareBodyElement(element, item, diffs, objName))
          ok = false;
      }
      if (elements.Count() != bodyItems.Count())
      {
        diffs?.Add(objName, "Body.Count", elements.Count(), bodyItems.Count());
        ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.Body CreateOpenXmlElement(DMW.Body value)
  {
    var openXmlElement = new DXW.Body();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Body openXmlElement, DMW.Body value)
  {
    var bodyItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < bodyItems.Count(); i++)
    {
      var item = bodyItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
  }
  #endregion
}
