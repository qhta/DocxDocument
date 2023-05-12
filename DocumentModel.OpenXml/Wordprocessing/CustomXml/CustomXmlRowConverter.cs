namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CustomXmlRow"/> class from/to OpenXml converter.
/// </summary>
public static class CustomXmlRowConverter
{

  #region CustomXmlRow content conversion
  public static DM.IModelElement? CreateCustomXmlRowContent(DX.OpenXmlElement openXmlElement, object? data = null)
  {
    if (openXmlElement is DXW.CustomXmlRow CustomXmlRow)
      return DMXW.CustomXmlRowConverter.CreateModelElement(CustomXmlRow);

    if (openXmlElement is DXW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateModelElement(sdtRow);

    if (openXmlElement is DXW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateModelElement(tableRow);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareCustomXmlRowContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlRow CustomXmlRow && model is DMW.CustomXmlRow CustomXmlRowModel)
        return DMXW.CustomXmlRowConverter.CompareModelElement(CustomXmlRow, CustomXmlRowModel, diffs, objName);

      if (openXmlElement is DXW.SdtRow sdtRow && model is DMW.SdtRow sdtRowModel)
        return DMXW.SdtRowConverter.CompareModelElement(sdtRow, sdtRowModel, diffs, objName);

      if (openXmlElement is DXW.TableRow tableRow && model is DMW.TableRow tableRowModel)
        return DMXW.TableRowConverter.CompareModelElement(tableRow, tableRowModel, diffs, objName);

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

  public static OpenXmlElement CreateOpenXmlRowContent(DM.IModelElement model, object? data = null)
  {
    if (model is DMW.CustomXmlRow CustomXmlRow)
      return DMXW.CustomXmlRowConverter.CreateOpenXmlElement(CustomXmlRow);

    if (model is DMW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateOpenXmlElement(sdtRow);

    if (model is DMW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateOpenXmlElement(tableRow);

    var result2 = DMXW.CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result2 != null) return result2;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlRowContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.CustomXmlRow CustomXmlRow && model is DMW.CustomXmlRow CustomXmlRowModel)
        return DMXW.CustomXmlRowConverter.UpdateOpenXmlElement(CustomXmlRow, CustomXmlRowModel);

      if (openXmlElement is DXW.SdtRow sdtRow && model is DMW.SdtRow sdtRowModel)
        return DMXW.SdtRowConverter.UpdateOpenXmlElement(sdtRow, sdtRowModel);

      if (openXmlElement is DXW.TableRow tableRow && model is DMW.TableRow tableRowModel)
        return DMXW.TableRowConverter.UpdateOpenXmlElement(tableRow, tableRowModel);

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

  #region CustomXmlRow model conversion.
  public static DMW.CustomXmlRow? CreateModelElement(DXW.CustomXmlRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = CustomXmlElementConverter.CreateModelElement<DMW.CustomXmlRow>(openXmlElement);
      if (model != null)
      {
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          openXmlElement.Where(item => item is not DXW.CustomXmlProperties), model,
          CreateCustomXmlRowContent);
        return model;
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CustomXmlRow? openXmlElement, DMW.CustomXmlRow? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CustomXmlElementConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareCustomXmlRowContent, diffs, objName))
        return ok;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.CustomXmlRow CreateOpenXmlElement(DMW.CustomXmlRow model)
  {
    var openXmlElement = new DXW.CustomXmlRow();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.CustomXmlRow openXmlElement, DMW.CustomXmlRow model)
  {
    CustomXmlElementConverter.UpdateOpenXmlElement(openXmlElement, model);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareCustomXmlRowContent,
      UpdateOpenXmlRowContent,
      CreateOpenXmlRowContent);
  }
  #endregion
}
