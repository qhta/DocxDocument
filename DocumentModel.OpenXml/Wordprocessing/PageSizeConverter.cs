using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PageSize = DocumentFormat.OpenXml.Wordprocessing.PageSize;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PageSize Class.
/// </summary>
public static class PageSizeConverter
{
  /// <summary>
  ///   Page Width
  /// </summary>
  public static UInt32? GetWidth(PageSize? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(PageSize? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   Page Height
  /// </summary>
  public static UInt32? GetHeight(PageSize? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(PageSize? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   Page Orientation
  /// </summary>
  public static PageOrientationKind? GetOrient(PageSize? openXmlElement)
  {
    return EnumValueConverter.GetValue<PageOrientationValues, PageOrientationKind>(openXmlElement?.Orient?.Value);
  }

  public static void SetOrient(PageSize? openXmlElement, PageOrientationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orient = EnumValueConverter.CreateEnumValue<PageOrientationValues, PageOrientationKind>(value);
  }

  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  public static UInt16? GetCode(PageSize? openXmlElement)
  {
    return openXmlElement?.Code?.Value;
  }

  public static void SetCode(PageSize? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.Code = value;
  }

  public static DocumentModel.Wordprocessing.PageSize? CreateModelElement(PageSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageSize();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Orient = GetOrient(openXmlElement);
      value.Code = GetCode(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageSize? value)
    where OpenXmlElementType : PageSize, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetOrient(openXmlElement, value?.Orient);
      SetCode(openXmlElement, value?.Code);
      return openXmlElement;
    }
    return default;
  }
}