namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CustomXmlRun"/> class from/to OpenXml converter.
/// </summary>
public static class CustomXmlRunConverter
{
  #region CustomXmlRun model conversion.
  public static DMW.CustomXmlRun? CreateModelElement(DXW.CustomXmlRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = CustomXmlElementConverter.CreateModelElement<DMW.CustomXmlRun>(openXmlElement);
      if (model != null)
      {
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          openXmlElement.Where(item => item is not DXW.CustomXmlProperties), model,
          ParagraphContentConverter.CreateParagraphContent);
        return model;
      }
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CustomXmlRun? openXmlElement, DMW.CustomXmlRun? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CustomXmlElementConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        ParagraphContentConverter.CompareParagraphContent, diffs, objName))
        return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.CustomXmlRun CreateOpenXmlElement(DMW.CustomXmlRun model)
  {
    var openXmlElement = new DXW.CustomXmlRun();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.CustomXmlRun openXmlElement, DMW.CustomXmlRun model)
  {
    CustomXmlElementConverter.UpdateOpenXmlElement(openXmlElement, model);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      ParagraphContentConverter.CompareParagraphContent,
      ParagraphContentConverter.UpdateOpenXmlParagraphContent,
      ParagraphContentConverter.CreateOpenXmlParagraphContent);
  }
  #endregion
}
