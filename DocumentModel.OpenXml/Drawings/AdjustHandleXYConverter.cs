namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public static class AdjustHandleXYConverter
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  public static String? GetXAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.XAdjustmentGuide?.Value;
  }
  
  public static void SetXAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XAdjustmentGuide = new StringValue { Value = value };
      else
        openXmlElement.XAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  public static String? GetMinX(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MinX?.Value;
  }
  
  public static void SetMinX(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinX = new StringValue { Value = value };
      else
        openXmlElement.MinX = null;
  }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  public static String? GetMaxX(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MaxX?.Value;
  }
  
  public static void SetMaxX(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MaxX = new StringValue { Value = value };
      else
        openXmlElement.MaxX = null;
  }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  public static String? GetYAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.YAdjustmentGuide?.Value;
  }
  
  public static void SetYAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.YAdjustmentGuide = new StringValue { Value = value };
      else
        openXmlElement.YAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  public static String? GetMinY(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MinY?.Value;
  }
  
  public static void SetMinY(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinY = new StringValue { Value = value };
      else
        openXmlElement.MinY = null;
  }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  public static String? GetMaxY(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    return openXmlElement?.MaxY?.Value;
  }
  
  public static void SetMaxY(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MaxY = new StringValue { Value = value };
      else
        openXmlElement.MaxY = null;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public static DocumentModel.Drawings.AdjustPoint2DType? GetPosition(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Position>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement, DocumentModel.Drawings.AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Position>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandleXY? CreateModelElement(DocumentFormat.OpenXml.Drawing.AdjustHandleXY? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleXY();
      value.XAdjustmentGuide = GetXAdjustmentGuide(openXmlElement);
      value.MinX = GetMinX(openXmlElement);
      value.MaxX = GetMaxX(openXmlElement);
      value.YAdjustmentGuide = GetYAdjustmentGuide(openXmlElement);
      value.MinY = GetMinY(openXmlElement);
      value.MaxY = GetMaxY(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustHandleXY? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AdjustHandleXY, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
