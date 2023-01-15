using DocumentModel.Drawings.Charts;
using NumberingFormat = DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat;
using ValAxExtension = DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public static class ValAxExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(ValAxExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(ValAxExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static NumberingFormat3? GetNumberingFormat(ValAxExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingFormat>();
    if (itemElement != null)
      return NumberingFormat3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(ValAxExtension? openXmlElement, NumberingFormat3? value)
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

  public static DocumentModel.Drawings.Charts.ValAxExtension? CreateModelElement(ValAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ValAxExtension? value)
    where OpenXmlElementType : ValAxExtension, new()
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