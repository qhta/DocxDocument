namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Definition.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public static String? GetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  public static void SetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public static String? GetTextLink(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    return openXmlElement?.TextLink?.Value;
  }
  
  public static void SetTextLink(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextLink = new StringValue { Value = value };
      else
        openXmlElement.TextLink = null;
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public static Boolean? GetLockText(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    return openXmlElement?.LockText?.Value;
  }
  
  public static void SetLockText(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockText = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LockText = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public static Boolean? GetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  public static void SetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties? GetNonVisualShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, DocumentModel.Drawings.ChartDrawing.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.Style? GetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, DocumentModel.Drawings.ChartDrawing.Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.TextBody? GetTextBody(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBody(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement, DocumentModel.Drawings.ChartDrawing.TextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.Shape? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Shape();
      value.Macro = GetMacro(openXmlElement);
      value.TextLink = GetTextLink(openXmlElement);
      value.LockText = GetLockText(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualShapeProperties = GetNonVisualShapeProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.Shape? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetTextLink(openXmlElement, value?.TextLink);
      SetLockText(openXmlElement, value?.LockText);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualShapeProperties(openXmlElement, value?.NonVisualShapeProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      SetTextBody(openXmlElement, value?.TextBody);
      return openXmlElement;
    }
    return default;
  }
}
