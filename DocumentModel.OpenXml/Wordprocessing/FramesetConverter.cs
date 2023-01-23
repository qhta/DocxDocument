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
      return openXmlElement.GetFirstChild<DXW.FrameSize>()?.Val?.Value;
  }
  
  private static bool CmpFrameSize(DXW.Frameset openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement.GetFirstChild<DXW.FrameSize>()?.Val?.Value == value;
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
    return DMXW.FramesetSplitbarConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FramesetSplitbar>());
  }
  
  private static bool CmpFramesetSplitbar(DXW.Frameset openXmlElement, DMW.FramesetSplitbar? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramesetSplitbarConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.FramesetSplitbar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(openXmlElement.GetFirstChild<DXW.FrameLayout>()?.Val?.Value);
  }
  
  private static bool CmpFrameLayout(DXW.Frameset openXmlElement, DMW.FrameLayoutKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(openXmlElement.GetFirstChild<DXW.FrameLayout>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.FramesetConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Frameset>());
  }
  
  private static bool CmpChildFrameset(DXW.Frameset openXmlElement, DMW.Frameset? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramesetConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Frameset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.FrameConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Frame>());
  }
  
  private static bool CmpFrame(DXW.Frameset openXmlElement, DMW.Frame? value, DiffList? diffs, string? objName)
  {
    return DMXW.FrameConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Frame>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.Frameset? openXmlElement, DMW.Frameset? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFrameSize(openXmlElement, value.FrameSize, diffs, objName))
        ok = false;
      if (!CmpFramesetSplitbar(openXmlElement, value.FramesetSplitbar, diffs, objName))
        ok = false;
      if (!CmpFrameLayout(openXmlElement, value.FrameLayout, diffs, objName))
        ok = false;
      if (!CmpChildFrameset(openXmlElement, value.ChildFrameset, diffs, objName))
        ok = false;
      if (!CmpFrame(openXmlElement, value.Frame, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
