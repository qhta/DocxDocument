namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Point.
/// </summary>
public static class StringPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public static String? GetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement, String? value)
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
  
  public static DocumentModel.Drawings.Charts.StringPoint? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringPoint();
      value.Index = GetIndex(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringPoint? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
