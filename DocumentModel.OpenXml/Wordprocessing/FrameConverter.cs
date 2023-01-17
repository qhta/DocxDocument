namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public static class FrameConverter
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  private static String? GetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.FrameSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  private static String? GetFrameName(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFrameName(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.FrameName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  private static DocumentModel.Wordprocessing.RelationshipType? GetSourceFileReference(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SourceFileReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSourceFileReference(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SourceFileReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SourceFileReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  private static UInt32? GetMarginWidth(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MarginWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMarginWidth(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MarginWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.MarginWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  private static UInt32? GetMarginHeight(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MarginHeight>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMarginHeight(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MarginHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.MarginHeight{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  private static DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? GetScrollbarVisibility(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetScrollbarVisibility(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility, DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoResizeAllowed(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoResizeAllowed(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetLinkedToFile(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLinkedToFile(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Frame? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Frame? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Frame, new()
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
