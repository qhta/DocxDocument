using DocumentModel.Drawings.Charts;
using NumberingFormat = DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat;
using SerAxExtension = DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SerAxExtension Class.
/// </summary>
public static class SerAxExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(SerAxExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(SerAxExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static NumberingFormat3? GetNumberingFormat(SerAxExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingFormat>();
    if (itemElement != null)
      return NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(SerAxExtension? openXmlElement, NumberingFormat3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormat3Converter.CreateOpenXmlElement<NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SerAxExtension? CreateModelElement(SerAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SerAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SerAxExtension? value)
    where OpenXmlElementType : SerAxExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      return openXmlElement;
    }
    return default;
  }
}