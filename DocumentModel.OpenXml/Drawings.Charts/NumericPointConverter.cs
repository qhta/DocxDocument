using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Numeric Point.
/// </summary>
public static class NumericPointConverter
{
  /// <summary>
  ///   Index
  /// </summary>
  public static UInt32? GetIndex(NumericPoint? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(NumericPoint? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  /// <summary>
  ///   Number Format
  /// </summary>
  public static String? GetFormatCode(NumericPoint? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }

  public static void SetFormatCode(NumericPoint? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }

  /// <summary>
  ///   Numeric Value.
  /// </summary>
  public static String? GetNumericValue(NumericPoint? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetNumericValue(NumericPoint? openXmlElement, String? value)
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

  public static DocumentModel.Drawings.Charts.NumericPoint? CreateModelElement(NumericPoint? openXmlElement)
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
    where OpenXmlElementType : NumericPoint, new()
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