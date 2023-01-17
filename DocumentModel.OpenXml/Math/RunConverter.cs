namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DocumentModel.Math.RunProperties? GetMathRunProperties(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMathRunProperties(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Math.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Break? GetBreak(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBreak(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BreakConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Break>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextType? GetText(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetText(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextType? GetDeletedText(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedText(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextType? GetFieldCode(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFieldCode(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FieldCode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextType? GetDeletedFieldCode(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedFieldCode(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoBreakHyphen(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
    return itemElement != null;
  }
  
  private static void SetNoBreakHyphen(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSoftHyphen(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
    return itemElement != null;
  }
  
  private static void SetSoftHyphen(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SoftHyphen();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDayShort(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayShort>();
    return itemElement != null;
  }
  
  private static void SetDayShort(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DayShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetMonthShort(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
    return itemElement != null;
  }
  
  private static void SetMonthShort(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MonthShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetYearShort(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearShort>();
    return itemElement != null;
  }
  
  private static void SetYearShort(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.YearShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDayLong(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayLong>();
    return itemElement != null;
  }
  
  private static void SetDayLong(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DayLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetMonthLong(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
    return itemElement != null;
  }
  
  private static void SetMonthLong(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MonthLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetYearLong(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearLong>();
    return itemElement != null;
  }
  
  private static void SetYearLong(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.YearLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAnnotationReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
    return itemElement != null;
  }
  
  private static void SetAnnotationReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetFootnoteReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
    return itemElement != null;
  }
  
  private static void SetFootnoteReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEndnoteReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
    return itemElement != null;
  }
  
  private static void SetEndnoteReferenceMark(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSeparatorMark(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
    return itemElement != null;
  }
  
  private static void SetSeparatorMark(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SeparatorMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetContinuationSeparatorMark(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
    return itemElement != null;
  }
  
  private static void SetContinuationSeparatorMark(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SymbolChar? GetSymbolChar(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SymbolCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSymbolChar(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.SymbolChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SymbolCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetPageNumber(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
    return itemElement != null;
  }
  
  private static void SetPageNumber(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PageNumber();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetCarriageReturn(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
    return itemElement != null;
  }
  
  private static void SetCarriageReturn(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.CarriageReturn();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTabChar(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabChar>();
    return itemElement != null;
  }
  
  private static void SetTabChar(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabChar>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TabChar();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.EmbeddedObject? GetEmbeddedObject(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EmbeddedObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbeddedObject(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.EmbeddedObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.EmbeddedObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Picture? GetPicture(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPicture(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.Picture? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PictureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Picture>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.FieldChar? GetFieldChar(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FieldCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFieldChar(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.FieldChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FieldCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FieldChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Ruby? GetRuby(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RubyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRuby(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.Ruby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Ruby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? GetFootnoteReference(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFootnoteReference(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? GetEndnoteReference(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndnoteReference(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCommentReference(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentReference(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CommentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Drawing? GetDrawing(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDrawing(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PositionalTab? GetPositionalTab(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PositionalTabConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPositionalTab(DocumentFormat.OpenXml.Math.Run openXmlElement, DocumentModel.Wordprocessing.PositionalTab? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PositionalTabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLastRenderedPageBreak(DocumentFormat.OpenXml.Math.Run openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
    return itemElement != null;
  }
  
  private static void SetLastRenderedPageBreak(DocumentFormat.OpenXml.Math.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Run? CreateModelElement(DocumentFormat.OpenXml.Math.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Run();
      value.MathRunProperties = GetMathRunProperties(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Run? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMathRunProperties(openXmlElement, value?.MathRunProperties);
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
