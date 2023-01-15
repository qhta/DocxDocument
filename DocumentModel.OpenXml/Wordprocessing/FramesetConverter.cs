using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Frame = DocumentModel.Wordprocessing.Frame;
using Frameset = DocumentFormat.OpenXml.Wordprocessing.Frameset;
using FramesetSplitbar = DocumentModel.Wordprocessing.FramesetSplitbar;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Nested Frameset Definition.
/// </summary>
public static class FramesetConverter
{
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public static String? GetFrameSize(Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFrameSize(Frameset? openXmlElement, String? value)
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
  ///   Frameset Splitter Properties.
  /// </summary>
  public static FramesetSplitbar? GetFramesetSplitbar(Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
    if (itemElement != null)
      return FramesetSplitbarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFramesetSplitbar(Frameset? openXmlElement, FramesetSplitbar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramesetSplitbarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public static FrameLayoutKind? GetFrameLayout(Frameset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FrameLayout>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FrameLayoutValues, FrameLayoutKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetFrameLayout(Frameset? openXmlElement, FrameLayoutKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FrameLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<FrameLayout, FrameLayoutValues, FrameLayoutKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Frameset? GetChildFrameset(Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Frameset>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildFrameset(Frameset? openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Frameset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<Frameset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Frame? GetFrame(Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
    if (itemElement != null)
      return FrameConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFrame(Frameset? openXmlElement, Frame? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FrameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Frame>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Frameset? CreateModelElement(Frameset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Frameset();
      value.FrameSize = GetFrameSize(openXmlElement);
      value.FramesetSplitbar = GetFramesetSplitbar(openXmlElement);
      value.FrameLayout = GetFrameLayout(openXmlElement);
      value.ChildFrameset = GetChildFrameset(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Frameset? value)
    where OpenXmlElementType : Frameset, new()
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