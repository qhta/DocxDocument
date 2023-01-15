using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TablePositionProperties = DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TablePositionProperties Class.
/// </summary>
public static class TablePositionPropertiesConverter
{
  /// <summary>
  ///   Distance From Left of Table to Text
  /// </summary>
  public static Int16? GetLeftFromText(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.LeftFromText?.Value;
  }

  public static void SetLeftFromText(TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftFromText = value;
  }

  /// <summary>
  ///   (Distance From Right of Table to Text
  /// </summary>
  public static Int16? GetRightFromText(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.RightFromText?.Value;
  }

  public static void SetRightFromText(TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightFromText = value;
  }

  /// <summary>
  ///   Distance From Top of Table to Text
  /// </summary>
  public static Int16? GetTopFromText(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TopFromText?.Value;
  }

  public static void SetTopFromText(TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopFromText = value;
  }

  /// <summary>
  ///   Distance From Bottom of Table to Text
  /// </summary>
  public static Int16? GetBottomFromText(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.BottomFromText?.Value;
  }

  public static void SetBottomFromText(TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomFromText = value;
  }

  /// <summary>
  ///   Table Vertical Anchor
  /// </summary>
  public static VerticalAnchorKind? GetVerticalAnchor(TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalAnchorValues, VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value);
  }

  public static void SetVerticalAnchor(TablePositionProperties? openXmlElement, VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalAnchor = EnumValueConverter.CreateEnumValue<VerticalAnchorValues, VerticalAnchorKind>(value);
  }

  /// <summary>
  ///   Table Horizontal Anchor
  /// </summary>
  public static HorizontalAnchorKind? GetHorizontalAnchor(TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalAnchorValues, HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value);
  }

  public static void SetHorizontalAnchor(TablePositionProperties? openXmlElement, HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAnchor = EnumValueConverter.CreateEnumValue<HorizontalAnchorValues, HorizontalAnchorKind>(value);
  }

  /// <summary>
  ///   Relative Horizontal Alignment From Anchor
  /// </summary>
  public static HorizontalAlignmentKind? GetTablePositionXAlignment(TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalAlignmentValues, HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value);
  }

  public static void SetTablePositionXAlignment(TablePositionProperties? openXmlElement, HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionXAlignment = EnumValueConverter.CreateEnumValue<HorizontalAlignmentValues, HorizontalAlignmentKind>(value);
  }

  /// <summary>
  ///   Absolute Horizontal Distance From Anchor
  /// </summary>
  public static Int32? GetTablePositionX(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TablePositionX?.Value;
  }

  public static void SetTablePositionX(TablePositionProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionX = value;
  }

  /// <summary>
  ///   Relative Vertical Alignment from Anchor
  /// </summary>
  public static VerticalAlignmentKind? GetTablePositionYAlignment(TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalAlignmentValues, VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value);
  }

  public static void SetTablePositionYAlignment(TablePositionProperties? openXmlElement, VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionYAlignment = EnumValueConverter.CreateEnumValue<VerticalAlignmentValues, VerticalAlignmentKind>(value);
  }

  /// <summary>
  ///   Absolute Vertical Distance From Anchor
  /// </summary>
  public static Int32? GetTablePositionY(TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TablePositionY?.Value;
  }

  public static void SetTablePositionY(TablePositionProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionY = value;
  }

  public static DocumentModel.Wordprocessing.TablePositionProperties? CreateModelElement(TablePositionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TablePositionProperties();
      value.LeftFromText = GetLeftFromText(openXmlElement);
      value.RightFromText = GetRightFromText(openXmlElement);
      value.TopFromText = GetTopFromText(openXmlElement);
      value.BottomFromText = GetBottomFromText(openXmlElement);
      value.VerticalAnchor = GetVerticalAnchor(openXmlElement);
      value.HorizontalAnchor = GetHorizontalAnchor(openXmlElement);
      value.TablePositionXAlignment = GetTablePositionXAlignment(openXmlElement);
      value.TablePositionX = GetTablePositionX(openXmlElement);
      value.TablePositionYAlignment = GetTablePositionYAlignment(openXmlElement);
      value.TablePositionY = GetTablePositionY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TablePositionProperties? value)
    where OpenXmlElementType : TablePositionProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftFromText(openXmlElement, value?.LeftFromText);
      SetRightFromText(openXmlElement, value?.RightFromText);
      SetTopFromText(openXmlElement, value?.TopFromText);
      SetBottomFromText(openXmlElement, value?.BottomFromText);
      SetVerticalAnchor(openXmlElement, value?.VerticalAnchor);
      SetHorizontalAnchor(openXmlElement, value?.HorizontalAnchor);
      SetTablePositionXAlignment(openXmlElement, value?.TablePositionXAlignment);
      SetTablePositionX(openXmlElement, value?.TablePositionX);
      SetTablePositionYAlignment(openXmlElement, value?.TablePositionYAlignment);
      SetTablePositionY(openXmlElement, value?.TablePositionY);
      return openXmlElement;
    }
    return default;
  }
}