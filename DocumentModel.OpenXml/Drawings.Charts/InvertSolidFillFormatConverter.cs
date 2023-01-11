namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public static class InvertSolidFillFormatConverter
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ShapeProperties2? GetShapeProperties(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapeProperties2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat? openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapeProperties2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.InvertSolidFillFormat? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.InvertSolidFillFormat();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.InvertSolidFillFormat? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
