namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public static Int64? GetX(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  public static void SetX(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public static Int64? GetY(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  public static void SetY(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Y = value;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public static Int64? GetZ(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  public static void SetZ(DocumentFormat.OpenXml.Drawing.Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
