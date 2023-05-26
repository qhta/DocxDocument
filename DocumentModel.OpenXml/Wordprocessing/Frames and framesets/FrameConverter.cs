namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Frame"/> class from/to OpenXml converter.
/// </summary>
public static class FrameConverter
{
  #region FrameSize conversion.
  private static UInt32? GetFrameSize(DXW.Frame openXmlElement)
  {
    return UInt32ValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FrameSize>()?.Val?.Value);
  }
  
  private static bool CmpFrameSize(DXW.Frame openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement?.Val?.Value == value.ToString()) return true;
    diffs?.Add(objName, "FrameSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetFrameSize(DXW.Frame openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FrameSize { Val = value.ToString() };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion


  #region FrameName conversion.
  private static String? GetFrameName(DXW.Frame openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FrameName>()?.Val);
  }
  
  private static bool CmpFrameName(DXW.Frame openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FrameName>()?.Val, value, diffs, objName, "FrameName");
  }
  
  private static void SetFrameName(DXW.Frame openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.FrameName>(openXmlElement, value);
  }
  #endregion

  #region SourceFile conversion.
  private static DMW.FrameSourceFile? GetSourceFileReference(DXW.Frame openXmlElement, DXW.WebSettings? settings = null)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SourceFileReference>();
    if (element != null)
      return DMXW.FrameSourceFileConverter.CreateModelElement(element, settings);
    return null;
  }
  
  private static bool CmpSourceFileReference(DXW.Frame openXmlElement, DMW.FrameSourceFile? value, 
    DiffList? diffs, string? objName, string? propName, DXW.WebSettings? settings = null)
  {
    return DMXW.FrameSourceFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SourceFileReference>(), value, diffs, objName, propName, settings);
  }
  
  private static void SetSourceFileReference(DXW.Frame openXmlElement, DMW.FrameSourceFile? value, DXW.WebSettings? settings = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SourceFileReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FrameSourceFileConverter.CreateOpenXmlElement(value, settings);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Width conversion.
  private static UInt32? GetMarginWidth(DXW.Frame openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.MarginWidth>()?.Val);
  }
  
  private static bool CmpMarginWidth(DXW.Frame openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.MarginWidth>()?.Val, value, diffs, objName, "MarginWidth");
  }
  
  private static void SetMarginWidth(DXW.Frame openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.MarginWidth,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Height conversion.
  private static UInt32? GetMarginHeight(DXW.Frame openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.MarginHeight>()?.Val);
  }
  
  private static bool CmpMarginHeight(DXW.Frame openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.MarginHeight>()?.Val, value, diffs, objName, "MarginHeight");
  }
  
  private static void SetMarginHeight(DXW.Frame openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.MarginHeight,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region FrameScrollbarVisibility conversion.
  private static DMW.FrameScrollbarVisibilityKind? GetScrollbarVisibility(DXW.Frame openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>()?.Val?.Value);
  }
  
  private static bool CmpScrollbarVisibility(DXW.Frame openXmlElement, DMW.FrameScrollbarVisibilityKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetScrollbarVisibility(DXW.Frame openXmlElement, DMW.FrameScrollbarVisibilityKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(itemElement, (DMW.FrameScrollbarVisibilityKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.ScrollbarVisibility, DXW.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>((DMW.FrameScrollbarVisibilityKind)value));
  }
  #endregion

  #region NoResizeAllowed conversion.
  private static Boolean GetNoResizeAllowed(DXW.Frame openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoResizeAllowed>());
  }
  
  private static bool CmpNoResizeAllowed(DXW.Frame openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoResizeAllowed>(), value, diffs, objName, propName);
  }
  
  private static void SetNoResizeAllowed(DXW.Frame openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.NoResizeAllowed>(openXmlElement, value);
  }
  #endregion

  #region LinkedToFile conversion.
  private static Boolean GetLinkedToFile(DXW.Frame openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.LinkedToFile>());
  }
  
  private static bool CmpLinkedToFile(DXW.Frame openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LinkedToFile>(), value, diffs, objName, propName);
  }
  
  private static void SetLinkedToFile(DXW.Frame openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.LinkedToFile>(openXmlElement, value);
  }
  #endregion

  #region Frame model conversion.
  public static DMW.Frame? CreateModelElement(DXW.Frame? openXmlElement, DXW.WebSettings? settings = null)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Frame();
      model.FrameSize = GetFrameSize(openXmlElement);
      model.FrameName = GetFrameName(openXmlElement);
      model.FrameSourceFile = GetSourceFileReference(openXmlElement, settings);
      model.MarginWidth = GetMarginWidth(openXmlElement);
      model.MarginHeight = GetMarginHeight(openXmlElement);
      model.ScrollbarVisibility = GetScrollbarVisibility(openXmlElement);
      model.NoResizeAllowed = GetNoResizeAllowed(openXmlElement);
      model.LinkedToFile = GetLinkedToFile(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Frame? openXmlElement, DMW.Frame? model, DiffList? diffs, string? objName, string? propName,
    DXW.WebSettings? settings = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFrameSize(openXmlElement, model.FrameSize, diffs, objName, propName))
        ok = false;
      if (!CmpFrameName(openXmlElement, model.FrameName, diffs, objName, propName))
        ok = false;
      if (!CmpSourceFileReference(openXmlElement, model.FrameSourceFile, diffs, objName, propName, settings))
        ok = false;
      if (!CmpMarginWidth(openXmlElement, model.MarginWidth, diffs, objName, propName))
        ok = false;
      if (!CmpMarginHeight(openXmlElement, model.MarginHeight, diffs, objName, propName))
        ok = false;
      if (!CmpScrollbarVisibility(openXmlElement, model.ScrollbarVisibility, diffs, objName, propName))
        ok = false;
      if (!CmpNoResizeAllowed(openXmlElement, model.NoResizeAllowed, diffs, objName, propName))
        ok = false;
      if (!CmpLinkedToFile(openXmlElement, model.LinkedToFile, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.Frame CreateOpenXmlElement(DMW.Frame model, DXW.WebSettings? settings = null)
  {
    var openXmlElement = new DXW.Frame();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.Frame openXmlElement, DMW.Frame model, DXW.WebSettings? settings = null)
  {
    SetFrameSize(openXmlElement, model?.FrameSize);
    SetFrameName(openXmlElement, model?.FrameName);
    SetSourceFileReference(openXmlElement, model?.FrameSourceFile, settings);
    SetMarginWidth(openXmlElement, model?.MarginWidth);
    SetMarginHeight(openXmlElement, model?.MarginHeight);
    SetScrollbarVisibility(openXmlElement, model?.ScrollbarVisibility);
    SetNoResizeAllowed(openXmlElement, model?.NoResizeAllowed);
    SetLinkedToFile(openXmlElement, model?.LinkedToFile);
    return true;
  }
  #endregion
}
