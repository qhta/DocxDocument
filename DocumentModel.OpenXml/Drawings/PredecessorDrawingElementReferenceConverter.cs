namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public static class PredecessorDrawingElementReferenceConverter
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetPred(DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference? openXmlElement)
  {
    return openXmlElement?.Pred?.Value;
  }
  
  public static void SetPred(DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Pred = new StringValue { Value = value };
      else
        openXmlElement.Pred = null;
  }
  
  public static DocumentModel.Drawings.PredecessorDrawingElementReference? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PredecessorDrawingElementReference();
      value.Pred = GetPred(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PredecessorDrawingElementReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
