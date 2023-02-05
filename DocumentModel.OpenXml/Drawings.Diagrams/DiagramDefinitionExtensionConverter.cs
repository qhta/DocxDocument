namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public static class DiagramDefinitionExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsDgm1.NumberDiagramInfoList? GetNumberDiagramInfoList(DXDrawDgms.DiagramDefinitionExtension openXmlElement)
  {
    return DMXDrawsDgm1.NumberDiagramInfoListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2019DrawDgm11.NumberDiagramInfoList>());
  }
  
  private static bool CmpNumberDiagramInfoList(DXDrawDgms.DiagramDefinitionExtension openXmlElement, DMDrawsDgm1.NumberDiagramInfoList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgm1.NumberDiagramInfoListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2019DrawDgm11.NumberDiagramInfoList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberDiagramInfoList(DXDrawDgms.DiagramDefinitionExtension openXmlElement, DMDrawsDgm1.NumberDiagramInfoList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawDgm11.NumberDiagramInfoList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgm1.NumberDiagramInfoListConverter.CreateOpenXmlElement<DXO2019DrawDgm11.NumberDiagramInfoList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgm2.TextListStyleType? GetTextListStyleType(DXDrawDgms.DiagramDefinitionExtension openXmlElement)
  {
    return DMXDrawsDgm2.TextListStyleTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2019DrawDgm12.TextListStyleType>());
  }
  
  private static bool CmpTextListStyleType(DXDrawDgms.DiagramDefinitionExtension openXmlElement, DMDrawsDgm2.TextListStyleType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgm2.TextListStyleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2019DrawDgm12.TextListStyleType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextListStyleType(DXDrawDgms.DiagramDefinitionExtension openXmlElement, DMDrawsDgm2.TextListStyleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawDgm12.TextListStyleType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgm2.TextListStyleTypeConverter.CreateOpenXmlElement<DXO2019DrawDgm12.TextListStyleType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.DiagramDefinitionExtension? CreateModelElement(DXDrawDgms.DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DiagramDefinitionExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberDiagramInfoList = GetNumberDiagramInfoList(openXmlElement);
      value.TextListStyleType = GetTextListStyleType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.DiagramDefinitionExtension? openXmlElement, DMDrawsDgms.DiagramDefinitionExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpNumberDiagramInfoList(openXmlElement, value.NumberDiagramInfoList, diffs, objName))
        ok = false;
      if (!CmpTextListStyleType(openXmlElement, value.TextListStyleType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramDefinitionExtension? value)
    where OpenXmlElementType: DXDrawDgms.DiagramDefinitionExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNumberDiagramInfoList(openXmlElement, value?.NumberDiagramInfoList);
      SetTextListStyleType(openXmlElement, value?.TextListStyleType);
      return openXmlElement;
    }
    return default;
  }
}
