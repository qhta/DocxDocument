using DocumentModel.Wordprocessing;
using SdtElement = DocumentFormat.OpenXml.Wordprocessing.SdtElement;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines SdtElement - the base class for the sdt elements.
/// </summary>
public static class SdtElementConverter
{
  /// <summary>
  ///   Gets or sets the SdtProperties.
  /// </summary>
  public static SdtProperties? GetSdtProperties(SdtElement? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
    if (itemElement != null)
      return SdtPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtProperties(SdtElement? openXmlElement, SdtProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Gets or sets the SdtEndCharProperties.
  /// </summary>
  public static SdtEndCharProperties? GetSdtEndCharProperties(SdtElement? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
    if (itemElement != null)
      return SdtEndCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtEndCharProperties(SdtElement? openXmlElement, SdtEndCharProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtEndCharPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtElement? CreateModelElement(SdtElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtElement();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtElement? value)
    where OpenXmlElementType : SdtElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSdtProperties(openXmlElement, value?.SdtProperties);
      SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
      return openXmlElement;
    }
    return default;
  }
}