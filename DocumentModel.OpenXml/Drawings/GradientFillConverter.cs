namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  public static DocumentModel.Drawings.TileFlipKind? GetFlip(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  public static void SetFlip(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.TileFlipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public static DocumentModel.Drawings.GradientStopList? GetGradientStopList(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientStopListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGradientStopList(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.GradientStopList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GradientStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientStopList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LinearGradientFill? GetLinearGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LinearGradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLinearGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.LinearGradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LinearGradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinearGradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PathGradientFill? GetPathGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PathGradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPathGradientFill(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.PathGradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PathGradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PathGradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.RelativeRectangleType? GetTileRectangle(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TileRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTileRectangle(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TileRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TileRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.GradientFill? CreateModelElement(DocumentFormat.OpenXml.Drawing.GradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientFill();
      value.Flip = GetFlip(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearGradientFill = GetLinearGradientFill(openXmlElement);
      value.PathGradientFill = GetPathGradientFill(openXmlElement);
      value.TileRectangle = GetTileRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GradientFill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.GradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFlip(openXmlElement, value?.Flip);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      return openXmlElement;
    }
    return default;
  }
}
