namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public static class FramesetConverter
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  private static String? GetFrameSize(DXW.Frameset openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFrameSize(DXW.Frameset openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FrameSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  private static DMW.FramesetSplitbar? GetFramesetSplitbar(DXW.Frameset openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FramesetSplitbar>();
    if (itemElement != null)
      return DMXW.FramesetSplitbarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFramesetSplitbar(DXW.Frameset openXmlElement, DMW.FramesetSplitbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FramesetSplitbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramesetSplitbarConverter.CreateOpenXmlElement<DXW.FramesetSplitbar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  private static DMW.FrameLayoutKind? GetFrameLayout(DXW.Frameset openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameLayout>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFrameLayout(DXW.Frameset openXmlElement, DMW.FrameLayoutKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.FrameLayout, DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Frameset? GetChildFrameset(DXW.Frameset openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Frameset>();
    if (itemElement != null)
      return DMXW.FramesetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildFrameset(DXW.Frameset openXmlElement, DMW.Frameset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Frameset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramesetConverter.CreateOpenXmlElement<DXW.Frameset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Frame? GetFrame(DXW.Frameset openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Frame>();
    if (itemElement != null)
      return DMXW.FrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFrame(DXW.Frameset openXmlElement, DMW.Frame? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Frame>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FrameConverter.CreateOpenXmlElement<DXW.Frame>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Frameset? CreateModelElement(DXW.Frameset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Frameset();
      value.FrameSize = GetFrameSize(openXmlElement);
      value.FramesetSplitbar = GetFramesetSplitbar(openXmlElement);
      value.FrameLayout = GetFrameLayout(openXmlElement);
      value.ChildFrameset = GetChildFrameset(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Frameset? value)
    where OpenXmlElementType: DXW.Frameset, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFrameSize(openXmlElement, value?.FrameSize);
      SetFramesetSplitbar(openXmlElement, value?.FramesetSplitbar);
      SetFrameLayout(openXmlElement, value?.FrameLayout);
      SetChildFrameset(openXmlElement, value?.ChildFrameset);
      SetFrame(openXmlElement, value?.Frame);
      return openXmlElement;
    }
    return default;
  }
}
