namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Soft Edge Effect.
/// </summary>
public static class SoftEdgeConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  public static Int64? GetRadius(DocumentFormat.OpenXml.Drawing.SoftEdge? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  public static void SetRadius(DocumentFormat.OpenXml.Drawing.SoftEdge? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.SoftEdge? CreateModelElement(DocumentFormat.OpenXml.Drawing.SoftEdge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SoftEdge();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SoftEdge? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.SoftEdge, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
