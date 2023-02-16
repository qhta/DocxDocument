namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public static class FrameConverter
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  private static String? GetFrameSize(DXW.Frame openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.FrameSize>()?.Val?.Value;
  }
  
  private static bool CmpFrameSize(DXW.Frame openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "FrameSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetFrameSize(DXW.Frame openXmlElement, String? value)
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
  /// Frame Name.
  /// </summary>
  private static String? GetFrameName(DXW.Frame openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FrameName>()?.Val?.Value;
  }
  
  private static bool CmpFrameName(DXW.Frame openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FrameName>()?.Val?.Value == value;
  }
  
  private static void SetFrameName(DXW.Frame openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FrameName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  private static DMW.RelationshipType? GetSourceFileReference(DXW.Frame openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SourceFileReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSourceFileReference(DXW.Frame openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SourceFileReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSourceFileReference(DXW.Frame openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SourceFileReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SourceFileReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  private static UInt32? GetMarginWidth(DXW.Frame openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.MarginWidth>()?.Val?.Value;
  }
  
  private static bool CmpMarginWidth(DXW.Frame openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MarginWidth>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.MarginWidth", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetMarginWidth(DXW.Frame openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MarginWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.MarginWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  private static UInt32? GetMarginHeight(DXW.Frame openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.MarginHeight>()?.Val?.Value;
  }
  
  private static bool CmpMarginHeight(DXW.Frame openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MarginHeight>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.MarginHeight", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetMarginHeight(DXW.Frame openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MarginHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.MarginHeight{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  private static DMW.FrameScrollbarVisibilityKind? GetScrollbarVisibility(DXW.Frame openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>()?.Val?.Value);
  }
  
  private static bool CmpScrollbarVisibility(DXW.Frame openXmlElement, DMW.FrameScrollbarVisibilityKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScrollbarVisibility(DXW.Frame openXmlElement, DMW.FrameScrollbarVisibilityKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.ScrollbarVisibility, DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  private static Boolean? GetNoResizeAllowed(DXW.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoResizeAllowed>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpNoResizeAllowed(DXW.Frame openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoResizeAllowed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNoResizeAllowed(DXW.Frame openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoResizeAllowed>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoResizeAllowed();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  private static Boolean? GetLinkedToFile(DXW.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkedToFile>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpLinkedToFile(DXW.Frame openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LinkedToFile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLinkedToFile(DXW.Frame openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LinkedToFile>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LinkedToFile();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Frame? CreateModelElement(DXW.Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Frame();
      value.FrameSize = GetFrameSize(openXmlElement);
      value.FrameName = GetFrameName(openXmlElement);
      value.SourceFileReference = GetSourceFileReference(openXmlElement);
      value.MarginWidth = GetMarginWidth(openXmlElement);
      value.MarginHeight = GetMarginHeight(openXmlElement);
      value.ScrollbarVisibility = GetScrollbarVisibility(openXmlElement);
      value.NoResizeAllowed = GetNoResizeAllowed(openXmlElement);
      value.LinkedToFile = GetLinkedToFile(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Frame? openXmlElement, DMW.Frame? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFrameSize(openXmlElement, value.FrameSize, diffs, objName))
        ok = false;
      if (!CmpFrameName(openXmlElement, value.FrameName, diffs, objName))
        ok = false;
      if (!CmpSourceFileReference(openXmlElement, value.SourceFileReference, diffs, objName))
        ok = false;
      if (!CmpMarginWidth(openXmlElement, value.MarginWidth, diffs, objName))
        ok = false;
      if (!CmpMarginHeight(openXmlElement, value.MarginHeight, diffs, objName))
        ok = false;
      if (!CmpScrollbarVisibility(openXmlElement, value.ScrollbarVisibility, diffs, objName))
        ok = false;
      if (!CmpNoResizeAllowed(openXmlElement, value.NoResizeAllowed, diffs, objName))
        ok = false;
      if (!CmpLinkedToFile(openXmlElement, value.LinkedToFile, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Frame? value)
    where OpenXmlElementType: DXW.Frame, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFrameSize(openXmlElement, value?.FrameSize);
      SetFrameName(openXmlElement, value?.FrameName);
      SetSourceFileReference(openXmlElement, value?.SourceFileReference);
      SetMarginWidth(openXmlElement, value?.MarginWidth);
      SetMarginHeight(openXmlElement, value?.MarginHeight);
      SetScrollbarVisibility(openXmlElement, value?.ScrollbarVisibility);
      SetNoResizeAllowed(openXmlElement, value?.NoResizeAllowed);
      SetLinkedToFile(openXmlElement, value?.LinkedToFile);
      return openXmlElement;
    }
    return default;
  }
}
