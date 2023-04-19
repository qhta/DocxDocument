using System.Xml.Linq;

using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;

using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Body class conversion methods
/// </summary>
public static class BodyConverter
{
  #region Body elements conversion
  public static DMW.IBodyContent? CreateBodyElement(DX.OpenXmlElement? openXmlElement)
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
    if (openXmlElement is DXW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateModelElement(sectionProperties);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;


    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Body.CreateModelElement method");
    return null;
  }

  public static bool CompareBodyElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.AltChunk altChunk && model is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock stdBlock && model is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(stdBlock, stdBlockModel, diffs, objName);
      if (openXmlElement is DXW.SectionProperties sectionProperties && model is DMW.SectionProperties sectionPropertiesModel)
        return DMXW.SectionPropertiesConverter.CompareModelElement(sectionProperties, sectionPropertiesModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
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
  public static OpenXmlElement CreateOpenXmlElement(DMW.IBodyContent model)
  {
    if (model is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (model is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (model is DMW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateOpenXmlElement(altChunk);
    if (model is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);
    if (model is DMW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(stdBlock);
    if (model is DMW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateOpenXmlElement(sectionProperties);

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (commonMarker != null) return commonMarker;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in BodyConverter.CreateOpenXmlParagraphContent method");
  }
  #endregion

  #region Body conversion
  public static DMW.Body? CreateModelElement(DXW.Body? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Body();
      ElementCollectionConverter<DMW.IBodyContent>.FillModelElementCollection(openXmlElement, model,
        CreateBodyElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Body? openXmlElement, DMW.Body? model, DiffList? diffs, string? objName)
  {
     return ElementCollectionConverter<IBodyContent>.CompareOpenXmlElementCollection
        (openXmlElement, model, CompareBodyElement, diffs, objName);
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
