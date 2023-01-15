using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentModel.Drawings.Wordprocessing;
using HorizontalPosition = DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Horizontal Positioning.
/// </summary>
public static class HorizontalPositionConverter
{
  /// <summary>
  ///   Horizontal Position Relative Base
  /// </summary>
  public static HorizontalRelativePositionKind? GetRelativeFrom(HorizontalPosition? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalRelativePositionValues, HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }

  public static void SetRelativeFrom(HorizontalPosition? openXmlElement, HorizontalRelativePositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<HorizontalRelativePositionValues, HorizontalRelativePositionKind>(value);
  }

  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  public static String? GetHorizontalAlignment(HorizontalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HorizontalAlignment>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetHorizontalAlignment(HorizontalPosition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HorizontalAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new HorizontalAlignment { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Absolute Position Offset.
  /// </summary>
  public static String? GetPositionOffset(HorizontalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PositionOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPositionOffset(HorizontalPosition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PositionOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PositionOffset { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetPercentagePositionHeightOffset(HorizontalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentagePositionHeightOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPercentagePositionHeightOffset(HorizontalPosition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentagePositionHeightOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentagePositionHeightOffset { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? CreateModelElement(HorizontalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.HorizontalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionHeightOffset = GetPercentagePositionHeightOffset(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.HorizontalPosition? value)
    where OpenXmlElementType : HorizontalPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
      SetPositionOffset(openXmlElement, value?.PositionOffset);
      SetPercentagePositionHeightOffset(openXmlElement, value?.PercentagePositionHeightOffset);
      return openXmlElement;
    }
    return default;
  }
}