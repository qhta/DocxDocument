using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   String Point.
/// </summary>
public static class StringPointConverter
{
  /// <summary>
  ///   Index
  /// </summary>
  public static UInt32? GetIndex(StringPoint? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(StringPoint? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  /// <summary>
  ///   Text Value.
  /// </summary>
  public static String? GetNumericValue(StringPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetNumericValue(StringPoint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumericValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumericValue { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.StringPoint? CreateModelElement(StringPoint? openXmlElement)
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
    where OpenXmlElementType : StringPoint, new()
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