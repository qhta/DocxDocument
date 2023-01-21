namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public static class DivBorderConverter
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  private static DMW.BorderType? GetTopBorder(DXW.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DXW.DivBorder openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  private static DMW.BorderType? GetLeftBorder(DXW.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DXW.DivBorder openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  private static DMW.BorderType? GetBottomBorder(DXW.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DXW.DivBorder openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  private static DMW.BorderType? GetRightBorder(DXW.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DXW.DivBorder openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DivBorder? CreateModelElement(DXW.DivBorder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DivBorder();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DivBorder? value)
    where OpenXmlElementType: DXW.DivBorder, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      return openXmlElement;
    }
    return default;
  }
}
