using DocumentFormat.OpenXml.Wordprocessing;
using Break = DocumentModel.Wordprocessing.Break;
using Drawing = DocumentModel.Wordprocessing.Drawing;
using EmbeddedObject = DocumentModel.Wordprocessing.EmbeddedObject;
using FieldChar = DocumentModel.Wordprocessing.FieldChar;
using FootnoteEndnoteReferenceType = DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType;
using MarkupType = DocumentModel.Wordprocessing.MarkupType;
using Picture = DocumentModel.Wordprocessing.Picture;
using PositionalTab = DocumentModel.Wordprocessing.PositionalTab;
using Ruby = DocumentModel.Wordprocessing.Ruby;
using RunProperties = DocumentModel.Wordprocessing.RunProperties;
using SymbolChar = DocumentModel.Wordprocessing.SymbolChar;
using TextType = DocumentModel.Wordprocessing.TextType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Phonetic Guide Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  public static Byte[]? GetRsidRunProperties(Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunProperties.Value);
    return null;
  }

  public static void SetRsidRunProperties(Run? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidRunProperties = Convert.ToHexString(value);
      else
        openXmlElement.RsidRunProperties = null;
    }
  }

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  public static Byte[]? GetRsidRunDeletion(Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunDeletion.Value);
    return null;
  }

  public static void SetRsidRunDeletion(Run? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidRunDeletion = Convert.ToHexString(value);
      else
        openXmlElement.RsidRunDeletion = null;
    }
  }

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  public static Byte[]? GetRsidRunAddition(Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunAddition.Value);
    return null;
  }

  public static void SetRsidRunAddition(Run? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidRunAddition = Convert.ToHexString(value);
      else
        openXmlElement.RsidRunAddition = null;
    }
  }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  public static RunProperties? GetRunProperties(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(Run? openXmlElement, RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Break? GetBreak(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
    if (itemElement != null)
      return BreakConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBreak(Run? openXmlElement, Break? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BreakConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Break>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextType? GetText(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Text>();
    if (itemElement != null)
      return TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetText(Run? openXmlElement, TextType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextTypeConverter.CreateOpenXmlElement<Text>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextType? GetDeletedText(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DeletedText>();
    if (itemElement != null)
      return TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedText(Run? openXmlElement, TextType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DeletedText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextTypeConverter.CreateOpenXmlElement<DeletedText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextType? GetFieldCode(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FieldCode>();
    if (itemElement != null)
      return TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFieldCode(Run? openXmlElement, TextType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FieldCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextTypeConverter.CreateOpenXmlElement<FieldCode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextType? GetDeletedFieldCode(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DeletedFieldCode>();
    if (itemElement != null)
      return TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedFieldCode(Run? openXmlElement, TextType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DeletedFieldCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextTypeConverter.CreateOpenXmlElement<DeletedFieldCode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoBreakHyphen(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoBreakHyphen>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoBreakHyphen(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoBreakHyphen>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoBreakHyphen();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSoftHyphen(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SoftHyphen>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSoftHyphen(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SoftHyphen>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SoftHyphen();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDayShort(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DayShort>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDayShort(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DayShort>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DayShort();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetMonthShort(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MonthShort>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMonthShort(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MonthShort>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MonthShort();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetYearShort(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<YearShort>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetYearShort(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<YearShort>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new YearShort();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDayLong(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DayLong>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDayLong(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DayLong>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DayLong();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetMonthLong(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MonthLong>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMonthLong(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MonthLong>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MonthLong();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetYearLong(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<YearLong>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetYearLong(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<YearLong>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new YearLong();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAnnotationReferenceMark(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnnotationReferenceMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAnnotationReferenceMark(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AnnotationReferenceMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AnnotationReferenceMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetFootnoteReferenceMark(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnoteReferenceMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFootnoteReferenceMark(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<FootnoteReferenceMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new FootnoteReferenceMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetEndnoteReferenceMark(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndnoteReferenceMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEndnoteReferenceMark(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<EndnoteReferenceMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new EndnoteReferenceMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSeparatorMark(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SeparatorMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSeparatorMark(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SeparatorMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SeparatorMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetContinuationSeparatorMark(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContinuationSeparatorMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetContinuationSeparatorMark(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ContinuationSeparatorMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ContinuationSeparatorMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SymbolChar? GetSymbolChar(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
    if (itemElement != null)
      return SymbolCharConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSymbolChar(Run? openXmlElement, SymbolChar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SymbolCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetPageNumber(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PageNumber>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPageNumber(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PageNumber>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PageNumber();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetCarriageReturn(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CarriageReturn>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCarriageReturn(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<CarriageReturn>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new CarriageReturn();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTabChar(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TabChar>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTabChar(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TabChar>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TabChar();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EmbeddedObject? GetEmbeddedObject(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
    if (itemElement != null)
      return EmbeddedObjectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEmbeddedObject(Run? openXmlElement, EmbeddedObject? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbeddedObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Picture? GetPicture(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
    if (itemElement != null)
      return PictureConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPicture(Run? openXmlElement, Picture? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Picture>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FieldChar? GetFieldChar(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
    if (itemElement != null)
      return FieldCharConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFieldChar(Run? openXmlElement, FieldChar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FieldCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FieldChar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Ruby? GetRuby(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
    if (itemElement != null)
      return RubyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRuby(Run? openXmlElement, Ruby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Ruby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FootnoteEndnoteReferenceType? GetFootnoteReference(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FootnoteReference>();
    if (itemElement != null)
      return FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFootnoteReference(Run? openXmlElement, FootnoteEndnoteReferenceType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnoteReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<FootnoteReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FootnoteEndnoteReferenceType? GetEndnoteReference(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndnoteReference>();
    if (itemElement != null)
      return FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndnoteReference(Run? openXmlElement, FootnoteEndnoteReferenceType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndnoteReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<EndnoteReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCommentReference(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentReference>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentReference(Run? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CommentReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CommentReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Drawing? GetDrawing(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DrawingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDrawing(Run? openXmlElement, Drawing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PositionalTab? GetPositionalTab(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
    if (itemElement != null)
      return PositionalTabConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPositionalTab(Run? openXmlElement, PositionalTab? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositionalTabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetLastRenderedPageBreak(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LastRenderedPageBreak>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLastRenderedPageBreak(Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LastRenderedPageBreak>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LastRenderedPageBreak();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Run? CreateModelElement(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Run();
      value.RsidRunProperties = GetRsidRunProperties(openXmlElement);
      value.RsidRunDeletion = GetRsidRunDeletion(openXmlElement);
      value.RsidRunAddition = GetRsidRunAddition(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.DeletedText = GetDeletedText(openXmlElement);
      value.FieldCode = GetFieldCode(openXmlElement);
      value.DeletedFieldCode = GetDeletedFieldCode(openXmlElement);
      value.NoBreakHyphen = GetNoBreakHyphen(openXmlElement);
      value.SoftHyphen = GetSoftHyphen(openXmlElement);
      value.DayShort = GetDayShort(openXmlElement);
      value.MonthShort = GetMonthShort(openXmlElement);
      value.YearShort = GetYearShort(openXmlElement);
      value.DayLong = GetDayLong(openXmlElement);
      value.MonthLong = GetMonthLong(openXmlElement);
      value.YearLong = GetYearLong(openXmlElement);
      value.AnnotationReferenceMark = GetAnnotationReferenceMark(openXmlElement);
      value.FootnoteReferenceMark = GetFootnoteReferenceMark(openXmlElement);
      value.EndnoteReferenceMark = GetEndnoteReferenceMark(openXmlElement);
      value.SeparatorMark = GetSeparatorMark(openXmlElement);
      value.ContinuationSeparatorMark = GetContinuationSeparatorMark(openXmlElement);
      value.SymbolChar = GetSymbolChar(openXmlElement);
      value.PageNumber = GetPageNumber(openXmlElement);
      value.CarriageReturn = GetCarriageReturn(openXmlElement);
      value.TabChar = GetTabChar(openXmlElement);
      value.EmbeddedObject = GetEmbeddedObject(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      value.FieldChar = GetFieldChar(openXmlElement);
      value.Ruby = GetRuby(openXmlElement);
      value.FootnoteReference = GetFootnoteReference(openXmlElement);
      value.EndnoteReference = GetEndnoteReference(openXmlElement);
      value.CommentReference = GetCommentReference(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      value.PositionalTab = GetPositionalTab(openXmlElement);
      value.LastRenderedPageBreak = GetLastRenderedPageBreak(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Run? value)
    where OpenXmlElementType : Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRunProperties(openXmlElement, value?.RsidRunProperties);
      SetRsidRunDeletion(openXmlElement, value?.RsidRunDeletion);
      SetRsidRunAddition(openXmlElement, value?.RsidRunAddition);
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetBreak(openXmlElement, value?.Break);
      SetText(openXmlElement, value?.Text);
      SetDeletedText(openXmlElement, value?.DeletedText);
      SetFieldCode(openXmlElement, value?.FieldCode);
      SetDeletedFieldCode(openXmlElement, value?.DeletedFieldCode);
      SetNoBreakHyphen(openXmlElement, value?.NoBreakHyphen);
      SetSoftHyphen(openXmlElement, value?.SoftHyphen);
      SetDayShort(openXmlElement, value?.DayShort);
      SetMonthShort(openXmlElement, value?.MonthShort);
      SetYearShort(openXmlElement, value?.YearShort);
      SetDayLong(openXmlElement, value?.DayLong);
      SetMonthLong(openXmlElement, value?.MonthLong);
      SetYearLong(openXmlElement, value?.YearLong);
      SetAnnotationReferenceMark(openXmlElement, value?.AnnotationReferenceMark);
      SetFootnoteReferenceMark(openXmlElement, value?.FootnoteReferenceMark);
      SetEndnoteReferenceMark(openXmlElement, value?.EndnoteReferenceMark);
      SetSeparatorMark(openXmlElement, value?.SeparatorMark);
      SetContinuationSeparatorMark(openXmlElement, value?.ContinuationSeparatorMark);
      SetSymbolChar(openXmlElement, value?.SymbolChar);
      SetPageNumber(openXmlElement, value?.PageNumber);
      SetCarriageReturn(openXmlElement, value?.CarriageReturn);
      SetTabChar(openXmlElement, value?.TabChar);
      SetEmbeddedObject(openXmlElement, value?.EmbeddedObject);
      SetPicture(openXmlElement, value?.Picture);
      SetFieldChar(openXmlElement, value?.FieldChar);
      SetRuby(openXmlElement, value?.Ruby);
      SetFootnoteReference(openXmlElement, value?.FootnoteReference);
      SetEndnoteReference(openXmlElement, value?.EndnoteReference);
      SetCommentReference(openXmlElement, value?.CommentReference);
      SetDrawing(openXmlElement, value?.Drawing);
      SetPositionalTab(openXmlElement, value?.PositionalTab);
      SetLastRenderedPageBreak(openXmlElement, value?.LastRenderedPageBreak);
      return openXmlElement;
    }
    return default;
  }
}