using DocumentModel.Math;
using Bar = DocumentFormat.OpenXml.Math.Bar;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Bar.
/// </summary>
public static class BarConverter
{
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  public static BarProperties? GetBarProperties(Bar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BarProperties>();
    if (itemElement != null)
      return BarPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBarProperties(Bar? openXmlElement, BarProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BarProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BarProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(Bar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Bar? openXmlElement, Base? value)
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

  public static DocumentModel.Math.Bar? CreateModelElement(Bar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Bar();
      value.BarProperties = GetBarProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Bar? value)
    where OpenXmlElementType : Bar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarProperties(openXmlElement, value?.BarProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}