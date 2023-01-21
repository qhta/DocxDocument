namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public static class PageSizeConverter
{
  /// <summary>
  /// Page Width
  /// </summary>
  private static UInt32? GetWidth(DXW.PageSize openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXW.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  private static UInt32? GetHeight(DXW.PageSize openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DXW.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  private static DMW.PageOrientationKind? GetOrient(DXW.PageSize openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DMW.PageOrientationKind>(openXmlElement?.Orient?.Value);
  }
  
  private static void SetOrient(DXW.PageSize openXmlElement, DMW.PageOrientationKind? value)
  {
    openXmlElement.Orient = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DMW.PageOrientationKind>(value);
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  private static UInt16? GetCode(DXW.PageSize openXmlElement)
  {
    return openXmlElement.Code?.Value;
  }
  
  private static void SetCode(DXW.PageSize openXmlElement, UInt16? value)
  {
    openXmlElement.Code = value;
  }
  
  public static DMW.PageSize? CreateModelElement(DXW.PageSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageSize();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Orient = GetOrient(openXmlElement);
      value.Code = GetCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PageSize? value)
    where OpenXmlElementType: DXW.PageSize, new()
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
