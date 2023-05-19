namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static DMW.TabStop? GetTabStop(DXW.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
      return DMXW.TabStopConverter.CreateModelElement(openXmlElement);
    return null;
  }

  private static bool CmpTabStop(DXW.TabStop openXmlElement, DMW.TabStop value, DiffList? diffs, string? objName)
  {
    return DMXW.TabStopConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }

  private static DXW.TabStop CreateTabStop(DMW.TabStop value)
  {
    return DMXW.TabStopConverter.CreateOpenXmlElement(value);
  }

  private static bool UpdateTabStop(DXW.TabStop openXmlElement, DMW.TabStop value)
  {
    return DMXW.TabStopConverter.UpdateOpenXmlElement(openXmlElement, value);
  }

  public static DMW.Tabs? CreateModelElement(DXW.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Tabs();
      ElementCollectionConverter2<DXW.TabStop, DMW.TabStop>.FillModelElementCollection(
        openXmlElement.Elements<DXW.TabStop>(),
        model, GetTabStop);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Tabs? openXmlElement, DMW.Tabs? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter2<DXW.TabStop, DMW.TabStop>.CompareOpenXmlElementCollection(
        openXmlElement.Elements<DXW.TabStop>(),
        model,
        CmpTabStop,
        diffs, objName))
         ok = false; 
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Tabs model)
    where OpenXmlElementType : DXW.Tabs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Tabs openXmlElement, DMW.Tabs model)
  {
    return ElementCollectionConverter2<DXW.TabStop, DMW.TabStop>.UpdateOpenXmlElementCollection(
      openXmlElement, model,
      CmpTabStop,
      UpdateTabStop,
      CreateTabStop
      );
  }
}
