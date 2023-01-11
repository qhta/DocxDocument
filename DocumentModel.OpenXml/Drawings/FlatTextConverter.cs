namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public static Int64? GetZ(DocumentFormat.OpenXml.Drawing.FlatText? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  public static void SetZ(DocumentFormat.OpenXml.Drawing.FlatText? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
