namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public static class TableCellMarginDefaultConverter
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  private static DMW.TableWidthType? GetTopMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TopMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  private static DMW.TableWidthDxaNilType? GetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellLeftMargin>();
    if (itemElement != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellLeftMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DXW.TableCellLeftMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetStartMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StartMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.StartMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  private static DMW.TableWidthType? GetBottomMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.BottomMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  private static DMW.TableWidthDxaNilType? GetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellRightMargin>();
    if (itemElement != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellRightMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DXW.TableCellRightMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetEndMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EndMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.EndMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableCellMarginDefault? CreateModelElement(DXW.TableCellMarginDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellMarginDefault();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.TableCellLeftMargin = GetTableCellLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.TableCellRightMargin = GetTableCellRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellMarginDefault? value)
    where OpenXmlElementType: DXW.TableCellMarginDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopMargin(openXmlElement, value?.TopMargin);
      SetTableCellLeftMargin(openXmlElement, value?.TableCellLeftMargin);
      SetStartMargin(openXmlElement, value?.StartMargin);
      SetBottomMargin(openXmlElement, value?.BottomMargin);
      SetTableCellRightMargin(openXmlElement, value?.TableCellRightMargin);
      SetEndMargin(openXmlElement, value?.EndMargin);
      return openXmlElement;
    }
    return default;
  }
}
