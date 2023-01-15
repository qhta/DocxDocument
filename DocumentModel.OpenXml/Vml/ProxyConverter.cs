using DocumentFormat.OpenXml.Vml.Office;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Reference.
/// </summary>
public static class ProxyConverter
{
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  public static Boolean? GetStart(Proxy? openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }

  public static void SetStart(Proxy? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Start = value;
      else
        openXmlElement.Start = null;
  }

  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  public static Boolean? GetEnd(Proxy? openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }

  public static void SetEnd(Proxy? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.End = value;
      else
        openXmlElement.End = null;
  }

  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  public static String? GetShapeReference(Proxy? openXmlElement)
  {
    return openXmlElement?.ShapeReference?.Value;
  }

  public static void SetShapeReference(Proxy? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeReference = new StringValue { Value = value };
      else
        openXmlElement.ShapeReference = null;
  }

  /// <summary>
  ///   Connection Location
  /// </summary>
  public static Int32? GetConnectionLocation(Proxy? openXmlElement)
  {
    return openXmlElement?.ConnectionLocation?.Value;
  }

  public static void SetConnectionLocation(Proxy? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectionLocation = value;
  }

  public static DocumentModel.Vml.Proxy? CreateModelElement(Proxy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Proxy();
      value.Start = GetStart(openXmlElement);
      value.End = GetEnd(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.ConnectionLocation = GetConnectionLocation(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Proxy? value)
    where OpenXmlElementType : Proxy, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStart(openXmlElement, value?.Start);
      SetEnd(openXmlElement, value?.End);
      SetShapeReference(openXmlElement, value?.ShapeReference);
      SetConnectionLocation(openXmlElement, value?.ConnectionLocation);
      return openXmlElement;
    }
    return default;
  }
}