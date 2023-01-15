using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Frame = DocumentFormat.OpenXml.Wordprocessing.Frame;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Single Frame Properties.
/// </summary>
public static class FrameConverter
{
  /// <summary>
  ///   Frame Size.
  /// </summary>
  public static String? GetFrameSize(Frame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFrameSize(Frame? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FrameSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FrameSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Frame Name.
  /// </summary>
  public static String? GetFrameName(Frame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FrameName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFrameName(Frame? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FrameName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FrameName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  public static RelationshipType? GetSourceFileReference(Frame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SourceFileReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSourceFileReference(Frame? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SourceFileReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<SourceFileReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  public static UInt32? GetMarginWidth(Frame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MarginWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMarginWidth(Frame? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MarginWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MarginWidth { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  public static UInt32? GetMarginHeight(Frame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MarginHeight>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMarginHeight(Frame? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MarginHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MarginHeight { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  public static FrameScrollbarVisibilityKind? GetScrollbarVisibility(Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ScrollbarVisibility>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FrameScrollbarVisibilityValues, FrameScrollbarVisibilityKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetScrollbarVisibility(Frame? openXmlElement, FrameScrollbarVisibilityKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ScrollbarVisibility>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ScrollbarVisibility, FrameScrollbarVisibilityValues, FrameScrollbarVisibilityKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  public static OnOffOnlyKind? GetNoResizeAllowed(Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoResizeAllowed>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNoResizeAllowed(Frame? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoResizeAllowed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NoResizeAllowed, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  public static OnOffOnlyKind? GetLinkedToFile(Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkedToFile>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLinkedToFile(Frame? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkedToFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LinkedToFile, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Frame? CreateModelElement(Frame? openXmlElement)
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
    where OpenXmlElementType : Frame, new()
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