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
  
  private static void SetBlackWhiteMode(DXO2010DrawChartDraw.ContentPart openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  private static DMDrawsChartDraws.NonVisualContentPartProperties? GetNonVisualContentPartProperties(DXO2010DrawChartDraw.ContentPart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.NonVisualContentPartProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.NonVisualContentPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.Transform2D>();
    if (itemElement != null)
      return DMXDrawsChartDraws.Transform2DConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraws.ContentPart? CreateModelElement(DXO2010DrawChartDraw.ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ContentPart();
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
