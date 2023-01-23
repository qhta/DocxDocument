namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public static class NumberDiagramInfoListConverter
{
  private static Collection<DMDrawsDgm1.NumberDiagramInfo> GetNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgm1.NumberDiagramInfo>();
    foreach (var item in openXmlElement.Elements<DXO2019DrawDgm11.NumberDiagramInfo>())
    {
      var newItem = DMXDrawsDgm1.NumberDiagramInfoConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement, Collection<DMDrawsDgm1.NumberDiagramInfo>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement, Collection<DMDrawsDgm1.NumberDiagramInfo>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2019DrawDgm11.NumberDiagramInfo>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgm1.NumberDiagramInfoConverter.CreateOpenXmlElement<DXO2019DrawDgm11.NumberDiagramInfo>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgm1.NumberDiagramInfoList? CreateModelElement(DXO2019DrawDgm11.NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgm1.NumberDiagramInfoList();
      value.NumberDiagramInfos = GetNumberDiagramInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019DrawDgm11.NumberDiagramInfoList? openXmlElement, DMDrawsDgm1.NumberDiagramInfoList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberDiagramInfos(openXmlElement, value.NumberDiagramInfos, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm1.NumberDiagramInfoList? value)
    where OpenXmlElementType: DXO2019DrawDgm11.NumberDiagramInfoList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberDiagramInfos(openXmlElement, value?.NumberDiagramInfos);
      return openXmlElement;
    }
    return default;
  }
}
