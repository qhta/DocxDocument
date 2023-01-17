namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  private static Int64? GetZ(DocumentFormat.OpenXml.Drawing.FlatText openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DocumentFormat.OpenXml.Drawing.FlatText openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DocumentModel.Drawings.FlatText? CreateModelElement(DocumentFormat.OpenXml.Drawing.FlatText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FlatText();
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FlatText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FlatText, new()
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
