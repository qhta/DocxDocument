namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public static class TableCellBordersConverter
{
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  private static DMW.BorderType? GetTopBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
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
  /// Table Cell Left Border.
  /// </summary>
  private static DMW.BorderType? GetLeftBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
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
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.BorderType? GetStartBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StartBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.StartBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  private static DMW.BorderType? GetBottomBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
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
  /// Table Cell Right Border.
  /// </summary>
  private static DMW.BorderType? GetRightBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
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
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.BorderType? GetEndBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EndBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.EndBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  private static DMW.BorderType? GetInsideHorizontalBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsideHorizontalBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.InsideHorizontalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  private static DMW.BorderType? GetInsideVerticalBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsideVerticalBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsideVerticalBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.InsideVerticalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  private static DMW.BorderType? GetTopLeftToBottomRightCellBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopLeftToBottomRightCellBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopLeftToBottomRightCellBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopLeftToBottomRightCellBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopLeftToBottomRightCellBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  private static DMW.BorderType? GetTopRightToBottomLeftCellBorder(DXW.TableCellBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopRightToBottomLeftCellBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopRightToBottomLeftCellBorder(DXW.TableCellBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopRightToBottomLeftCellBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopRightToBottomLeftCellBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableCellBorders? CreateModelElement(DXW.TableCellBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.StartBorder = GetStartBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.EndBorder = GetEndBorder(openXmlElement);
      value.InsideHorizontalBorder = GetInsideHorizontalBorder(openXmlElement);
      value.InsideVerticalBorder = GetInsideVerticalBorder(openXmlElement);
      value.TopLeftToBottomRightCellBorder = GetTopLeftToBottomRightCellBorder(openXmlElement);
      value.TopRightToBottomLeftCellBorder = GetTopRightToBottomLeftCellBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellBorders? value)
    where OpenXmlElementType: DXW.TableCellBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetStartBorder(openXmlElement, value?.StartBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetEndBorder(openXmlElement, value?.EndBorder);
      SetInsideHorizontalBorder(openXmlElement, value?.InsideHorizontalBorder);
      SetInsideVerticalBorder(openXmlElement, value?.InsideVerticalBorder);
      SetTopLeftToBottomRightCellBorder(openXmlElement, value?.TopLeftToBottomRightCellBorder);
      SetTopRightToBottomLeftCellBorder(openXmlElement, value?.TopRightToBottomLeftCellBorder);
      return openXmlElement;
    }
    return default;
  }
}
