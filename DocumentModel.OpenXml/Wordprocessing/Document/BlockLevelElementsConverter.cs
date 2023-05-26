namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Block-level elements from/to OpenXml converter.
/// </summary>
public static class BlockLevelElementsConverter
{
  public static DMW.IStoryContent? CreateBlockLevelElement(DX.OpenXmlElement? openXmlElement)
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


    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Body.CreateModelElement method");
    return null;
  }

  public static bool CompareBlockLevelElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName, propName);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName, propName);
      if (openXmlElement is DXW.AltChunk altChunk && model is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName, propName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName, propName);
      if (openXmlElement is DXW.SdtBlock stdBlock && model is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(stdBlock, stdBlockModel, diffs, objName, propName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName, propName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {

      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
      if (openXmlElement is DXW.AltChunk altChunk && model is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.UpdateOpenXmlElement(altChunk, altChunkModel);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.UpdateOpenXmlElement(customXmlBlock, customXmlBlockModel);
      if (openXmlElement is DXW.SdtBlock stdBlock && model is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.UpdateOpenXmlElement(stdBlock, stdBlockModel);


      if (model is DMW.ICommonContent commonElementModel)
      {
        var result2 = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result2 != null)
          return (bool)result2;
      }

      return true;
    }
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DM.IModelElement model)
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

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (commonMarker != null) return commonMarker;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in BodyConverter.CreateOpenXmlParagraphContent method");
  }
}
