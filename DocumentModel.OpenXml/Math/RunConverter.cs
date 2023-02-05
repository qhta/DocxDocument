namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMMath.RunProperties? GetMathRunProperties(DXMath.Run openXmlElement)
  {
    return DMXMath.RunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.RunProperties>());
  }
  
  private static bool CmpMathRunProperties(DXMath.Run openXmlElement, DMMath.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathRunProperties(DXMath.Run openXmlElement, DMMath.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunPropertiesConverter.CreateOpenXmlElement<DXMath.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMW.RunProperties? GetRunProperties(DXMath.Run openXmlElement)
  {
    return DMXW.RunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RunProperties>());
  }
  
  private static bool CmpRunProperties(DXMath.Run openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunProperties(DXMath.Run openXmlElement, DMW.RunProperties? value)
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
  
  private static DMW.Break? GetBreak(DXMath.Run openXmlElement)
  {
    return DMXW.BreakConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Break>());
  }
  
  private static bool CmpBreak(DXMath.Run openXmlElement, DMW.Break? value, DiffList? diffs, string? objName)
  {
    return DMXW.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Break>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBreak(DXMath.Run openXmlElement, DMW.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BreakConverter.CreateOpenXmlElement<DXW.Break>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextType? GetText(DXMath.Run openXmlElement)
  {
    return DMXW.TextTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Text>());
  }
  
  private static bool CmpText(DXMath.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Text>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetText(DXMath.Run openXmlElement, DMW.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextTypeConverter.CreateOpenXmlElement<DXW.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextType? GetDeletedText(DXMath.Run openXmlElement)
  {
    return DMXW.TextTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedText>());
  }
  
  private static bool CmpDeletedText(DXMath.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedText(DXMath.Run openXmlElement, DMW.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextTypeConverter.CreateOpenXmlElement<DXW.DeletedText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextType? GetFieldCode(DXMath.Run openXmlElement)
  {
    return DMXW.TextTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FieldCode>());
  }
  
  private static bool CmpFieldCode(DXMath.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FieldCode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFieldCode(DXMath.Run openXmlElement, DMW.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FieldCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextTypeConverter.CreateOpenXmlElement<DXW.FieldCode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextType? GetDeletedFieldCode(DXMath.Run openXmlElement)
  {
    return DMXW.TextTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedFieldCode>());
  }
  
  private static bool CmpDeletedFieldCode(DXMath.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedFieldCode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedFieldCode(DXMath.Run openXmlElement, DMW.TextType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedFieldCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextTypeConverter.CreateOpenXmlElement<DXW.DeletedFieldCode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoBreakHyphen(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.NoBreakHyphen>() != null;
  }
  
  private static bool CmpNoBreakHyphen(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.NoBreakHyphen>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoBreakHyphen", val, value);
    return false;
  }
  
  private static void SetNoBreakHyphen(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoBreakHyphen>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoBreakHyphen();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSoftHyphen(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SoftHyphen>() != null;
  }
  
  private static bool CmpSoftHyphen(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SoftHyphen>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SoftHyphen", val, value);
    return false;
  }
  
  private static void SetSoftHyphen(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SoftHyphen>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SoftHyphen();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDayShort(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DayShort>() != null;
  }
  
  private static bool CmpDayShort(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.DayShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DayShort", val, value);
    return false;
  }
  
  private static void SetDayShort(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DayShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DayShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetMonthShort(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MonthShort>() != null;
  }
  
  private static bool CmpMonthShort(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.MonthShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MonthShort", val, value);
    return false;
  }
  
  private static void SetMonthShort(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MonthShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MonthShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetYearShort(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.YearShort>() != null;
  }
  
  private static bool CmpYearShort(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.YearShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.YearShort", val, value);
    return false;
  }
  
  private static void SetYearShort(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.YearShort>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.YearShort();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDayLong(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DayLong>() != null;
  }
  
  private static bool CmpDayLong(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.DayLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DayLong", val, value);
    return false;
  }
  
  private static void SetDayLong(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DayLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DayLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetMonthLong(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MonthLong>() != null;
  }
  
  private static bool CmpMonthLong(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.MonthLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MonthLong", val, value);
    return false;
  }
  
  private static void SetMonthLong(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MonthLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MonthLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetYearLong(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.YearLong>() != null;
  }
  
  private static bool CmpYearLong(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.YearLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.YearLong", val, value);
    return false;
  }
  
  private static void SetYearLong(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.YearLong>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.YearLong();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAnnotationReferenceMark(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AnnotationReferenceMark>() != null;
  }
  
  private static bool CmpAnnotationReferenceMark(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.AnnotationReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AnnotationReferenceMark", val, value);
    return false;
  }
  
  private static void SetAnnotationReferenceMark(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AnnotationReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AnnotationReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetFootnoteReferenceMark(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.FootnoteReferenceMark>() != null;
  }
  
  private static bool CmpFootnoteReferenceMark(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.FootnoteReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.FootnoteReferenceMark", val, value);
    return false;
  }
  
  private static void SetFootnoteReferenceMark(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.FootnoteReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEndnoteReferenceMark(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.EndnoteReferenceMark>() != null;
  }
  
  private static bool CmpEndnoteReferenceMark(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.EndnoteReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.EndnoteReferenceMark", val, value);
    return false;
  }
  
  private static void SetEndnoteReferenceMark(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.EndnoteReferenceMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.EndnoteReferenceMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSeparatorMark(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SeparatorMark>() != null;
  }
  
  private static bool CmpSeparatorMark(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SeparatorMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SeparatorMark", val, value);
    return false;
  }
  
  private static void SetSeparatorMark(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SeparatorMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SeparatorMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetContinuationSeparatorMark(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ContinuationSeparatorMark>() != null;
  }
  
  private static bool CmpContinuationSeparatorMark(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.ContinuationSeparatorMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ContinuationSeparatorMark", val, value);
    return false;
  }
  
  private static void SetContinuationSeparatorMark(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ContinuationSeparatorMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ContinuationSeparatorMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SymbolChar? GetSymbolChar(DXMath.Run openXmlElement)
  {
    return DMXW.SymbolCharConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SymbolChar>());
  }
  
  private static bool CmpSymbolChar(DXMath.Run openXmlElement, DMW.SymbolChar? value, DiffList? diffs, string? objName)
  {
    return DMXW.SymbolCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SymbolChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSymbolChar(DXMath.Run openXmlElement, DMW.SymbolChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SymbolChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SymbolCharConverter.CreateOpenXmlElement<DXW.SymbolChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetPageNumber(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PageNumber>() != null;
  }
  
  private static bool CmpPageNumber(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.PageNumber>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PageNumber", val, value);
    return false;
  }
  
  private static void SetPageNumber(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PageNumber>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PageNumber();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetCarriageReturn(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.CarriageReturn>() != null;
  }
  
  private static bool CmpCarriageReturn(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.CarriageReturn>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.CarriageReturn", val, value);
    return false;
  }
  
  private static void SetCarriageReturn(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.CarriageReturn>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.CarriageReturn();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTabChar(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TabChar>() != null;
  }
  
  private static bool CmpTabChar(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.TabChar>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.TabChar", val, value);
    return false;
  }
  
  private static void SetTabChar(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TabChar>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TabChar();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.EmbeddedObject? GetEmbeddedObject(DXMath.Run openXmlElement)
  {
    return DMXW.EmbeddedObjectConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EmbeddedObject>());
  }
  
  private static bool CmpEmbeddedObject(DXMath.Run openXmlElement, DMW.EmbeddedObject? value, DiffList? diffs, string? objName)
  {
    return DMXW.EmbeddedObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbeddedObject>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbeddedObject(DXMath.Run openXmlElement, DMW.EmbeddedObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbeddedObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EmbeddedObjectConverter.CreateOpenXmlElement<DXW.EmbeddedObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Picture? GetPicture(DXMath.Run openXmlElement)
  {
    return DMXW.PictureConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Picture>());
  }
  
  private static bool CmpPicture(DXMath.Run openXmlElement, DMW.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXW.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Picture>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPicture(DXMath.Run openXmlElement, DMW.Picture? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Picture>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PictureConverter.CreateOpenXmlElement<DXW.Picture>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FieldChar? GetFieldChar(DXMath.Run openXmlElement)
  {
    return DMXW.FieldCharConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FieldChar>());
  }
  
  private static bool CmpFieldChar(DXMath.Run openXmlElement, DMW.FieldChar? value, DiffList? diffs, string? objName)
  {
    return DMXW.FieldCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FieldChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFieldChar(DXMath.Run openXmlElement, DMW.FieldChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FieldChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FieldCharConverter.CreateOpenXmlElement<DXW.FieldChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Ruby? GetRuby(DXMath.Run openXmlElement)
  {
    return DMXW.RubyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Ruby>());
  }
  
  private static bool CmpRuby(DXMath.Run openXmlElement, DMW.Ruby? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Ruby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuby(DXMath.Run openXmlElement, DMW.Ruby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Ruby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyConverter.CreateOpenXmlElement<DXW.Ruby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FootnoteEndnoteReferenceType? GetFootnoteReference(DXMath.Run openXmlElement)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FootnoteReference>());
  }
  
  private static bool CmpFootnoteReference(DXMath.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFootnoteReference(DXMath.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<DXW.FootnoteReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FootnoteEndnoteReferenceType? GetEndnoteReference(DXMath.Run openXmlElement)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EndnoteReference>());
  }
  
  private static bool CmpEndnoteReference(DXMath.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndnoteReference(DXMath.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnoteReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FootnoteEndnoteReferenceTypeConverter.CreateOpenXmlElement<DXW.EndnoteReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCommentReference(DXMath.Run openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentReference>());
  }
  
  private static bool CmpCommentReference(DXMath.Run openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentReference(DXMath.Run openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CommentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Drawing? GetDrawing(DXMath.Run openXmlElement)
  {
    return DMXW.DrawingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Drawing>());
  }
  
  private static bool CmpDrawing(DXMath.Run openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Drawing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDrawing(DXMath.Run openXmlElement, DMW.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DrawingConverter.CreateOpenXmlElement<DXW.Drawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PositionalTab? GetPositionalTab(DXMath.Run openXmlElement)
  {
    return DMXW.PositionalTabConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PositionalTab>());
  }
  
  private static bool CmpPositionalTab(DXMath.Run openXmlElement, DMW.PositionalTab? value, DiffList? diffs, string? objName)
  {
    return DMXW.PositionalTabConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PositionalTab>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPositionalTab(DXMath.Run openXmlElement, DMW.PositionalTab? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PositionalTab>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PositionalTabConverter.CreateOpenXmlElement<DXW.PositionalTab>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLastRenderedPageBreak(DXMath.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.LastRenderedPageBreak>() != null;
  }
  
  private static bool CmpLastRenderedPageBreak(DXMath.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.LastRenderedPageBreak>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.LastRenderedPageBreak", val, value);
    return false;
  }
  
  private static void SetLastRenderedPageBreak(DXMath.Run openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LastRenderedPageBreak>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LastRenderedPageBreak();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.Run? CreateModelElement(DXMath.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Run();
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
  
  public static bool CompareModelElement(DXMath.Run? openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMathRunProperties(openXmlElement, value.MathRunProperties, diffs, objName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpBreak(openXmlElement, value.Break, diffs, objName))
        ok = false;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      if (!CmpDeletedText(openXmlElement, value.DeletedText, diffs, objName))
        ok = false;
      if (!CmpFieldCode(openXmlElement, value.FieldCode, diffs, objName))
        ok = false;
      if (!CmpDeletedFieldCode(openXmlElement, value.DeletedFieldCode, diffs, objName))
        ok = false;
      if (!CmpNoBreakHyphen(openXmlElement, value.NoBreakHyphen, diffs, objName))
        ok = false;
      if (!CmpSoftHyphen(openXmlElement, value.SoftHyphen, diffs, objName))
        ok = false;
      if (!CmpDayShort(openXmlElement, value.DayShort, diffs, objName))
        ok = false;
      if (!CmpMonthShort(openXmlElement, value.MonthShort, diffs, objName))
        ok = false;
      if (!CmpYearShort(openXmlElement, value.YearShort, diffs, objName))
        ok = false;
      if (!CmpDayLong(openXmlElement, value.DayLong, diffs, objName))
        ok = false;
      if (!CmpMonthLong(openXmlElement, value.MonthLong, diffs, objName))
        ok = false;
      if (!CmpYearLong(openXmlElement, value.YearLong, diffs, objName))
        ok = false;
      if (!CmpAnnotationReferenceMark(openXmlElement, value.AnnotationReferenceMark, diffs, objName))
        ok = false;
      if (!CmpFootnoteReferenceMark(openXmlElement, value.FootnoteReferenceMark, diffs, objName))
        ok = false;
      if (!CmpEndnoteReferenceMark(openXmlElement, value.EndnoteReferenceMark, diffs, objName))
        ok = false;
      if (!CmpSeparatorMark(openXmlElement, value.SeparatorMark, diffs, objName))
        ok = false;
      if (!CmpContinuationSeparatorMark(openXmlElement, value.ContinuationSeparatorMark, diffs, objName))
        ok = false;
      if (!CmpSymbolChar(openXmlElement, value.SymbolChar, diffs, objName))
        ok = false;
      if (!CmpPageNumber(openXmlElement, value.PageNumber, diffs, objName))
        ok = false;
      if (!CmpCarriageReturn(openXmlElement, value.CarriageReturn, diffs, objName))
        ok = false;
      if (!CmpTabChar(openXmlElement, value.TabChar, diffs, objName))
        ok = false;
      if (!CmpEmbeddedObject(openXmlElement, value.EmbeddedObject, diffs, objName))
        ok = false;
      if (!CmpPicture(openXmlElement, value.Picture, diffs, objName))
        ok = false;
      if (!CmpFieldChar(openXmlElement, value.FieldChar, diffs, objName))
        ok = false;
      if (!CmpRuby(openXmlElement, value.Ruby, diffs, objName))
        ok = false;
      if (!CmpFootnoteReference(openXmlElement, value.FootnoteReference, diffs, objName))
        ok = false;
      if (!CmpEndnoteReference(openXmlElement, value.EndnoteReference, diffs, objName))
        ok = false;
      if (!CmpCommentReference(openXmlElement, value.CommentReference, diffs, objName))
        ok = false;
      if (!CmpDrawing(openXmlElement, value.Drawing, diffs, objName))
        ok = false;
      if (!CmpPositionalTab(openXmlElement, value.PositionalTab, diffs, objName))
        ok = false;
      if (!CmpLastRenderedPageBreak(openXmlElement, value.LastRenderedPageBreak, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Run? value)
    where OpenXmlElementType: DXMath.Run, new()
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
