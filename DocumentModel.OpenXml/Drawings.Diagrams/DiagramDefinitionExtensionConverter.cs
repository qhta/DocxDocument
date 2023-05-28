namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public static class DiagramDefinitionExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDD.DiagramDefinitionExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDD.DiagramDefinitionExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDD.DiagramDefinitionExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD1.NumberDiagramInfoList? GetNumberDiagramInfoList(DXDD.DiagramDefinitionExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19DD11.NumberDiagramInfoList>();
    if (element != null)
      return DMXDD1.NumberDiagramInfoListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberDiagramInfoList(DXDD.DiagramDefinitionExtension openXmlElement, DMDD1.NumberDiagramInfoList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD1.NumberDiagramInfoListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19DD11.NumberDiagramInfoList>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberDiagramInfoList(DXDD.DiagramDefinitionExtension openXmlElement, DMDD1.NumberDiagramInfoList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DD11.NumberDiagramInfoList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD1.NumberDiagramInfoListConverter.CreateOpenXmlElement<DXO19DD11.NumberDiagramInfoList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD2.TextListStyleType? GetTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19DD12.TextListStyleType>();
    if (element != null)
      return DMXDD2.TextListStyleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement, DMDD2.TextListStyleType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD2.TextListStyleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19DD12.TextListStyleType>(), value, diffs, objName, propName);
  }
  
  private static void SetTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement, DMDD2.TextListStyleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DD12.TextListStyleType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD2.TextListStyleTypeConverter.CreateOpenXmlElement<DXO19DD12.TextListStyleType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.DiagramDefinitionExtension? CreateModelElement(DXDD.DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.DiagramDefinitionExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberDiagramInfoList = GetNumberDiagramInfoList(openXmlElement);
      value.TextListStyleType = GetTextListStyleType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.DiagramDefinitionExtension? openXmlElement, DMDD.DiagramDefinitionExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpNumberDiagramInfoList(openXmlElement, value.NumberDiagramInfoList, diffs, objName, propName))
        ok = false;
      if (!CmpTextListStyleType(openXmlElement, value.TextListStyleType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DiagramDefinitionExtension value)
    where OpenXmlElementType: DXDD.DiagramDefinitionExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DiagramDefinitionExtension openXmlElement, DMDD.DiagramDefinitionExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNumberDiagramInfoList(openXmlElement, value?.NumberDiagramInfoList);
    SetTextListStyleType(openXmlElement, value?.TextListStyleType);
  }
}
