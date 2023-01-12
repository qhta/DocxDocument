namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataTypeConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringDataType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.StringDataType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringDataType();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringDataType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringDataType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      return openXmlElement;
    }
    return default;
  }
}
