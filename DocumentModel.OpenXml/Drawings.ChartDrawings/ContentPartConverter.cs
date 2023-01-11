namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? GetNonVisualContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualContentPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualContentPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? GetApplicationNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetApplicationNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ApplicationNonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Transform2D? GetTransform2D(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.Transform2DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTransform2D(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.Transform2D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.Transform2DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ContentPart? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ContentPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
