namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CustomXmlBlock"/> class from/to OpenXml converter.
/// </summary>
public static class CustomXmlBlockConverter
{

  #region CustomXmlBlock content conversion
  public static DM.IModelElement? CreateCustomXmlBlockContent(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);

    if (openXmlElement is DXW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(sdtBlock);

    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);

    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareCustomXmlBlockContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);

      if (openXmlElement is DXW.SdtBlock sdtBlock && model is DMW.SdtBlock sdtBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(sdtBlock, sdtBlockModel, diffs, objName);

      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);

      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result2 = DMXW.CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result2 != null)
          return (bool)result2;
      }

      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlBlockContent(DM.IModelElement model)
  {
    if (model is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);

    if (model is DMW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(sdtBlock);

    if (model is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);

    if (model is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);

    var result2 = DMXW.CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result2 != null) return result2;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlBlockContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.UpdateOpenXmlElement(customXmlBlock, customXmlBlockModel);

      if (openXmlElement is DXW.SdtBlock sdtBlock && model is DMW.SdtBlock sdtBlockModel)
        return DMXW.SdtBlockConverter.UpdateOpenXmlElement(sdtBlock, sdtBlockModel);

      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);

      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);

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
  #endregion

  #region CustomXmlBlock model conversion.
  public static DMW.CustomXmlBlock? CreateModelElement(DXW.CustomXmlBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = CustomXmlElementConverter.CreateModelElement<DMW.CustomXmlBlock>(openXmlElement);
      if (model != null)
      {
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          openXmlElement.Where(item => item is not DXW.CustomXmlProperties), model,
          CreateCustomXmlBlockContent);
        return model;
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CustomXmlBlock? openXmlElement, DMW.CustomXmlBlock? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CustomXmlElementConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareCustomXmlBlockContent, diffs, objName))
        return ok;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.CustomXmlBlock CreateOpenXmlElement(DMW.CustomXmlBlock model)
  {
    var openXmlElement = new DXW.CustomXmlBlock();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.CustomXmlBlock openXmlElement, DMW.CustomXmlBlock model)
  {
    CustomXmlElementConverter.UpdateOpenXmlElement(openXmlElement, model);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareCustomXmlBlockContent,
      UpdateOpenXmlBlockContent,
      CreateOpenXmlBlockContent);
  }
  #endregion
}
