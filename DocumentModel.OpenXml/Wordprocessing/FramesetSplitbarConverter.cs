namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public static class FramesetSplitbarConverter
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  private static String? GetWidth(DXW.FramesetSplitbar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Width>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetWidth(DXW.FramesetSplitbar openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Width>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Width { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  private static DMW.Color? GetColor(DXW.FramesetSplitbar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      return DMXW.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColor(DXW.FramesetSplitbar openXmlElement, DMW.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetNoBorder(DXW.FramesetSplitbar openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoBorder>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoBorder(DXW.FramesetSplitbar openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.NoBorder, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetFlatBorders(DXW.FramesetSplitbar openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FlatBorders>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFlatBorders(DXW.FramesetSplitbar openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FlatBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.FlatBorders, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.FramesetSplitbar? CreateModelElement(DXW.FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FramesetSplitbar();
      value.Width = GetWidth(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.NoBorder = GetNoBorder(openXmlElement);
      value.FlatBorders = GetFlatBorders(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FramesetSplitbar? value)
    where OpenXmlElementType: DXW.FramesetSplitbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetColor(openXmlElement, value?.Color);
      SetNoBorder(openXmlElement, value?.NoBorder);
      SetFlatBorders(openXmlElement, value?.FlatBorders);
      return openXmlElement;
    }
    return default;
  }
}
