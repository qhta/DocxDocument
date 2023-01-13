namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Numeric Point.
/// </summary>
public static class NumericPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public static String? GetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  public static void SetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public static String? GetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement, String? value)
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
  
  public static DocumentModel.Drawings.Charts.NumericPoint? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumericPoint();
      value.Index = GetIndex(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumericPoint? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumericPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
