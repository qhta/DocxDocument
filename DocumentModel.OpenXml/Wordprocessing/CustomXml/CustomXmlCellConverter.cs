namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CustomXmlCell"/> class from/to OpenXml converter.
/// </summary>
public static class CustomXmlCellConverter
{

  #region CustomXmlCell content conversion
  public static DM.IModelElement? CreateCustomXmlCellContent(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.CustomXmlCell CustomXmlCell)
      return DMXW.CustomXmlCellConverter.CreateModelElement(CustomXmlCell);

    if (openXmlElement is DXW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateModelElement(sdtCell);

    if (openXmlElement is DXW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateModelElement(tableCell);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareCustomXmlCellContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlCell CustomXmlCell && model is DMW.CustomXmlCell CustomXmlCellModel)
        return DMXW.CustomXmlCellConverter.CompareModelElement(CustomXmlCell, CustomXmlCellModel, diffs, objName);

      if (openXmlElement is DXW.SdtCell sdtCell && model is DMW.SdtCell sdtCellModel)
        return DMXW.SdtCellConverter.CompareModelElement(sdtCell, sdtCellModel, diffs, objName);

      if (openXmlElement is DXW.TableCell tableCell && model is DMW.TableCell tableCellModel)
        return DMXW.TableCellConverter.CompareModelElement(tableCell, tableCellModel, diffs, objName);

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

  public static OpenXmlElement CreateOpenXmlCellContent(DM.IModelElement model)
  {
    if (model is DMW.CustomXmlCell CustomXmlCell)
      return DMXW.CustomXmlCellConverter.CreateOpenXmlElement(CustomXmlCell);

    if (model is DMW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateOpenXmlElement(sdtCell);

    if (model is DMW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateOpenXmlElement(tableCell);

    var result2 = DMXW.CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result2 != null) return result2;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlCellContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlCell CustomXmlCell && model is DMW.CustomXmlCell CustomXmlCellModel)
        return DMXW.CustomXmlCellConverter.UpdateOpenXmlElement(CustomXmlCell, CustomXmlCellModel);

      if (openXmlElement is DXW.SdtCell sdtCell && model is DMW.SdtCell sdtCellModel)
        return DMXW.SdtCellConverter.UpdateOpenXmlElement(sdtCell, sdtCellModel);

      if (openXmlElement is DXW.TableCell tableCell && model is DMW.TableCell tableCellModel)
        return DMXW.TableCellConverter.UpdateOpenXmlElement(tableCell, tableCellModel);

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

  #region CustomXmlCell model conversion.
  public static DMW.CustomXmlCell? CreateModelElement(DXW.CustomXmlCell? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = CustomXmlElementConverter.CreateModelElement<DMW.CustomXmlCell>(openXmlElement);
      if (model != null)
      {
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          openXmlElement.Where(item => item is not DXW.CustomXmlProperties), model,
          CreateCustomXmlCellContent);
        return model;
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CustomXmlCell? openXmlElement, DMW.CustomXmlCell? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CustomXmlElementConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareCustomXmlCellContent, diffs, objName))
        return ok;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.CustomXmlCell CreateOpenXmlElement(DMW.CustomXmlCell model)
  {
    var openXmlElement = new DXW.CustomXmlCell();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.CustomXmlCell openXmlElement, DMW.CustomXmlCell model)
  {
    CustomXmlElementConverter.UpdateOpenXmlElement(openXmlElement, model);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareCustomXmlCellContent,
      UpdateOpenXmlCellContent,
      CreateOpenXmlCellContent);
  }
  #endregion
}
