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
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.FrameName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SourceFileReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MarginWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MarginHeight>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ScrollbarVisibility>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(itemElement.Val.Value);
    return null;
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
  private static DMW.OnOffOnlyKind? GetNoResizeAllowed(DXW.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoResizeAllowed>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoResizeAllowed(DXW.Frame openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoResizeAllowed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.NoResizeAllowed, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetLinkedToFile(DXW.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkedToFile>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLinkedToFile(DXW.Frame openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkedToFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.LinkedToFile, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Frame? CreateModelElement(DXW.Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Frame();
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
