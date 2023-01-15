using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using StringDataType = DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public static class StringDataType3Converter
{
  /// <summary>
  ///   PointCount.
  /// </summary>
  public static UInt32? GetPointCount(StringDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPointCount(StringDataType? openXmlElement, UInt32? value)
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

  public static StringDataType3? CreateModelElement(StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new StringDataType3();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(StringDataType3? value)
    where OpenXmlElementType : StringDataType, new()
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