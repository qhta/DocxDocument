namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.OfficeMath"/> class from/to OpenXml converter.
/// </summary>
public static class OfficeMathConverter
{

  #region OfficeMath content conversion
  public static DM.IModelElement? CreateOfficeMathContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXM.Run run)
      return DMXM.RunConverter.CreateModelElement(run);
    return DMXW.ParagraphContentConverter.CreateParagraphContent(openXmlElement);
  }

  public static bool CompareOfficeMathContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.CompareModelElement(run, runModel, diffs, objName);
    }
    return DMXW.ParagraphContentConverter.CompareParagraphContent(openXmlElement, model, diffs);
  }

  public static OpenXmlElement CreateOpenXmlOfficeMathContent(DM.IModelElement model)
  {
    if (model is DMM.Run run)
      return DMXM.RunConverter.CreateOpenXmlElement(run);
    return DMXW.ParagraphContentConverter.CreateOpenXmlParagraphContent(model);
  }

  public static bool UpdateOpenXmlOfficeMathContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.UpdateOpenXmlElement(run, runModel);
    }
    return DMXW.ParagraphContentConverter.UpdateOpenXmlParagraphContent(openXmlElement, model);
  }
  #endregion

  #region OfficeMath model conversion.
  public static DMM.OfficeMath? CreateModelElement(DXM.OfficeMath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.OfficeMath();
      ElementCollectionConverter<DMM.IOfficeMathContent>.FillModelElementCollection(
        openXmlElement, model, CreateOfficeMathContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.OfficeMath? openXmlElement, DMM.OfficeMath? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMM.IOfficeMathContent>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareOfficeMathContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.OfficeMath CreateOpenXmlElement(DMM.OfficeMath model)
  {
    var openXmlElement = new DXM.OfficeMath();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.OfficeMath openXmlElement, DMM.OfficeMath model)
  {
    return ElementCollectionConverter<DMM.IOfficeMathContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareOfficeMathContent, UpdateOpenXmlOfficeMathContent, CreateOpenXmlOfficeMathContent);
  }
  #endregion
}
