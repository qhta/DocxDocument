using DocumentModel.Math;
using Accent = DocumentFormat.OpenXml.Math.Accent;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Accent.
/// </summary>
public static class AccentConverter
{
  /// <summary>
  ///   Accent Properties.
  /// </summary>
  public static AccentProperties? GetAccentProperties(Accent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.AccentProperties>();
    if (itemElement != null)
      return AccentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAccentProperties(Accent? openXmlElement, AccentProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AccentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.AccentProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(Accent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Accent? openXmlElement, Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.Accent? CreateModelElement(Accent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Accent();
      value.AccentProperties = GetAccentProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Accent? value)
    where OpenXmlElementType : Accent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentProperties(openXmlElement, value?.AccentProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}