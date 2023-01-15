using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentModel.Wordprocessing.Drawings;
using RelativeHeight = DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight;

namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public static class RelativeHeightConverter
{
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public static SizeRelativeVerticallyKind? GetRelativeFrom(RelativeHeight? openXmlElement)
  {
    return EnumValueConverter.GetValue<SizeRelativeVerticallyValues, SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value);
  }

  public static void SetRelativeFrom(RelativeHeight? openXmlElement, SizeRelativeVerticallyKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<SizeRelativeVerticallyValues, SizeRelativeVerticallyKind>(value);
  }

  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  public static String? GetPercentageHeight(RelativeHeight? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentageHeight>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPercentageHeight(RelativeHeight? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentageHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentageHeight { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Drawings.RelativeHeight? CreateModelElement(RelativeHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawings.RelativeHeight();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.PercentageHeight = GetPercentageHeight(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawings.RelativeHeight? value)
    where OpenXmlElementType : RelativeHeight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetPercentageHeight(openXmlElement, value?.PercentageHeight);
      return openXmlElement;
    }
    return default;
  }
}