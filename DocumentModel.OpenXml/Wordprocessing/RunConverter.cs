namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public static Byte[]? GetRsidRunProperties(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunProperties.Value);
    return null;
  }
  
  public static void SetRsidRunProperties(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Byte[]? value)
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
  /// Revision Identifier for Run Deletion
  /// </summary>
  public static Byte[]? GetRsidRunDeletion(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunDeletion.Value);
    return null;
  }
  
  public static void SetRsidRunDeletion(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Byte[]? value)
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
  /// Revision Identifier for Run
  /// </summary>
  public static Byte[]? GetRsidRunAddition(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRunAddition.Value);
    return null;
  }
  
  public static void SetRsidRunAddition(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Byte[]? value)
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
  /// Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Break? GetBreak(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBreak(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.Break? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.TextType? GetText(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetText(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.TextType? GetDeletedText(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDeletedText(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.TextType? GetFieldCode(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFieldCode(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.TextType? GetDeletedFieldCode(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDeletedFieldCode(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.TextType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetNoBreakHyphen(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoBreakHyphen(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetSoftHyphen(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSoftHyphen(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetDayShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayShort>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDayShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetMonthShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetMonthShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetYearShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearShort>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetYearShort(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetDayLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DayLong>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDayLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetMonthLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetMonthLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetYearLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.YearLong>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetYearLong(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetAnnotationReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAnnotationReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetFootnoteReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetFootnoteReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetEndnoteReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEndnoteReferenceMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetSeparatorMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSeparatorMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetContinuationSeparatorMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetContinuationSeparatorMark(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.SymbolChar? GetSymbolChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SymbolCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSymbolChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.SymbolChar? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetPageNumber(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPageNumber(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetCarriageReturn(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetCarriageReturn(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetTabChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabChar>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetTabChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.EmbeddedObject? GetEmbeddedObject(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EmbeddedObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEmbeddedObject(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.EmbeddedObject? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Picture? GetPicture(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPicture(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.Picture? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.FieldChar? GetFieldChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FieldCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFieldChar(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.FieldChar? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Ruby? GetRuby(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RubyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRuby(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.Ruby? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? GetFootnoteReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFootnoteReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? GetEndnoteReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndnoteReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCommentReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentReference(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Drawing? GetDrawing(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDrawing(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.Drawing? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.PositionalTab? GetPositionalTab(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PositionalTabConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPositionalTab(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, DocumentModel.Wordprocessing.PositionalTab? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetLastRenderedPageBreak(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetLastRenderedPageBreak(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Run? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Run? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRunProperties(openXmlElement, value?.RsidRunProperties);
      SetRsidRunDeletion(openXmlElement, value?.RsidRunDeletion);
      SetRsidRunAddition(openXmlElement, value?.RsidRunAddition);
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}
