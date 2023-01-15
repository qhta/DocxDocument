using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentModel.Drawings.Wordprocessing;
using VerticalPosition = DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Vertical Positioning.
/// </summary>
public static class VerticalPositionConverter
{
  /// <summary>
  ///   Vertical Position Relative Base
  /// </summary>
  public static VerticalRelativePositionKind? GetRelativeFrom(VerticalPosition? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalRelativePositionValues, VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }

  public static void SetRelativeFrom(VerticalPosition? openXmlElement, VerticalRelativePositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<VerticalRelativePositionValues, VerticalRelativePositionKind>(value);
  }

  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  public static String? GetVerticalAlignment(VerticalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<VerticalAlignment>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetVerticalAlignment(VerticalPosition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new VerticalAlignment { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PositionOffset.
  /// </summary>
  public static String? GetPositionOffset(VerticalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PositionOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPositionOffset(VerticalPosition? openXmlElement, String? value)
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
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetPercentagePositionVerticalOffset(VerticalPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentagePositionVerticalOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPercentagePositionVerticalOffset(VerticalPosition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentagePositionVerticalOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentagePositionVerticalOffset { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.VerticalPosition? CreateModelElement(VerticalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.VerticalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.VerticalAlignment = GetVerticalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionVerticalOffset = GetPercentagePositionVerticalOffset(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.VerticalPosition? value)
    where OpenXmlElementType : VerticalPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetVerticalAlignment(openXmlElement, value?.VerticalAlignment);
      SetPositionOffset(openXmlElement, value?.PositionOffset);
      SetPercentagePositionVerticalOffset(openXmlElement, value?.PercentagePositionVerticalOffset);
      return openXmlElement;
    }
    return default;
  }
}