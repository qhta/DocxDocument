using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Text run element converter
/// </summary>
public static class RunConverter
{
  #region Revision Identifier for Run conversion
  private static DM.HexInt? GetRsidRunProperties(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunProperties.Value);
    return null;
  }

  private static bool CmpRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunProperties?.Value, value, diffs, objName, "RsidRunProperties");
  }

  private static void SetRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunProperties = value.ToString();
    else
      openXmlElement.RsidRunProperties = null;
  }
  #endregion

  #region Revision Identifier for Run Deletion conversion
  private static DM.HexInt? GetRsidRunDeletion(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunDeletion.Value);
    return null;
  }

  private static bool CmpRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunDeletion?.Value, value, diffs, objName, "RsidRunDeletion");
  }

  private static void SetRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunDeletion = value.ToString();
    else
      openXmlElement.RsidRunDeletion = null;
  }
  #endregion

  #region Revision Identifier for Run Addtion conversion
  private static DM.HexInt? GetRsidRunAddition(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunAddition.Value);
    return null;
  }

  private static bool CmpRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunAddition?.Value, value, diffs, objName, "RsidRunAddition");
  }

  private static void SetRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunAddition = value.ToString();
    else
      openXmlElement.RsidRunAddition = null;
  }
  #endregion

  #region Run Properties conversion
  private static DMW.RunProperties? GetRunProperties(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpRunProperties(DXW.Run openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetRunProperties(DXW.Run openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Run elements conversion
  public static DMW.IRunElement? CreateRunElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.RunProperties)
      return null;
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
      return DMXW.BreakConverter.CreateModelElement(lastRenderedPageBreak);
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
      return DMXW.SimpleRunElementConverter.CreateModelElement(pageNumber);
    if (openXmlElement is DXW.CarriageReturn carriageReturn)
      return DMXW.SimpleRunElementConverter.CreateModelElement(carriageReturn);
    if (openXmlElement is DXW.TabChar tabChar)
      return DMXW.SimpleRunElementConverter.CreateModelElement(tabChar);
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
    if (openXmlElement is DX.AlternateContent alternateContent)
      return AlternateContentConverter.CreateModelElement(alternateContent);

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Run.CreateModelElement method");
    return null;
  }

  public static bool CompareRunElement(DX.OpenXmlElement? openXmlElement, DMW.IRunElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Text text && value is DMW.Text textModel)
        return DMXW.TextTypeConverter.CompareModelElement(text, textModel, diffs, objName);
      if (openXmlElement is DXW.DeletedText deletedText && value is DMW.Text deletedTextModel)
        return DMXW.TextTypeConverter.CompareModelElement(deletedText, deletedTextModel, diffs, objName);
      if (openXmlElement is DXW.FieldCode fieldCode && value is DMW.FieldCode fieldCodeModel)
        return DMXW.TextTypeConverter.CompareModelElement(fieldCode, fieldCodeModel, diffs, objName);
      if (openXmlElement is DXW.DeletedFieldCode deletedFieldCode && value is DMW.FieldCode deletedFieldCodeModel)
        return DMXW.TextTypeConverter.CompareModelElement(deletedFieldCode, deletedFieldCodeModel, diffs, objName);
      if (openXmlElement is DXW.FieldChar fieldChar && value is DMW.FieldChar fieldCharModel)
        return DMXW.FieldCharConverter.CompareModelElement(fieldChar, fieldCharModel, diffs, objName);
      if (openXmlElement is DXW.Break brk && value is DMW.Break brkModel)
        return DMXW.BreakConverter.CompareModelElement(brk, brkModel, diffs, objName);
      if (openXmlElement is DXW.LastRenderedPageBreak lastRenderedPageBreak && value is DMW.Break lastRenderedPageBreakModel)
        return DMXW.BreakConverter.CompareModelElement(lastRenderedPageBreak, lastRenderedPageBreakModel, diffs, objName);
      if (openXmlElement is DXW.NoBreakHyphen noBreakHyphen && value is DMW.Hyphen noBreakHyphenModel)
        return DMXW.HyphenConverter.CompareModelElement(noBreakHyphen, noBreakHyphenModel, diffs, objName);
      if (openXmlElement is DXW.FootnoteReference footnoteReference && value is DMW.NoteReference footnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(footnoteReference, footnoteReferenceModel, diffs, objName);
      if (openXmlElement is DXW.EndnoteReference endnoteReference && value is DMW.NoteReference endnoteReferenceModel)
        return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(endnoteReference, endnoteReferenceModel, diffs, objName);
      if (openXmlElement is DXW.CommentReference commentReference && value is DMW.CommentReference commentReferenceModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(commentReference, commentReferenceModel, diffs, objName);
      if (openXmlElement is DXW.FootnoteReferenceMark footnoteReferenceMark && value is DMW.NoteReferenceMark footnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(footnoteReferenceMark, footnoteReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.EndnoteReferenceMark endnoteReferenceMark && value is DMW.NoteReferenceMark endnoteReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(endnoteReferenceMark, endnoteReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.AnnotationReferenceMark annotationReferenceMark && value is DMW.NoteReferenceMark annotationReferenceMarkModel)
        return DMXW.NoteReferenceMarkConverter.CompareModelElement(annotationReferenceMark, annotationReferenceMarkModel, diffs, objName);
      if (openXmlElement is DXW.SeparatorMark separatorMark && value is DMW.SeparatorMark separatorMarkModel)
        return DMXW.SeparatorMarkConverter.CompareModelElement(separatorMark, separatorMarkModel, diffs, objName);
      if (openXmlElement is DXW.ContinuationSeparatorMark continuationSeparatorMark && value is DMW.SeparatorMark continuationSeparatorMarkModel)
        return DMXW.SeparatorMarkConverter.CompareModelElement(continuationSeparatorMark, continuationSeparatorMarkModel, diffs, objName);
      if (openXmlElement is DXW.SymbolChar symbolChar && value is DMW.SymbolChar symbolCharModel)
        return DMXW.SymbolCharConverter.CompareModelElement(symbolChar, symbolCharModel, diffs, objName);
      if (openXmlElement is DXW.PageNumber pageNumber && value is DMW.PageNumber pageNumberModel)
        return DMXW.SimpleRunElementConverter.CompareModelElement(pageNumber, pageNumberModel, diffs, objName);
      if (openXmlElement is DXW.CarriageReturn carriageReturn && value is DMW.CarriageReturn carriageReturnModel)
        return DMXW.SimpleRunElementConverter.CompareModelElement(carriageReturn, carriageReturnModel, diffs, objName);
      if (openXmlElement is DXW.TabChar tabChar && value is DMW.TabChar tabCharModel)
        return DMXW.SimpleRunElementConverter.CompareModelElement(tabChar, tabCharModel, diffs, objName);
      if (openXmlElement is DXW.PositionalTab positionalTab && value is DMW.PositionalTab positionalTabModel)
        return DMXW.PositionalTabConverter.CompareModelElement(positionalTab, positionalTabModel, diffs, objName);
      if (openXmlElement is DXW.SoftHyphen softHyphen && value is DMW.Hyphen softHyphenModel)
        return DMXW.HyphenConverter.CompareModelElement(softHyphen, softHyphenModel, diffs, objName);
      if (openXmlElement is DXW.DayShort dayShort && value is DMW.RunDate dayShortModel)
        return DMXW.RunDateConverter.CompareModelElement(dayShort, dayShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort dayLong && value is DMW.RunDate dayLongModel)
        return DMXW.RunDateConverter.CompareModelElement(dayLong, dayLongModel, diffs, objName);
      if (openXmlElement is DXW.DayShort monthShort && value is DMW.RunDate monthShortModel)
        return DMXW.RunDateConverter.CompareModelElement(monthShort, monthShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort monthLong && value is DMW.RunDate monthLongModel)
        return DMXW.RunDateConverter.CompareModelElement(monthLong, monthLongModel, diffs, objName);
      if (openXmlElement is DXW.DayShort yearShort && value is DMW.RunDate yearShortModel)
        return DMXW.RunDateConverter.CompareModelElement(yearShort, yearShortModel, diffs, objName);
      if (openXmlElement is DXW.DayShort yearLong && value is DMW.RunDate yearLongModel)
        return DMXW.RunDateConverter.CompareModelElement(yearLong, yearLongModel, diffs, objName);
      if (openXmlElement is DXW.EmbeddedObject embeddedObject && value is DMW.EmbeddedObject embeddedObjectModel)
        return DMXW.EmbeddedObjectConverter.CompareModelElement(embeddedObject, embeddedObjectModel, diffs, objName);
      if (openXmlElement is DXW.Picture picture && value is DMW.Picture pictureModel)
        return DMXW.PictureConverter.CompareModelElement(picture, pictureModel, diffs, objName);
      if (openXmlElement is DXW.Drawing drawing && value is DMW.Drawing drawingModel)
        return DMXW.DrawingConverter.CompareModelElement(drawing, drawingModel, diffs, objName);
      if (openXmlElement is DXW.Ruby ruby && value is DMW.Ruby rubyModel)
        return DMXW.RubyConverter.CompareModelElement(ruby, rubyModel, diffs, objName);

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.IRunElement value)
  {
    if (value is DMW.Text text)
      return DMXW.TextTypeConverter.CreateOpenXmlElement(text);
    if (value is DMW.FieldCode fieldCode)
      return DMXW.TextTypeConverter.CreateOpenXmlElement(fieldCode);
    if (value is DMW.FieldChar fieldChar)
      return DMXW.FieldCharConverter.CreateOpenXmlElement(fieldChar);
    if (value is DMW.Break brk)
      return DMXW.BreakConverter.CreateOpenXmlElement(brk);
    if (value is DMW.Hyphen hyphen)
      return DMXW.HyphenConverter.CreateOpenXmlElement(hyphen);
    if (value is DMW.NoteReference footnoteReference)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement(footnoteReference);
    if (value is DMW.CommentReference commentReference)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement(commentReference);
    if (value is DMW.NoteReferenceMark footnoteReferenceMark)
      return DMXW.NoteReferenceMarkConverter.CreateOpenXmlElement(footnoteReferenceMark);
    if (value is DMW.SeparatorMark separatorMark)
      return DMXW.SeparatorMarkConverter.CreateOpenXmlElement(separatorMark);
    if (value is DMW.SymbolChar symbolChar)
      return DMXW.SymbolCharConverter.CreateOpenXmlElement(symbolChar);
    if (value is DMW.PageNumber pageNumber)
      return DMXW.SimpleRunElementConverter.CreateOpenXmlElement(pageNumber);
    if (value is DMW.CarriageReturn carriageReturn)
      return DMXW.SimpleRunElementConverter.CreateOpenXmlElement(carriageReturn);
    if (value is DMW.TabChar tabChar)
      return DMXW.SimpleRunElementConverter.CreateOpenXmlElement(tabChar);
    if (value is DMW.PositionalTab positionalTab)
      return DMXW.PositionalTabConverter.CreateOpenXmlElement(positionalTab);
    if (value is DMW.RunDate date)
      return DMXW.RunDateConverter.CreateOpenXmlElement(date);
    if (value is DMW.EmbeddedObject embeddedObject)
      return DMXW.EmbeddedObjectConverter.CreateOpenXmlElement(embeddedObject);
    if (value is DMW.Picture picture)
      return DMXW.PictureConverter.CreateOpenXmlElement(picture);
    if (value is DMW.Drawing drawing)
      return DMXW.DrawingConverter.CreateOpenXmlElement(drawing);
    if (value is DMW.Ruby ruby)
      return DMXW.RubyConverter.CreateOpenXmlElement(ruby);

     if (value is DMW.ICommonElement commonElementModel)
     {
        var result = CommonMarkersConverter.CreateOpenXmlElement(commonElementModel);
        if (result != null)
          return result;
      }

    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in Run.CreateOpenXmlElement method");
  }
  #endregion

  #region Run conversion
  public static DMW.Run? CreateModelElement(DXW.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Run();
      value.RsidRunProperties = GetRsidRunProperties(openXmlElement);
      value.RsidRunDeletion = GetRsidRunDeletion(openXmlElement);
      value.RsidRunAddition = GetRsidRunAddition(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        var item = CreateRunElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Run? openXmlElement, DMW.Run? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidRunProperties(openXmlElement, value.RsidRunProperties, diffs, objName))
        ok = false;
      if (!CmpRsidRunDeletion(openXmlElement, value.RsidRunDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidRunAddition(openXmlElement, value.RsidRunAddition, diffs, objName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      var runItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.RunProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(runItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = runItems[i];
        if (!CompareRunElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), runItems.Count(), diffs, objName, "Run.Items.Count"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.Run CreateOpenXmlElement(DMW.Run value)
  {
    var openXmlElement = new  DXW.Run();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Run openXmlElement, DMW.Run value)
  {
    SetRsidRunProperties(openXmlElement, value.RsidRunProperties);
    SetRsidRunDeletion(openXmlElement, value.RsidRunDeletion);
    SetRsidRunAddition(openXmlElement, value.RsidRunAddition);
    SetRunProperties(openXmlElement, value.RunProperties);
    var runItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < runItems.Count(); i++)
    {
      var item = runItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
  }
  #endregion
}
