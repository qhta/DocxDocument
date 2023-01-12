namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public static class LinearGradientFillConverter
{
  /// <summary>
  /// Angle
  /// </summary>
  public static Int32? GetAngle(DocumentFormat.OpenXml.Drawing.LinearGradientFill? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Drawing.LinearGradientFill? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public static Boolean? GetScaled(DocumentFormat.OpenXml.Drawing.LinearGradientFill? openXmlElement)
  {
    return openXmlElement?.Scaled?.Value;
  }
  
  public static void SetScaled(DocumentFormat.OpenXml.Drawing.LinearGradientFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Scaled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Scaled = null;
  }
  
  public static DocumentModel.Drawings.LinearGradientFill? CreateModelElement(DocumentFormat.OpenXml.Drawing.LinearGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinearGradientFill();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinearGradientFill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LinearGradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetScaled(openXmlElement, value?.Scaled);
      return openXmlElement;
    }
    return default;
  }
}
