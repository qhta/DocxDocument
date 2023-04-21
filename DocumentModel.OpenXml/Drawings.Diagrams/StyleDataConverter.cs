namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public static class StyleDataConverter
{
  private static DMDD.DataModel? GetDataModel(DXDD.StyleData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DataModel>();
    if (element != null)
      return DMXDD.DataModelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModel(DXDD.StyleData openXmlElement, DMDD.DataModel? value, DiffList? diffs, string? objName)
  {
    return DMXDD.DataModelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DataModel>(), value, diffs, objName);
  }
  
  private static void SetDataModel(DXDD.StyleData openXmlElement, DMDD.DataModel? value)
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
  
  public static DocumentModel.Drawings.Diagrams.StyleData? CreateModelElement(DXDD.StyleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.StyleData? openXmlElement, DMDD.StyleData? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.StyleData value)
    where OpenXmlElementType: DXDD.StyleData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.StyleData openXmlElement, DMDD.StyleData value)
  {
    SetDataModel(openXmlElement, value?.DataModel);
  }
}
