namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public static class AdjustConverter
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust openXmlElement, Double? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
