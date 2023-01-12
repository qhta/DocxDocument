namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public static String? GetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  public static void SetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public static Boolean? GetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  public static void SetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties? GetNonVisualPictureProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualPicturePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualPictureProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualPicturePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, DocumentModel.Drawings.ChartDrawing.BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, DocumentModel.Drawings.ChartDrawing.ShapeProperties? value)
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
  /// Style.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.Style? GetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement, DocumentModel.Drawings.ChartDrawing.Style? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.Picture? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Picture();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualPictureProperties = GetNonVisualPictureProperties(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.Picture? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualPictureProperties(openXmlElement, value?.NonVisualPictureProperties);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      return openXmlElement;
    }
    return default;
  }
}
