using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;
using BorderType = DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType;

namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public static BorderKind? GetType(BorderType? openXmlElement)
  {
    return EnumValueConverter.GetValue<BorderValues, BorderKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(BorderType? openXmlElement, BorderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<BorderValues, BorderKind>(value);
  }

  /// <summary>
  ///   Border Width
  /// </summary>
  public static Int64? GetWidth(BorderType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(BorderType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   Border shadow
  /// </summary>
  public static Boolean? GetShadow(BorderType? openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }

  public static void SetShadow(BorderType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Shadow = value;
      else
        openXmlElement.Shadow = null;
  }

  public static DocumentModel.Wordprocessing.Vml.BorderType? CreateModelElement(BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Vml.BorderType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Vml.BorderType? value)
    where OpenXmlElementType : BorderType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetWidth(openXmlElement, value?.Width);
      SetShadow(openXmlElement, value?.Shadow);
      return openXmlElement;
    }
    return default;
  }
}