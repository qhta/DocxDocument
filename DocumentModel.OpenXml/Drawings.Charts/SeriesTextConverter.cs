using DocumentFormat.OpenXml.Drawing.Charts;
using SeriesText = DocumentFormat.OpenXml.Drawing.Charts.SeriesText;
using StringReference = DocumentModel.Drawings.Charts.StringReference;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Series Text.
/// </summary>
public static class SeriesTextConverter
{
  /// <summary>
  ///   StringReference.
  /// </summary>
  public static StringReference? GetStringReference(SeriesText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringReference(SeriesText? openXmlElement, StringReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NumericValue.
  /// </summary>
  public static String? GetNumericValue(SeriesText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetNumericValue(SeriesText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumericValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumericValue { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SeriesText? CreateModelElement(SeriesText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SeriesText();
      value.StringReference = GetStringReference(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SeriesText? value)
    where OpenXmlElementType : SeriesText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}