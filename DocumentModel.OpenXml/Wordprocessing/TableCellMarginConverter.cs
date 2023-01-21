namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public static class TableCellMarginConverter
{
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  private static DMW.TableWidthType? GetTopMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
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
  /// Table Cell Left Margin Exception.
  /// </summary>
  private static DMW.TableWidthType? GetLeftMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LeftMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.LeftMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetStartMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StartMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
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
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  private static DMW.TableWidthType? GetBottomMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
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
  /// Table Cell Right Margin Exception.
  /// </summary>
  private static DMW.TableWidthType? GetRightMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RightMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.RightMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetEndMargin(DXW.TableCellMargin openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EndMargin>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidthType? value)
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
  
  public static DMW.TableCellMargin? CreateModelElement(DXW.TableCellMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellMargin();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellMargin? value)
    where OpenXmlElementType: DXW.TableCellMargin, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopMargin(openXmlElement, value?.TopMargin);
      SetLeftMargin(openXmlElement, value?.LeftMargin);
      SetStartMargin(openXmlElement, value?.StartMargin);
      SetBottomMargin(openXmlElement, value?.BottomMargin);
      SetRightMargin(openXmlElement, value?.RightMargin);
      SetEndMargin(openXmlElement, value?.EndMargin);
      return openXmlElement;
    }
    return default;
  }
}
