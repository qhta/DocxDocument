using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public static class NumberDataTypeConverter
{
  /// <summary>
  ///   Format Code.
  /// </summary>
  public static String? GetFormatCode(NumberDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FormatCode>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormatCode(NumberDataType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormatCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FormatCode { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Point Count.
  /// </summary>
  public static UInt32? GetPointCount(NumberDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPointCount(NumberDataType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PointCount { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.NumberDataType? CreateModelElement(NumberDataType? openXmlElement)
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
    where OpenXmlElementType : NumberDataType, new()
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