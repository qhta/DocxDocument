namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public static class AdjustHandlePolarConverter
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  private static String? GetRadialAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.RadialAdjustmentGuide?.Value;
  }
  
  private static void SetRadialAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RadialAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.RadialAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  private static String? GetMinRadial(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MinRadial?.Value;
  }
  
  private static void SetMinRadial(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinRadial = new StringValue { Value = value };
    else
      openXmlElement.MinRadial = null;
  }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  private static String? GetMaxRadial(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MaxRadial?.Value;
  }
  
  private static void SetMaxRadial(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxRadial = new StringValue { Value = value };
    else
      openXmlElement.MaxRadial = null;
  }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  private static String? GetAngleAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.AngleAdjustmentGuide?.Value;
  }
  
  private static void SetAngleAdjustmentGuide(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AngleAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.AngleAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  private static String? GetMinAngle(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MinAngle?.Value;
  }
  
  private static void SetMinAngle(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinAngle = new StringValue { Value = value };
    else
      openXmlElement.MinAngle = null;
  }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  private static String? GetMaxAngle(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MaxAngle?.Value;
  }
  
  private static void SetMaxAngle(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxAngle = new StringValue { Value = value };
    else
      openXmlElement.MaxAngle = null;
  }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  private static DocumentModel.Drawings.AdjustPoint2DType? GetPosition(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Position>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement, DocumentModel.Drawings.AdjustPoint2DType? value)
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
  
  public static DocumentModel.Drawings.AdjustHandlePolar? CreateModelElement(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandlePolar();
      value.RadialAdjustmentGuide = GetRadialAdjustmentGuide(openXmlElement);
      value.MinRadial = GetMinRadial(openXmlElement);
      value.MaxRadial = GetMaxRadial(openXmlElement);
      value.AngleAdjustmentGuide = GetAngleAdjustmentGuide(openXmlElement);
      value.MinAngle = GetMinAngle(openXmlElement);
      value.MaxAngle = GetMaxAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustHandlePolar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AdjustHandlePolar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadialAdjustmentGuide(openXmlElement, value?.RadialAdjustmentGuide);
      SetMinRadial(openXmlElement, value?.MinRadial);
      SetMaxRadial(openXmlElement, value?.MaxRadial);
      SetAngleAdjustmentGuide(openXmlElement, value?.AngleAdjustmentGuide);
      SetMinAngle(openXmlElement, value?.MinAngle);
      SetMaxAngle(openXmlElement, value?.MaxAngle);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
