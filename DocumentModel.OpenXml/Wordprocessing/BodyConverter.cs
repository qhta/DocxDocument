using System.Xml.Linq;

using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;

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
    if (openXmlElement is DXW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateModelElement(altChunk);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);
    if (openXmlElement is DXW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(stdBlock);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement is DXW.SectionProperties sectionProperties)
    {
      var section = new DMW.Section();
      section.Properties = DMXW.SectionPropertiesConverter.CreateModelElement(sectionProperties);
      return section;
    }

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Body.CreateModelElement method");
    return null;
  }

  public static bool CompareBodyElement(DX.OpenXmlElement? openXmlElement, DMW.IBodyElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.SectionProperties sectionProperties && model is DMW.SectionProperties sectionPropertiesModel)
        return DMXW.SectionPropertiesConverter.CompareModelElement(sectionProperties, sectionPropertiesModel, diffs, objName);
      if (openXmlElement is DXW.AltChunk altChunk && model is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock stdBlock && model is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(stdBlock, stdBlockModel, diffs, objName);

      if (model is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  public static OpenXmlElement CreateOpenXmlElement(DMW.IBodyElement model)
  {
    if (model is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (model is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (model is DMW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateOpenXmlElement(sectionProperties);
    if (model is DMW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateOpenXmlElement(altChunk);
    if (model is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);
    if (model is DMW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(stdBlock);

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonElement);
    if (commonMarker != null) return commonMarker;

    throw new InvalidOperationException($"Value of type \"{model.GetType()}\" not supported in BodyConverter.CreateOpenXmlParagraphElement method");
  }
  #endregion

  #region Body conversion
  public static DMW.Body? CreateModelElement(DXW.Body? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Body();
      var elements = openXmlElement.Elements();
      foreach (var element in elements)
      {
        var modelBodyElement = CreateBodyElement(element);
        if (modelBodyElement is DMW.Section section)
        {
          var bodyElements = model.ToArray();
          var sectionIndex = -1;
          for (int i = bodyElements.Count() - 1; i >= 0; i--)
            if (bodyElements[i] is DMW.Section)
            {
              sectionIndex = i;
              break;
            }
          for (int i = sectionIndex + 1; i < bodyElements.Count(); i++)
            section.Add(bodyElements[i]);
          for (int i = bodyElements.Count() - 1; i > sectionIndex; i--)
            model.RemoveAt(i);
          model.Add(section);
          break;
        }
        else
        if (modelBodyElement is DMW.Paragraph paragraph && paragraph.ParagraphProperties?.SectionProperties != null)
        {
          section = new DMW.Section();
          section.Properties = paragraph.ParagraphProperties.SectionProperties;
          paragraph.ParagraphProperties.SectionProperties = null;
          var bodyElements = model.ToArray();
          var sectionIndex = -1;
          for (int i = bodyElements.Count() - 1; i >= 0; i--)
            if (bodyElements[i] is DMW.Section)
            {
              sectionIndex = i;
              break;
            }
          for (int i = sectionIndex + 1; i < bodyElements.Count(); i++)
            section.Add(bodyElements[i]);
          for (int i = bodyElements.Count() - 1; i > sectionIndex; i--)
            model.RemoveAt(i);
          model.Add(section);
          section.Add(paragraph);
        }
        else
        {
          if (modelBodyElement != null)
            model.Add(modelBodyElement);
        }
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Body? openXmlElement, DMW.Body? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      var modelEnumerator = model.GetEnumerator();
      var openXmlEnumerator = openXmlElement.GetEnumerator();
      int elementIndex = 0;
      int sectionIndex = 0;
      DMW.Section? lastSection = null;
      while (modelEnumerator.MoveNext() && openXmlEnumerator.MoveNext())
      {
        lastSection = modelEnumerator.Current as DMW.Section;
        if (modelEnumerator.Current is DMW.Section section)
        {
          var sectionEnumerator = section.GetEnumerator();
          if (sectionEnumerator.MoveNext())
          {
            do
            {
              var sectionItem = sectionEnumerator.Current;
              var openXmlItem = openXmlEnumerator.Current;
              if (openXmlItem is DXW.Paragraph paragraph && paragraph.Descendants<DXW.SectionProperties>().Any()
                && sectionItem is DMW.Paragraph paragraphModel && paragraphModel.ParagraphProperties != null)
              {
                paragraphModel.ParagraphProperties.SectionProperties = section.Properties;
                if (!ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName))
                  ok = false;
                paragraphModel.ParagraphProperties.SectionProperties = null;
              }
              else
              if (!CompareBodyElement(openXmlItem, sectionItem, diffs, $"Section[{sectionIndex}].Element[{elementIndex}]"))
                ok = false;
              elementIndex++;
            } while (sectionEnumerator.MoveNext() && openXmlEnumerator.MoveNext());
          }
        }
        else
        {
          var modelItem = modelEnumerator.Current;
          var openXmlItem = openXmlEnumerator.Current;
          if (!CompareBodyElement(openXmlItem, modelItem, diffs, $"Element[{elementIndex}]"))
            ok = false;
          elementIndex++;
        }
      }
      openXmlEnumerator.MoveNext();
      var lastSectionProperties = openXmlEnumerator.Current as DXW.SectionProperties;
      if (lastSectionProperties != null)
      {
        if (!SectionPropertiesConverter.CompareModelElement(lastSectionProperties,
          lastSection?.Properties, diffs, $"Section[{sectionIndex}].Element[{elementIndex}]"))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
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
