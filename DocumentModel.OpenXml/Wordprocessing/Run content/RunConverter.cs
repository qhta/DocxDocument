using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Text run element converter
/// </summary>
public static class RunConverter
{
  #region Revision Identifier for Run conversion
  public static DM.HexInt? GetRsidRunProperties(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunProperties.Value);
    return null;
  }

  public static bool CmpRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunProperties?.Value, model, diffs, objName, "RsidRunProperties");
  }

  public static void SetRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidRunProperties = model.ToString();
    else
      openXmlElement.RsidRunProperties = null;
  }
  #endregion

  #region Revision Identifier for Run Deletion conversion
  public static DM.HexInt? GetRsidRunDeletion(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunDeletion.Value);
    return null;
  }

  public static bool CmpRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunDeletion?.Value, model, diffs, objName, "RsidRunDeletion");
  }

  public static void SetRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidRunDeletion = model.ToString();
    else
      openXmlElement.RsidRunDeletion = null;
  }
  #endregion

  #region Revision Identifier for Run Addtion conversion
  public static DM.HexInt? GetRsidRunAddition(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunAddition.Value);
    return null;
  }

  public static bool CmpRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunAddition?.Value, model, diffs, objName, "RsidRunAddition");
  }

  public static void SetRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidRunAddition = model.ToString();
    else
      openXmlElement.RsidRunAddition = null;
  }
  #endregion

  #region Run Properties conversion
  public static DMW.RunProperties? GetRunProperties(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpRunProperties(DXW.Run openXmlElement, DMW.RunProperties? model, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), model, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  public static void SetRunProperties(DXW.Run openXmlElement, DMW.RunProperties? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Run content conversion
  public static DMW.IRunContent? CreateRunContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Text text)
      return DMXW.TextTypeConverter.CreateModelElement(text);
    if (openXmlElement is DXW.DeletedText deletedText)
      return DMXW.TextTypeConverter.CreateModelElement(deletedText);
    if (openXmlElement is DXW.FieldCode fieldCode)
      return DMXW.TextTypeConverter.CreateModelElement(fieldCode);
    if (openXmlElement is DXW.DeletedFieldCode deletedFieldCode)
      return DMXW.TextTypeConverter.CreateModelElement(deletedFieldCode);
    if (openXmlElement is DXW.FieldChar fieldChar)
      return DMXW.FieldCharConverter.CreateModelElement(fieldChar);
    if (openXmlElement is DXW.Break brk)
      return DMXW.BreakConverter.CreateModelElement(brk);
    if (openXmlElement is DXW.LastRenderedPageBreak lastRenderedPageBreak)
      return DMXW.LastRenderedPageBreakConverter.CreateModelElement(lastRenderedPageBreak);
    if (openXmlElement is DXW.NoBreakHyphen noBreakHyphen)
      return DMXW.HyphenConverter.CreateModelElement(noBreakHyphen);
    if (openXmlElement is DXW.FootnoteReference footnoteReference)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(footnoteReference);
    if (openXmlElement is DXW.EndnoteReference endnoteReference)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(endnoteReference);
    if (openXmlElement is DXW.CommentReference commentReference)
      return DMXW.MarkupTypeConverter.CreateModelElement(commentReference);
    if (openXmlElement is DXW.FootnoteReferenceMark footnoteReferenceMark)
      return DMXW.NoteReferenceMarkConverter.CreateModelElement(footnoteReferenceMark);
    if (openXmlElement is DXW.EndnoteReferenceMark endnoteReferenceMark)
      return DMXW.NoteReferenceMarkConverter.CreateModelElement(endnoteReferenceMark);
    if (openXmlElement is DXW.AnnotationReferenceMark annotationReferenceMark)
      return DMXW.NoteReferenceMarkConverter.CreateModelElement(annotationReferenceMark);
    if (openXmlElement is DXW.SeparatorMark separatorMark)
      return DMXW.SeparatorMarkConverter.CreateModelElement(separatorMark);
    if (openXmlElement is DXW.ContinuationSeparatorMark continuationSeparatorMark)
      return DMXW.SeparatorMarkConverter.CreateModelElement(continuationSeparatorMark);
    if (openXmlElement is DXW.SymbolChar symbolChar)
      return DMXW.SymbolCharConverter.CreateModelElement(symbolChar);
    if (openXmlElement is DXW.PageNumber pageNumber)
      return DMXW.PageNumberConverter.CreateModelElement(pageNumber);
    if (openXmlElement is DXW.CarriageReturn carriageReturn)
      return DMXW.CarriageReturnConverter.CreateModelElement(carriageReturn);
    if (openXmlElement is DXW.TabChar tabChar)
      return DMXW.TabCharConverter.CreateModelElement(tabChar);
    if (openXmlElement is DXW.PositionalTab positionalTab)
      return DMXW.PositionalTabConverter.CreateModelElement(positionalTab);
    if (openXmlElement is DXW.SoftHyphen softHyphen)
      return DMXW.HyphenConverter.CreateModelElement(softHyphen);
    if (openXmlElement is DXW.DayShort dayShort)
      return DMXW.RunDateConverter.CreateModelElement(dayShort);
    if (openXmlElement is DXW.DayShort dayLong)
      return DMXW.RunDateConverter.CreateModelElement(dayLong);
    if (openXmlElement is DXW.DayShort monthShort)
      return DMXW.RunDateConverter.CreateModelElement(monthShort);
    if (openXmlElement is DXW.DayShort monthLong)
      return DMXW.RunDateConverter.CreateModelElement(monthLong);
    if (openXmlElement is DXW.DayShort yearShort)
      return DMXW.RunDateConverter.CreateModelElement(yearShort);
    if (openXmlElement is DXW.DayShort yearLong)
      return DMXW.RunDateConverter.CreateModelElement(yearLong);
    if (openXmlElement is DXW.EmbeddedObject embeddedObject)
      return DMXW.EmbeddedObjectConverter.CreateModelElement(embeddedObject);
    if (openXmlElement is DXW.Picture picture)
      return DMXW.PictureConverter.CreateModelElement(picture);
    if (openXmlElement is DXW.Drawing drawing)
      return DMXW.DrawingConverter.CreateModelElement(drawing);
    if (openXmlElement is DXW.Ruby ruby)
      return DMXW.RubyConverter.CreateModelElement(ruby);
    if (openXmlElement is DXW.ContentPart contentPart)
      return ContentPartConverter.CreateModelElement(contentPart);
    if (openXmlElement is DX.AlternateContent alternateContent)
      return AlternateContentConverter.CreateModelElement(alternateContent);

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Run.CreateModelElement method");
    return null;
  }

  public static bool CompareRunContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Text text && model is DMW.Text textModel)
        return DMXW.TextTypeConverter.CompareModelElement(text, textModel, diffs, objName);
      if (openXmlElement is DXW.DeletedText deletedText && model is DMW.Text deletedTextModel)
        return DMXW.TextTypeConverter.CompareModelElement(deletedText, deletedTextModel, diffs, objName);
      if (openXmlElement is DXW.FieldCode fieldCode && model is DMW.FieldCode fieldCodeModel)
        return DMXW.TextTypeConverter.CompareModelElement(fieldCode, fieldCodeModel, diffs, objName);
      if (openXmlElement is DXW.DeletedFieldCode deletedFieldCode && model is DMW.FieldCode deletedFieldCodeModel)
        return DMXW.TextTypeConverter.CompareModelElement(deletedFieldCode, deletedFieldCodeModel, diffs, objName);
      if (openXmlElement is DXW.FieldChar fieldChar && model is DMW.FieldChar fieldCharModel)
        return DMXW.FieldCharConverter.CompareModelElement(fieldChar, fieldCharModel, diffs, objName);
      if (openXmlElement is DXW.Break brk && model is DMW.Break brkModel)
        return DMXW.BreakConverter.CompareModelElement(brk, brkModel, diffs, objName);
      if (openXmlElement is DXW.LastRenderedPageBreak lastRenderedPageBreak && model is DMW.LastRenderedPageBreak lastRenderedPageBreakModel)
        return DMXW.LastRenderedPageBreakConverter.CompareModelElement(lastRenderedPageBreak, lastRenderedPageBreakModel, diffs, objName);
      if (openXmlElement is DXW.NoBreakHyphen noBreakHyphen && model is Hyphen noBreakHyphenModel)
        return DMXW.HyphenConverter.CompareModelElement(noBreakHyphen, noBreakHyphenModel, diffs, objName);
      if (openXmlElement is DXW.FootnoteReference footnoteReference && model is NoteReference footnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(footnoteReference, footnoteReferenceModel, diffs, objName);
      if (openXmlElement is DXW.EndnoteReference endnoteReference && model is NoteReference endnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(endnoteReference, endnoteReferenceModel, diffs, objName);
      if (openXmlElement is DXW.CommentReference commentReference && model is DMW.CommentReference commentReferenceModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(commentReference, commentReferenceModel, diffs, objName);
      if (openXmlElement is DXW.FootnoteReferenceMark footnoteReferenceMark && model is NoteReferenceMark footnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(footnoteReferenceMark, footnoteReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.EndnoteReferenceMark endnoteReferenceMark && model is NoteReferenceMark endnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(endnoteReferenceMark, endnoteReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.AnnotationReferenceMark annotationReferenceMark && model is NoteReferenceMark annotationReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(annotationReferenceMark, annotationReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.SeparatorMark separatorMark && model is DMW.SeparatorMark separatorMarkModel)
        return DMXW.SeparatorMarkConverter.CompareModelElement(separatorMark, separatorMarkModel, diffs, objName);
      if (openXmlElement is DXW.ContinuationSeparatorMark continuationSeparatorMark && model is DMW.SeparatorMark continuationSeparatorMarkModel)
        return DMXW.SeparatorMarkConverter.CompareModelElement(continuationSeparatorMark, continuationSeparatorMarkModel, diffs, objName);
      if (openXmlElement is DXW.SymbolChar symbolChar && model is DMW.SymbolChar symbolCharModel)
        return DMXW.SymbolCharConverter.CompareModelElement(symbolChar, symbolCharModel, diffs, objName);
      if (openXmlElement is DXW.PageNumber pageNumber && model is DMW.PageNumber pageNumberModel)
        return DMXW.PageNumberConverter.CompareModelElement(pageNumber, pageNumberModel, diffs, objName);
      if (openXmlElement is DXW.CarriageReturn carriageReturn && model is CarriageReturn carriageReturnModel)
        return DMXW.CarriageReturnConverter.CompareModelElement(carriageReturn, carriageReturnModel, diffs, objName);
      if (openXmlElement is DXW.TabChar tabChar && model is DMW.TabChar tabCharModel)
        return DMXW.TabCharConverter.CompareModelElement(tabChar, tabCharModel, diffs, objName);
      if (openXmlElement is DXW.PositionalTab positionalTab && model is DMW.PositionalTab positionalTabModel)
        return DMXW.PositionalTabConverter.CompareModelElement(positionalTab, positionalTabModel, diffs, objName);
      if (openXmlElement is DXW.SoftHyphen softHyphen && model is Hyphen softHyphenModel)
        return DMXW.HyphenConverter.CompareModelElement(softHyphen, softHyphenModel, diffs, objName);
      if (openXmlElement is DXW.DayShort dayShort && model is DMW.RunDate dayShortModel)
        return DMXW.RunDateConverter.CompareModelElement(dayShort, dayShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort dayLong && model is DMW.RunDate dayLongModel)
        return DMXW.RunDateConverter.CompareModelElement(dayLong, dayLongModel, diffs, objName);
      if (openXmlElement is DXW.DayShort monthShort && model is DMW.RunDate monthShortModel)
        return DMXW.RunDateConverter.CompareModelElement(monthShort, monthShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort monthLong && model is DMW.RunDate monthLongModel)
        return DMXW.RunDateConverter.CompareModelElement(monthLong, monthLongModel, diffs, objName);
      if (openXmlElement is DXW.DayShort yearShort && model is DMW.RunDate yearShortModel)
        return DMXW.RunDateConverter.CompareModelElement(yearShort, yearShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort yearLong && model is DMW.RunDate yearLongModel)
        return DMXW.RunDateConverter.CompareModelElement(yearLong, yearLongModel, diffs, objName);
      if (openXmlElement is DXW.EmbeddedObject embeddedObject && model is DMW.EmbeddedObject embeddedObjectModel)
        return DMXW.EmbeddedObjectConverter.CompareModelElement(embeddedObject, embeddedObjectModel, diffs, objName);
      if (openXmlElement is DXW.Picture picture && model is DMW.Picture pictureModel)
        return DMXW.PictureConverter.CompareModelElement(picture, pictureModel, diffs, objName);
      if (openXmlElement is DXW.Drawing drawing && model is DMW.Drawing drawingModel)
        return DMXW.DrawingConverter.CompareModelElement(drawing, drawingModel, diffs, objName);
      if (openXmlElement is DXW.Ruby ruby && model is DMW.Ruby rubyModel)
        return DMXW.RubyConverter.CompareModelElement(ruby, rubyModel, diffs, objName);
      if (openXmlElement is DXW.ContentPart contentPart && model is DMW.ContentPart contentPartModel)
        return DMXW.ContentPartConverter.CompareModelElement(contentPart, contentPartModel, diffs, objName);
      if (openXmlElement is DX.AlternateContent alternateContent && model is DM.AlternateContent alternateContentModel)
        return AlternateContentConverter.CompareModelElement(alternateContent, alternateContentModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DM.IModelElement model)
  {
    if (model is DMW.Text text)
      return DMXW.TextTypeConverter.CreateOpenXmlElement(text);
    if (model is DMW.FieldCode fieldCode)
      return DMXW.TextTypeConverter.CreateOpenXmlElement(fieldCode);
    if (model is DMW.FieldChar fieldChar)
      return DMXW.FieldCharConverter.CreateOpenXmlElement(fieldChar);
    if (model is DMW.Break brk)
      return DMXW.BreakConverter.CreateOpenXmlElement(brk);
    if (model is Hyphen hyphen)
      return DMXW.HyphenConverter.CreateOpenXmlElement(hyphen);
    if (model is NoteReference footnoteReference)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement(footnoteReference);
    if (model is DMW.CommentReference commentReference)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement(commentReference);
    if (model is NoteReferenceMark footnoteReferenceMark)
      return DMXW.NoteReferenceMarkConverter.CreateOpenXmlElement(footnoteReferenceMark);
    if (model is DMW.SeparatorMark separatorMark)
      return DMXW.SeparatorMarkConverter.CreateOpenXmlElement(separatorMark);
    if (model is DMW.SymbolChar symbolChar)
      return DMXW.SymbolCharConverter.CreateOpenXmlElement(symbolChar);
    if (model is DMW.PageNumber pageNumber)
      return DMXW.PageNumberConverter.CreateOpenXmlElement(pageNumber);
    if (model is CarriageReturn carriageReturn)
      return DMXW.CarriageReturnConverter.CreateOpenXmlElement(carriageReturn);
    if (model is DMW.TabChar tabChar)
      return DMXW.TabCharConverter.CreateOpenXmlElement(tabChar);
    if (model is DMW.PositionalTab positionalTab)
      return DMXW.PositionalTabConverter.CreateOpenXmlElement(positionalTab);
    if (model is DMW.RunDate date)
      return DMXW.RunDateConverter.CreateOpenXmlElement(date);
    if (model is DMW.EmbeddedObject embeddedObject)
      return DMXW.EmbeddedObjectConverter.CreateOpenXmlElement(embeddedObject);
    if (model is DMW.Picture picture)
      return DMXW.PictureConverter.CreateOpenXmlElement(picture);
    if (model is DMW.Drawing drawing)
      return DMXW.DrawingConverter.CreateOpenXmlElement(drawing);
    if (model is DMW.Ruby ruby)
      return DMXW.RubyConverter.CreateOpenXmlElement(ruby);
    if (model is DMW.ContentPart contentPart)
      return DMXW.ContentPartConverter.CreateOpenXmlElement(contentPart);
    if (model is DM.AlternateContent alternateContent)
      return DMX.AlternateContentConverter.CreateOpenXmlElement(alternateContent);

    if (model is DMW.ICommonContent commonElementModel)
    {
      var result = CommonMarkersConverter.CreateOpenXmlElement(commonElementModel);
      if (result != null)
        return result;
    }

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in Run.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Text text && model is DMW.Text textModel)
        return DMXW.TextTypeConverter.UpdateOpenXmlElement(text, textModel);
      if (openXmlElement is DXW.DeletedText deletedText && model is DMW.Text deletedTextModel)
        return DMXW.TextTypeConverter.UpdateOpenXmlElement(deletedText, deletedTextModel);
      if (openXmlElement is DXW.FieldCode fieldCode && model is DMW.FieldCode fieldCodeModel)
        return DMXW.TextTypeConverter.UpdateOpenXmlElement(fieldCode, fieldCodeModel);
      if (openXmlElement is DXW.DeletedFieldCode deletedFieldCode && model is DMW.FieldCode deletedFieldCodeModel)
        return DMXW.TextTypeConverter.UpdateOpenXmlElement(deletedFieldCode, deletedFieldCodeModel);
      if (openXmlElement is DXW.FieldChar fieldChar && model is DMW.FieldChar fieldCharModel)
        return DMXW.FieldCharConverter.UpdateOpenXmlElement(fieldChar, fieldCharModel);
      if (openXmlElement is DXW.Break brk && model is DMW.Break brkModel)
        return DMXW.BreakConverter.UpdateOpenXmlElement(brk, brkModel);
      if (openXmlElement is DXW.LastRenderedPageBreak lastRenderedPageBreak && model is DMW.LastRenderedPageBreak lastRenderedPageBreakModel)
        return DMXW.LastRenderedPageBreakConverter.UpdateOpenXmlElement(lastRenderedPageBreak, lastRenderedPageBreakModel);
      if (openXmlElement is DXW.NoBreakHyphen noBreakHyphen && model is Hyphen noBreakHyphenModel)
        return DMXW.HyphenConverter.UpdateOpenXmlElement(noBreakHyphen, noBreakHyphenModel);
      if (openXmlElement is DXW.FootnoteReference footnoteReference && model is NoteReference footnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.UpdateOpenXmlElement(footnoteReference, footnoteReferenceModel);
      if (openXmlElement is DXW.EndnoteReference endnoteReference && model is NoteReference endnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.UpdateOpenXmlElement(endnoteReference, endnoteReferenceModel);
      if (openXmlElement is DXW.CommentReference commentReference && model is DMW.CommentReference commentReferenceModel)
        return DMXW.MarkupTypeConverter.UpdateOpenXmlElement(commentReference, commentReferenceModel);
      if (openXmlElement is DXW.FootnoteReferenceMark footnoteReferenceMark && model is NoteReferenceMark footnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.UpdateOpenXmlElement(footnoteReferenceMark, footnoteReferenceMarkModel);
      if (openXmlElement is DXW.EndnoteReferenceMark endnoteReferenceMark && model is NoteReferenceMark endnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.UpdateOpenXmlElement(endnoteReferenceMark, endnoteReferenceMarkModel);
      if (openXmlElement is DXW.AnnotationReferenceMark annotationReferenceMark && model is NoteReferenceMark annotationReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.UpdateOpenXmlElement(annotationReferenceMark, annotationReferenceMarkModel);
      if (openXmlElement is DXW.SeparatorMark separatorMark && model is DMW.SeparatorMark separatorMarkModel)
        return DMXW.SeparatorMarkConverter.UpdateOpenXmlElement(separatorMark, separatorMarkModel);
      if (openXmlElement is DXW.ContinuationSeparatorMark continuationSeparatorMark && model is DMW.SeparatorMark continuationSeparatorMarkModel)
        return DMXW.SeparatorMarkConverter.UpdateOpenXmlElement(continuationSeparatorMark, continuationSeparatorMarkModel);
      if (openXmlElement is DXW.SymbolChar symbolChar && model is DMW.SymbolChar symbolCharModel)
        return DMXW.SymbolCharConverter.UpdateOpenXmlElement(symbolChar, symbolCharModel);
      if (openXmlElement is DXW.PageNumber pageNumber && model is DMW.PageNumber pageNumberModel)
        return DMXW.PageNumberConverter.UpdateOpenXmlElement(pageNumber, pageNumberModel);
      if (openXmlElement is DXW.CarriageReturn carriageReturn && model is CarriageReturn carriageReturnModel)
        return DMXW.CarriageReturnConverter.UpdateOpenXmlElement(carriageReturn, carriageReturnModel);
      if (openXmlElement is DXW.TabChar tabChar && model is DMW.TabChar tabCharModel)
        return DMXW.TabCharConverter.UpdateOpenXmlElement(tabChar, tabCharModel);
      if (openXmlElement is DXW.PositionalTab positionalTab && model is DMW.PositionalTab positionalTabModel)
        return DMXW.PositionalTabConverter.UpdateOpenXmlElement(positionalTab, positionalTabModel);
      if (openXmlElement is DXW.SoftHyphen softHyphen && model is Hyphen softHyphenModel)
        return DMXW.HyphenConverter.UpdateOpenXmlElement(softHyphen, softHyphenModel);
      if (openXmlElement is DXW.DayShort dayShort && model is DMW.RunDate dayShortModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(dayShort, dayShortModel);
      if (openXmlElement is DXW.DayShort dayLong && model is DMW.RunDate dayLongModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(dayLong, dayLongModel);
      if (openXmlElement is DXW.DayShort monthShort && model is DMW.RunDate monthShortModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(monthShort, monthShortModel);
      if (openXmlElement is DXW.DayShort monthLong && model is DMW.RunDate monthLongModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(monthLong, monthLongModel);
      if (openXmlElement is DXW.DayShort yearShort && model is DMW.RunDate yearShortModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(yearShort, yearShortModel);
      if (openXmlElement is DXW.DayShort yearLong && model is DMW.RunDate yearLongModel)
        return DMXW.RunDateConverter.UpdateOpenXmlElement(yearLong, yearLongModel);
      if (openXmlElement is DXW.EmbeddedObject embeddedObject && model is DMW.EmbeddedObject embeddedObjectModel)
        return DMXW.EmbeddedObjectConverter.UpdateOpenXmlElement(embeddedObject, embeddedObjectModel);
      if (openXmlElement is DXW.Picture picture && model is DMW.Picture pictureModel)
        return DMXW.PictureConverter.UpdateOpenXmlElement(picture, pictureModel);
      if (openXmlElement is DXW.Drawing drawing && model is DMW.Drawing drawingModel)
        return DMXW.DrawingConverter.UpdateOpenXmlElement(drawing, drawingModel);
      if (openXmlElement is DXW.Ruby ruby && model is DMW.Ruby rubyModel)
        return DMXW.RubyConverter.UpdateOpenXmlElement(ruby, rubyModel);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result != null)
          return (bool)result;
        return true;
      }
    }
    return false;
  }
  #endregion

  #region Run conversion
  public static DMW.Run? CreateModelElement(DXW.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Run();
      model.RsidRunProperties = GetRsidRunProperties(openXmlElement);
      model.RsidRunDeletion = GetRsidRunDeletion(openXmlElement);
      model.RsidRunAddition = GetRsidRunAddition(openXmlElement);
      model.RunProperties = GetRunProperties(openXmlElement);
      ElementCollectionConverter<IRunContent>.FillModelElementCollection(
        openXmlElement.Where(item => item is not DXW.RunProperties), model,
        CreateRunContent);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Run? openXmlElement, DMW.Run? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRsidRunProperties(openXmlElement, model.RsidRunProperties, diffs, objName))
        ok = false;
      if (!CmpRsidRunDeletion(openXmlElement, model.RsidRunDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidRunAddition(openXmlElement, model.RsidRunAddition, diffs, objName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, model.RunProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<IRunContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item => item is not DXW.RunProperties), model,
        CompareRunContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.Run CreateOpenXmlElement(DMW.Run model)
  {
    var openXmlElement = new DXW.Run();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Run openXmlElement, DMW.Run model)
  {
    SetRsidRunProperties(openXmlElement, model.RsidRunProperties);
    SetRsidRunDeletion(openXmlElement, model.RsidRunDeletion);
    SetRsidRunAddition(openXmlElement, model.RsidRunAddition);
    SetRunProperties(openXmlElement, model.RunProperties);
    return ElementCollectionConverter<IRunContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareRunContent,
      UpdateOpenXmlElement,
      CreateOpenXmlElement
      );
  }
  #endregion
}
