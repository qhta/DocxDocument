namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public static class SeriesTextConverter
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public static DocumentModel.Drawings.Charts.StringReference? GetStringReference(DocumentFormat.OpenXml.Drawing.Charts.SeriesText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStringReference(DocumentFormat.OpenXml.Drawing.Charts.SeriesText? openXmlElement, DocumentModel.Drawings.Charts.StringReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public static String? GetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.SeriesText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.SeriesText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.NumericValue { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SeriesText? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SeriesText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SeriesText();
      value.StringReference = GetStringReference(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SeriesText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SeriesText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
