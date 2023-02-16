namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  private static DM.HexInt? GetRsidRunProperties(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunProperties.Value);
    return null;
  }
  
  private static bool CmpRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidRunProperties?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidRunProperties.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidRunProperties?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidRunProperties", openXmlElement?.RsidRunProperties?.Value, value);
    return false;
  }
  
  private static void SetRsidRunProperties(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunProperties = value.ToString();
    else
      openXmlElement.RsidRunProperties = null;
  }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  private static DM.HexInt? GetRsidRunDeletion(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunDeletion.Value);
    return null;
  }
  
  private static bool CmpRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidRunDeletion?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidRunDeletion.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidRunDeletion?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidRunDeletion", openXmlElement?.RsidRunDeletion?.Value, value);
    return false;
  }
  
  private static void SetRsidRunDeletion(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunDeletion = value.ToString();
    else
      openXmlElement.RsidRunDeletion = null;
  }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  private static DM.HexInt? GetRsidRunAddition(DXW.Run openXmlElement)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunAddition.Value);
    return null;
  }
  
  private static bool CmpRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidRunAddition?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidRunAddition.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidRunAddition?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidRunAddition", openXmlElement?.RsidRunAddition?.Value, value);
    return false;
  }
  
  private static void SetRsidRunAddition(DXW.Run openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunAddition = value.ToString();
    else
      openXmlElement.RsidRunAddition = null;
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMW.RunProperties? GetRunProperties(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXW.Run openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static DMW.Break? GetBreak(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Break>();
    if (element != null)
      return DMXW.BreakConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBreak(DXW.Run openXmlElement, DMW.Break? value, DiffList? diffs, string? objName)
  {
    return DMXW.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Break>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBreak(DXW.Run openXmlElement, DMW.Break? value)
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
  
  private static DMW.TextType? GetText(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Text>();
    if (element != null)
      return DMXW.TextTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpText(DXW.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Text>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetText(DXW.Run openXmlElement, DMW.TextType? value)
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
  
  private static DMW.TextType? GetDeletedText(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedText>();
    if (element != null)
      return DMXW.TextTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedText(DXW.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedText(DXW.Run openXmlElement, DMW.TextType? value)
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
  
  private static DMW.TextType? GetFieldCode(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FieldCode>();
    if (element != null)
      return DMXW.TextTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFieldCode(DXW.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FieldCode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFieldCode(DXW.Run openXmlElement, DMW.TextType? value)
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
  
  private static DMW.TextType? GetDeletedFieldCode(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedFieldCode>();
    if (element != null)
      return DMXW.TextTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedFieldCode(DXW.Run openXmlElement, DMW.TextType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedFieldCode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedFieldCode(DXW.Run openXmlElement, DMW.TextType? value)
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
  
  private static Boolean? GetNoBreakHyphen(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.NoBreakHyphen>() != null;
  }
  
  private static bool CmpNoBreakHyphen(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.NoBreakHyphen>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoBreakHyphen", val, value);
    return false;
  }
  
  private static void SetNoBreakHyphen(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetSoftHyphen(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SoftHyphen>() != null;
  }
  
  private static bool CmpSoftHyphen(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SoftHyphen>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SoftHyphen", val, value);
    return false;
  }
  
  private static void SetSoftHyphen(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetDayShort(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DayShort>() != null;
  }
  
  private static bool CmpDayShort(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.DayShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DayShort", val, value);
    return false;
  }
  
  private static void SetDayShort(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetMonthShort(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MonthShort>() != null;
  }
  
  private static bool CmpMonthShort(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.MonthShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MonthShort", val, value);
    return false;
  }
  
  private static void SetMonthShort(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetYearShort(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.YearShort>() != null;
  }
  
  private static bool CmpYearShort(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.YearShort>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.YearShort", val, value);
    return false;
  }
  
  private static void SetYearShort(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetDayLong(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DayLong>() != null;
  }
  
  private static bool CmpDayLong(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.DayLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DayLong", val, value);
    return false;
  }
  
  private static void SetDayLong(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetMonthLong(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MonthLong>() != null;
  }
  
  private static bool CmpMonthLong(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.MonthLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MonthLong", val, value);
    return false;
  }
  
  private static void SetMonthLong(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetYearLong(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.YearLong>() != null;
  }
  
  private static bool CmpYearLong(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.YearLong>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.YearLong", val, value);
    return false;
  }
  
  private static void SetYearLong(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetAnnotationReferenceMark(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AnnotationReferenceMark>() != null;
  }
  
  private static bool CmpAnnotationReferenceMark(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.AnnotationReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AnnotationReferenceMark", val, value);
    return false;
  }
  
  private static void SetAnnotationReferenceMark(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetFootnoteReferenceMark(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.FootnoteReferenceMark>() != null;
  }
  
  private static bool CmpFootnoteReferenceMark(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.FootnoteReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.FootnoteReferenceMark", val, value);
    return false;
  }
  
  private static void SetFootnoteReferenceMark(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetEndnoteReferenceMark(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.EndnoteReferenceMark>() != null;
  }
  
  private static bool CmpEndnoteReferenceMark(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.EndnoteReferenceMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.EndnoteReferenceMark", val, value);
    return false;
  }
  
  private static void SetEndnoteReferenceMark(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetSeparatorMark(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SeparatorMark>() != null;
  }
  
  private static bool CmpSeparatorMark(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SeparatorMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SeparatorMark", val, value);
    return false;
  }
  
  private static void SetSeparatorMark(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetContinuationSeparatorMark(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ContinuationSeparatorMark>() != null;
  }
  
  private static bool CmpContinuationSeparatorMark(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.ContinuationSeparatorMark>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ContinuationSeparatorMark", val, value);
    return false;
  }
  
  private static void SetContinuationSeparatorMark(DXW.Run openXmlElement, Boolean? value)
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
  
  private static DMW.SymbolChar? GetSymbolChar(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SymbolChar>();
    if (element != null)
      return DMXW.SymbolCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSymbolChar(DXW.Run openXmlElement, DMW.SymbolChar? value, DiffList? diffs, string? objName)
  {
    return DMXW.SymbolCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SymbolChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSymbolChar(DXW.Run openXmlElement, DMW.SymbolChar? value)
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
  
  private static Boolean? GetPageNumber(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PageNumber>() != null;
  }
  
  private static bool CmpPageNumber(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.PageNumber>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PageNumber", val, value);
    return false;
  }
  
  private static void SetPageNumber(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetCarriageReturn(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.CarriageReturn>() != null;
  }
  
  private static bool CmpCarriageReturn(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.CarriageReturn>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.CarriageReturn", val, value);
    return false;
  }
  
  private static void SetCarriageReturn(DXW.Run openXmlElement, Boolean? value)
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
  
  private static Boolean? GetTabChar(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TabChar>() != null;
  }
  
  private static bool CmpTabChar(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.TabChar>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.TabChar", val, value);
    return false;
  }
  
  private static void SetTabChar(DXW.Run openXmlElement, Boolean? value)
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
  
  private static DMW.EmbeddedObject? GetEmbeddedObject(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EmbeddedObject>();
    if (element != null)
      return DMXW.EmbeddedObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEmbeddedObject(DXW.Run openXmlElement, DMW.EmbeddedObject? value, DiffList? diffs, string? objName)
  {
    return DMXW.EmbeddedObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbeddedObject>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbeddedObject(DXW.Run openXmlElement, DMW.EmbeddedObject? value)
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
  
  private static DMW.Picture? GetPicture(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Picture>();
    if (element != null)
      return DMXW.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXW.Run openXmlElement, DMW.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXW.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Picture>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPicture(DXW.Run openXmlElement, DMW.Picture? value)
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
  
  private static DMW.FieldChar? GetFieldChar(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FieldChar>();
    if (element != null)
      return DMXW.FieldCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFieldChar(DXW.Run openXmlElement, DMW.FieldChar? value, DiffList? diffs, string? objName)
  {
    return DMXW.FieldCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FieldChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFieldChar(DXW.Run openXmlElement, DMW.FieldChar? value)
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
  
  private static DMW.Ruby? GetRuby(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Ruby>();
    if (element != null)
      return DMXW.RubyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRuby(DXW.Run openXmlElement, DMW.Ruby? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Ruby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuby(DXW.Run openXmlElement, DMW.Ruby? value)
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
  
  private static DMW.FootnoteEndnoteReferenceType? GetFootnoteReference(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteReference>();
    if (element != null)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFootnoteReference(DXW.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFootnoteReference(DXW.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value)
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
  
  private static DMW.FootnoteEndnoteReferenceType? GetEndnoteReference(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteReference>();
    if (element != null)
      return DMXW.FootnoteEndnoteReferenceTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndnoteReference(DXW.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteEndnoteReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndnoteReference(DXW.Run openXmlElement, DMW.FootnoteEndnoteReferenceType? value)
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
  
  private static DMW.MarkupType? GetCommentReference(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentReference>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentReference(DXW.Run openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentReference(DXW.Run openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.Drawing? GetDrawing(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Drawing>();
    if (element != null)
      return DMXW.DrawingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDrawing(DXW.Run openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Drawing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDrawing(DXW.Run openXmlElement, DMW.Drawing? value)
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
  
  private static DMW.PositionalTab? GetPositionalTab(DXW.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PositionalTab>();
    if (element != null)
      return DMXW.PositionalTabConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPositionalTab(DXW.Run openXmlElement, DMW.PositionalTab? value, DiffList? diffs, string? objName)
  {
    return DMXW.PositionalTabConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PositionalTab>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPositionalTab(DXW.Run openXmlElement, DMW.PositionalTab? value)
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
  
  private static Boolean? GetLastRenderedPageBreak(DXW.Run openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.LastRenderedPageBreak>() != null;
  }
  
  private static bool CmpLastRenderedPageBreak(DXW.Run openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.LastRenderedPageBreak>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.LastRenderedPageBreak", val, value);
    return false;
  }
  
  private static void SetLastRenderedPageBreak(DXW.Run openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Wordprocessing.Run? CreateModelElement(DXW.Run? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Run? value)
    where OpenXmlElementType: DXW.Run, new()
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
