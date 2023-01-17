namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public static class NumberDataTypeConverter
{
  /// <summary>
  /// Format Code.
  /// </summary>
  private static String? GetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  private static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberDataType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberDataType();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberDataType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumberDataType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetPointCount(openXmlElement, value?.PointCount);
      return openXmlElement;
    }
    return default;
  }
}
