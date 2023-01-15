using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using DocumentModel.Drawings;
using ApplicationNonVisualDrawingProperties = DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties;
using NonVisualContentPartProperties = DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties;
using Transform2D = DocumentModel.Drawings.ChartDrawings.Transform2D;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetRelationshipId(ContentPart? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }

  public static void SetRelationshipId(ContentPart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }

  /// <summary>
  ///   bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public static BlackWhiteMode? GetBlackWhiteMode(ContentPart? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackWhiteModeValues, BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }

  public static void SetBlackWhiteMode(ContentPart? openXmlElement, BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackWhiteModeValues, BlackWhiteMode>(value);
  }

  /// <summary>
  ///   NonVisualContentPartProperties.
  /// </summary>
  public static NonVisualContentPartProperties? GetNonVisualContentPartProperties(ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>();
    if (itemElement != null)
      return NonVisualContentPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualContentPartProperties(ContentPart? openXmlElement, NonVisualContentPartProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualContentPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ApplicationNonVisualDrawingProperties.
  /// </summary>
  public static ApplicationNonVisualDrawingProperties? GetApplicationNonVisualDrawingProperties(ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>();
    if (itemElement != null)
      return ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetApplicationNonVisualDrawingProperties(ContentPart? openXmlElement, ApplicationNonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplicationNonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Transform2D.
  /// </summary>
  public static Transform2D? GetTransform2D(ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>();
    if (itemElement != null)
      return Transform2DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTransform2D(ContentPart? openXmlElement, Transform2D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Transform2DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? GetOfficeArtExtensionList(ContentPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(ContentPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ContentPart? CreateModelElement(ContentPart? openXmlElement)
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
    where OpenXmlElementType : ContentPart, new()
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