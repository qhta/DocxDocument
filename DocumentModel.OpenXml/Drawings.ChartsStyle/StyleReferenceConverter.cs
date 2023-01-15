using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  ///   idx, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetIndex(StyleReference? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(StyleReference? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public static ListOf<String>? GetModifiers(StyleReference? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }

  public static void SetModifiers(StyleReference? openXmlElement, ListOf<String>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Modifiers = ListValueConverter.CreateListValue<StringValue>(value);
      else
        openXmlElement.Modifiers = null;
    }
  }

  public static DocumentModel.Drawings.ChartsStyle.StyleReference? CreateModelElement(StyleReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.StyleReference? value)
    where OpenXmlElementType : StyleReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetModifiers(openXmlElement, value?.Modifiers);
      return openXmlElement;
    }
    return default;
  }
}