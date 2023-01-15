using DocumentModel.Drawings.Charts;
using DateAxExtension = DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension;
using NumberingFormat = DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtension Class.
/// </summary>
public static class DateAxExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(DateAxExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DateAxExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static NumberingFormat3? GetNumberingFormat(DateAxExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingFormat>();
    if (itemElement != null)
      return NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(DateAxExtension? openXmlElement, NumberingFormat3? value)
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

  public static DocumentModel.Drawings.Charts.DateAxExtension? CreateModelElement(DateAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DateAxExtension? value)
    where OpenXmlElementType : DateAxExtension, new()
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