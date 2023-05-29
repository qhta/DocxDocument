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

  #region TextListStyleType conversion.
  private static DMD.ListStyle? GetTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19DD12.TextListStyleType>();
    if (element != null)
      return DMXD.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement, DMD.ListStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19DD12.TextListStyleType>(), value, diffs, objName, propName);
  }
  
  private static void SetTextListStyleType(DXDD.DiagramDefinitionExtension openXmlElement, DMD.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DD12.TextListStyleType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ListStyleConverter.CreateOpenXmlElement<DXO19DD12.TextListStyleType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DiagramDefinitionExtension model conversion.
  public static DMDD.DiagramDefinitionExtension? CreateModelElement(DXDD.DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDD.DiagramDefinitionExtension();
      model.Uri = GetUri(openXmlElement);
      model.NumberDiagramInfoList = GetNumberDiagramInfoList(openXmlElement);
      model.TextListStyleType = GetTextListStyleType(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.DiagramDefinitionExtension? openXmlElement, DMDD.DiagramDefinitionExtension? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, model.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpNumberDiagramInfoList(openXmlElement, model.NumberDiagramInfoList, diffs, objName, propName))
        ok = false;
      if (!CmpTextListStyleType(openXmlElement, model.TextListStyleType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DiagramDefinitionExtension model)
    where OpenXmlElementType: DXDD.DiagramDefinitionExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DiagramDefinitionExtension openXmlElement, DMDD.DiagramDefinitionExtension model)
  {
    SetUri(openXmlElement, model.Uri);
    SetNumberDiagramInfoList(openXmlElement, model.NumberDiagramInfoList);
    SetTextListStyleType(openXmlElement, model.TextListStyleType);
  }
  #endregion
}
