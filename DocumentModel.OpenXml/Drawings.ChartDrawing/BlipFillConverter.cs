namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Picture Fill.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  public static UInt32? GetDpi(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    return openXmlElement?.Dpi?.Value;
  }
  
  public static void SetDpi(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dpi = value;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public static DocumentModel.Drawings.Blip? GetBlip(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlip(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, DocumentModel.Drawings.Blip? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blip>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public static DocumentModel.Drawings.RelativeRectangleType? GetSourceRectangle(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSourceRectangle(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Tile? GetTile(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTile(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, DocumentModel.Drawings.Tile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Tile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Stretch? GetStretch(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.StretchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStretch(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement, DocumentModel.Drawings.Stretch? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.StretchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Stretch>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.BlipFill? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.BlipFill();
      value.Dpi = GetDpi(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.SourceRectangle = GetSourceRectangle(openXmlElement);
      value.Tile = GetTile(openXmlElement);
      value.Stretch = GetStretch(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.BlipFill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDpi(openXmlElement, value?.Dpi);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetBlip(openXmlElement, value?.Blip);
      SetSourceRectangle(openXmlElement, value?.SourceRectangle);
      SetTile(openXmlElement, value?.Tile);
      SetStretch(openXmlElement, value?.Stretch);
      return openXmlElement;
    }
    return default;
  }
}
