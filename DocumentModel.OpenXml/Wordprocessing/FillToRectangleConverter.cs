namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FillToRectangle Class.
/// </summary>
public static class FillToRectangleConverter
{
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLeft(DXO2010W.FillToRectangle openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DXO2010W.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTop(DXO2010W.FillToRectangle openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DXO2010W.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRight(DXO2010W.FillToRectangle openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DXO2010W.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBottom(DXO2010W.FillToRectangle openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DXO2010W.FillToRectangle openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DMW.FillToRectangle? CreateModelElement(DXO2010W.FillToRectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FillToRectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FillToRectangle? value)
    where OpenXmlElementType: DXO2010W.FillToRectangle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetRight(openXmlElement, value?.Right);
      SetBottom(openXmlElement, value?.Bottom);
      return openXmlElement;
    }
    return default;
  }
}
