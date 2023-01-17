namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public static class LevelReferenceConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSequenceOfReferences(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference openXmlElement, String? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      return openXmlElement;
    }
    return default;
  }
}
