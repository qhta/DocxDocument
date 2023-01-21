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
  
  private static void SetUri(DXDrawDgms.DiagramDefinitionExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsDgm1.NumberDiagramInfoList? GetNumberDiagramInfoList(DXDrawDgms.DiagramDefinitionExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2019DrawDgm11.NumberDiagramInfoList>();
    if (itemElement != null)
      return DMXDrawsDgm1.NumberDiagramInfoListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2019DrawDgm12.TextListStyleType>();
    if (itemElement != null)
      return DMXDrawsDgm2.TextListStyleTypeConverter.CreateModelElement(itemElement);
    return null;
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
