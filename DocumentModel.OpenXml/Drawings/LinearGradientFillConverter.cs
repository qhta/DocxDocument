namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public static class LinearGradientFillConverter
{
  /// <summary>
  /// Angle
  /// </summary>
  private static Int32? GetAngle(DocumentFormat.OpenXml.Drawing.LinearGradientFill openXmlElement)
  {
    return openXmlElement.Angle?.Value;
  }
  
  private static void SetAngle(DocumentFormat.OpenXml.Drawing.LinearGradientFill openXmlElement, Int32? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  private static Boolean? GetScaled(DocumentFormat.OpenXml.Drawing.LinearGradientFill openXmlElement)
  {
    return openXmlElement?.Scaled?.Value;
  }
  
  private static void SetScaled(DocumentFormat.OpenXml.Drawing.LinearGradientFill openXmlElement, Boolean? value)
  {
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
