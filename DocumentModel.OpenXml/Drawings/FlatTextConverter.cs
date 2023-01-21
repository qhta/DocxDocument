namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  private static Int64? GetZ(DXDraw.FlatText openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DXDraw.FlatText openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DMDraws.FlatText? CreateModelElement(DXDraw.FlatText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FlatText();
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FlatText? value)
    where OpenXmlElementType: DXDraw.FlatText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
