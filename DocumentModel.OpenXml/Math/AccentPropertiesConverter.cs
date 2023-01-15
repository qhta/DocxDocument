using DocumentFormat.OpenXml.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Accent Properties.
/// </summary>
public static class AccentPropertiesConverter
{
  /// <summary>
  ///   Accent Character.
  /// </summary>
  public static String? GetAccentChar(AccentProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AccentChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAccentChar(AccentProperties? openXmlElement, String? value)
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
  ///   Control Properties.
  /// </summary>
  public static ControlProperties? GetControlProperties(AccentProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(AccentProperties? openXmlElement, ControlProperties? value)
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

  public static DocumentModel.Math.AccentProperties? CreateModelElement(AccentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.AccentProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.AccentProperties? value)
    where OpenXmlElementType : AccentProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}