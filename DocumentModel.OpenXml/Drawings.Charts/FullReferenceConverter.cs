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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      return openXmlElement;
    }
    return default;
  }
}
