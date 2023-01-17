namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Minus.
/// </summary>
public static class MinusConverter
{
  private static DocumentModel.Drawings.Charts.NumberReference? GetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.Minus openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.Minus openXmlElement, DocumentModel.Drawings.Charts.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.NumberLiteral? GetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.Minus openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.Minus openXmlElement, DocumentModel.Drawings.Charts.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Minus? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Minus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Minus();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Minus? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Minus, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      return openXmlElement;
    }
    return default;
  }
}
