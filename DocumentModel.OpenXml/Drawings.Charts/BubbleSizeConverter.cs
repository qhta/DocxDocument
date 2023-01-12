namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public static class BubbleSizeConverter
{
  public static DocumentModel.Drawings.Charts.NumberReference? GetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? openXmlElement, DocumentModel.Drawings.Charts.NumberReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.NumberLiteral? GetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? openXmlElement, DocumentModel.Drawings.Charts.NumberLiteral? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.BubbleSize? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleSize();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleSize? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleSize, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
