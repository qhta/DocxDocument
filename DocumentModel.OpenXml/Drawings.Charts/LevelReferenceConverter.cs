namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public static class LevelReferenceConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public static String? GetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences");
  }
  
  public static void SetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences");
  }
  
  public static DocumentModel.Drawings.Charts.LevelReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LevelReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LevelReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
