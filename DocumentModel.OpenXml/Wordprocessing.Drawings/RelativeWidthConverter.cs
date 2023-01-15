using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentModel.Wordprocessing.Drawings;
using RelativeWidth = DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth;

namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public static class RelativeWidthConverter
{
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public static SizeRelativeHorizontallyKind? GetObjectId(RelativeWidth? openXmlElement)
  {
    return EnumValueConverter.GetValue<SizeRelativeHorizontallyValues, SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value);
  }

  public static void SetObjectId(RelativeWidth? openXmlElement, SizeRelativeHorizontallyKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ObjectId = EnumValueConverter.CreateEnumValue<SizeRelativeHorizontallyValues, SizeRelativeHorizontallyKind>(value);
  }

  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  public static String? GetPercentageWidth(RelativeWidth? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentageWidth>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPercentageWidth(RelativeWidth? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentageWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentageWidth { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Drawings.RelativeWidth? CreateModelElement(RelativeWidth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawings.RelativeWidth();
      value.ObjectId = GetObjectId(openXmlElement);
      value.PercentageWidth = GetPercentageWidth(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawings.RelativeWidth? value)
    where OpenXmlElementType : RelativeWidth, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetObjectId(openXmlElement, value?.ObjectId);
      SetPercentageWidth(openXmlElement, value?.PercentageWidth);
      return openXmlElement;
    }
    return default;
  }
}