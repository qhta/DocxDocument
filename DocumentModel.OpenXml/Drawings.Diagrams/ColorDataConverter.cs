namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
public static class ColorDataConverter
{
  private static DMDD.DataModel? GetDataModel(DXDD.ColorData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DataModel>();
    if (element != null)
      return DMXDD.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDD.ColorData openXmlElement, DMDD.DataModel? value, DiffList? diffs, string? objName)
  {
    return DMXDD.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DataModel>(), value, diffs, objName);
  }
  
  private static void SetDataModel(DXDD.ColorData openXmlElement, DMDD.DataModel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DataModel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DataModelConverter.CreateOpenXmlElement<DXDD.DataModel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorData? CreateModelElement(DXDD.ColorData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ColorData? openXmlElement, DMDD.ColorData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataModel(openXmlElement, value.DataModel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorData value)
    where OpenXmlElementType: DXDD.ColorData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorData openXmlElement, DMDD.ColorData value)
  {
    SetDataModel(openXmlElement, value?.DataModel);
  }
}
