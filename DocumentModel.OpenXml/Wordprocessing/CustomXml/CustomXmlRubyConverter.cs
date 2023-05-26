namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CustomXmlRuby Class.
/// </summary>
public static class CustomXmlRubyConverter
{
  #region CustomXmlRuby model conversion
  public static DMW.CustomXmlRuby? CreateModelElement(DXW.CustomXmlRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = CustomXmlElementConverter.CreateModelElement<DMW.CustomXmlRuby>(openXmlElement);
      if (model != null)
      {
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          openXmlElement.Where(item => item is not DXW.CustomXmlProperties), model,
          RubyContentConverter.CreateRubyContentModelElement);
        return model;
      }
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CustomXmlRuby? openXmlElement, DMW.CustomXmlRuby? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CustomXmlElementConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        RubyContentConverter.CompareRubyContentElement, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.CustomXmlRuby CreateOpenXmlElement(DMW.CustomXmlRuby model)
  {
    var openXmlElement = new DXW.CustomXmlRuby();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.CustomXmlRuby openXmlElement, DMW.CustomXmlRuby model)
  {
    CustomXmlElementConverter.UpdateOpenXmlElement(openXmlElement, model);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion
}
