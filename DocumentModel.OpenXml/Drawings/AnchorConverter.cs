namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  private static Int64? GetX(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement)
  {
    return openXmlElement.X?.Value;
  }
  
  private static void SetX(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  private static Int64? GetY(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement)
  {
    return openXmlElement.Y?.Value;
  }
  
  private static void SetY(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  private static Int64? GetZ(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DocumentFormat.OpenXml.Drawing.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DocumentModel.Drawings.Anchor? CreateModelElement(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Anchor();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Anchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Anchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
