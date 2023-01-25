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
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXO2010W.FillToRectangle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
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
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXO2010W.FillToRectangle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
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
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXO2010W.FillToRectangle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
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
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXO2010W.FillToRectangle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
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
  
  public static bool CompareModelElement(DXO2010W.FillToRectangle? openXmlElement, DMW.FillToRectangle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
