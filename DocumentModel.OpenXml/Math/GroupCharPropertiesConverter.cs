using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using GroupCharProperties = DocumentFormat.OpenXml.Math.GroupCharProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Group-Character Properties.
/// </summary>
public static class GroupCharPropertiesConverter
{
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  public static String? GetAccentChar(GroupCharProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AccentChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAccentChar(GroupCharProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AccentChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AccentChar { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  public static VerticalJustificationKind? GetPosition(GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Position>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalJustificationValues, VerticalJustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPosition(GroupCharProperties? openXmlElement, VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Position, VerticalJustificationValues, VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  public static VerticalJustificationKind? GetVerticalJustification(GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalJustificationValues, VerticalJustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalJustification(GroupCharProperties? openXmlElement, VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<VerticalJustification, VerticalJustificationValues, VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(GroupCharProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(GroupCharProperties? openXmlElement, ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.GroupCharProperties? CreateModelElement(GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.GroupCharProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.VerticalJustification = GetVerticalJustification(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.GroupCharProperties? value)
    where OpenXmlElementType : GroupCharProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetPosition(openXmlElement, value?.Position);
      SetVerticalJustification(openXmlElement, value?.VerticalJustification);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}