namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
public static class FullReferenceConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public static String? GetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences");
  }
  
  public static void SetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences");
  }
  
  public static DocumentModel.Drawings.Charts.FullReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FullReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FullReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
