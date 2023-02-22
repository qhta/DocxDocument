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
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsDgm1.NumberDiagramInfoList? GetNumberDiagramInfoList(DXDrawDgms.DiagramDefinitionExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2019DrawDgm11.NumberDiagramInfoList>();
    if (element != null)
      return DMXDrawsDgm1.NumberDiagramInfoListConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXO2019DrawDgm12.TextListStyleType>();
    if (element != null)
      return DMXDrawsDgm2.TextListStyleTypeConverter.CreateModelElement(element);
    return null;
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
  
  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension? CreateModelElement(DXDrawDgms.DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramDefinitionExtension value)
    where OpenXmlElementType: DXDrawDgms.DiagramDefinitionExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.DiagramDefinitionExtension openXmlElement, DMDrawsDgms.DiagramDefinitionExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNumberDiagramInfoList(openXmlElement, value?.NumberDiagramInfoList);
    SetTextListStyleType(openXmlElement, value?.TextListStyleType);
    }
  }
