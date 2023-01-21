namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  private static Int64? GetX(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement.X?.Value;
  }
  
  private static void SetX(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  private static Int64? GetY(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement.Y?.Value;
  }
  
  private static void SetY(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  private static Int64? GetZ(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DMDraws.Anchor? CreateModelElement(DXDraw.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Anchor();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Anchor? value)
    where OpenXmlElementType: DXDraw.Anchor, new()
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
