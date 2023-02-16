namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetRelationshipId(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  private static bool CmpRelationshipId(DXO2010DrawChartDraw.ContentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipId?.Value == value) return true;
    diffs?.Add(objName, "RelationshipId", openXmlElement?.RelationshipId?.Value, value);
    return false;
  }
  
  private static void SetRelationshipId(DXO2010DrawChartDraw.ContentPart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelationshipId = new StringValue { Value = value };
    else
      openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetBlackWhiteMode(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  private static DMDrawsChartDraws.NonVisualContentPartProperties? GetNonVisualContentPartProperties(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.NonVisualContentPartProperties>();
    if (element != null)
      return DMXDrawsChartDraws.NonVisualContentPartPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualContentPartProperties(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.NonVisualContentPartProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NonVisualContentPartPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualContentPartProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualContentPartProperties(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.NonVisualContentPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualContentPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NonVisualContentPartPropertiesConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.NonVisualContentPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? GetApplicationNonVisualDrawingProperties(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraws.ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpApplicationNonVisualDrawingProperties(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ApplicationNonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetApplicationNonVisualDrawingProperties(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ApplicationNonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  private static DMDrawsChartDraws.Transform2D? GetTransform2D(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.Transform2D>();
    if (element != null)
      return DMXDrawsChartDraws.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.Transform2D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTransform2D(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.Transform2DConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.OfficeArtExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDrawsChartDraws.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ContentPart? CreateModelElement(DXO2010DrawChartDraw.ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ContentPart();
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.NonVisualContentPartProperties = GetNonVisualContentPartProperties(openXmlElement);
      value.ApplicationNonVisualDrawingProperties = GetApplicationNonVisualDrawingProperties(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawChartDraw.ContentPart? openXmlElement, DMDrawsChartDraws.ContentPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpNonVisualContentPartProperties(openXmlElement, value.NonVisualContentPartProperties, diffs, objName))
        ok = false;
      if (!CmpApplicationNonVisualDrawingProperties(openXmlElement, value.ApplicationNonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, value.Transform2D, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ContentPart? value)
    where OpenXmlElementType: DXO2010DrawChartDraw.ContentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelationshipId(openXmlElement, value?.RelationshipId);
      SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
      SetNonVisualContentPartProperties(openXmlElement, value?.NonVisualContentPartProperties);
      SetApplicationNonVisualDrawingProperties(openXmlElement, value?.ApplicationNonVisualDrawingProperties);
      SetTransform2D(openXmlElement, value?.Transform2D);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
