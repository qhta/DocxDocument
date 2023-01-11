namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public static class AdjustConverter
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static Double? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }
  
  public static DocumentModel.Drawings.Diagrams.Adjust? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Adjust();
      value.Index = GetIndex(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Adjust? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Adjust, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
