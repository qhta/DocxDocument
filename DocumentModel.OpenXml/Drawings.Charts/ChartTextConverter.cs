namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartTextConverter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DocumentModel.Drawings.Charts.StringReference? GetStringReference(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement, DocumentModel.Drawings.Charts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.StringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  private static DocumentModel.Drawings.Charts.RichText? GetRichText(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RichTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRichText(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement, DocumentModel.Drawings.Charts.RichText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.RichTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  private static DocumentModel.Drawings.Charts.StringLiteral? GetStringLiteral(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringLiteral(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement, DocumentModel.Drawings.Charts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.StringLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartText? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartText();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetRichText(openXmlElement, value?.RichText);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}
