using DocumentFormat.OpenXml.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using ParagraphBorders = DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ParagraphBorders Class.
/// </summary>
public static class ParagraphBordersConverter
{
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public static BorderType? GetTopBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<TopBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  public static BorderType? GetLeftBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<LeftBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public static BorderType? GetBottomBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<BottomBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  public static BorderType? GetRightBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<RightBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public static BorderType? GetBetweenBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BetweenBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBetweenBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BetweenBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<BetweenBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  public static BorderType? GetBarBorder(ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BarBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBarBorder(ParagraphBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<BarBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ParagraphBorders? CreateModelElement(ParagraphBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.BetweenBorder = GetBetweenBorder(openXmlElement);
      value.BarBorder = GetBarBorder(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphBorders? value)
    where OpenXmlElementType : ParagraphBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetBetweenBorder(openXmlElement, value?.BetweenBorder);
      SetBarBorder(openXmlElement, value?.BarBorder);
      return openXmlElement;
    }
    return default;
  }
}