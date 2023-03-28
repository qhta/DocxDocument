namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Associated Paragraph Properties converter from/to OpenXml.
///</summary>
public static class PreviousParagraphPropertiesConverter
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  private static String? GetParagraphStyleId(DXW.PreviousParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ParagraphStyleId>()?.Val?.Value;
  }
  
  private static bool CmpParagraphStyleId(DXW.PreviousParagraphProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "ParagraphStyleId", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetParagraphStyleId(DXW.PreviousParagraphProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ParagraphStyleId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  private static Boolean? GetKeepNext(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.KeepNext>());
  }
  
  private static bool CmpKeepNext(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.KeepNext>(), value, diffs, objName);
  }
  
  private static void SetKeepNext(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.KeepNext>(openXmlElement, value);
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  private static Boolean? GetKeepLines(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.KeepLines>());
  }
  
  private static bool CmpKeepLines(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.KeepLines>(), value, diffs, objName);
  }
  
  private static void SetKeepLines(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.KeepLines>(openXmlElement, value);
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  private static Boolean? GetPageBreakBefore(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PageBreakBefore>());
  }
  
  private static bool CmpPageBreakBefore(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PageBreakBefore>(), value, diffs, objName);
  }
  
  private static void SetPageBreakBefore(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PageBreakBefore>(openXmlElement, value);
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  private static DMW.FrameProperties? GetFrameProperties(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FrameProperties>();
    if (element != null)
      return DMXW.FramePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFrameProperties(DXW.PreviousParagraphProperties openXmlElement, DMW.FrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FrameProperties>(), value, diffs, objName);
  }
  
  private static void SetFrameProperties(DXW.PreviousParagraphProperties openXmlElement, DMW.FrameProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramePropertiesConverter.CreateOpenXmlElement<DXW.FrameProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  private static Boolean? GetWidowControl(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WidowControl>());
  }
  
  private static bool CmpWidowControl(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WidowControl>(), value, diffs, objName);
  }
  
  private static void SetWidowControl(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WidowControl>(openXmlElement, value);
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  private static DMW.NumberingProperties? GetNumberingProperties(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingProperties>();
    if (element != null)
      return DMXW.NumberingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingProperties(DXW.PreviousParagraphProperties openXmlElement, DMW.NumberingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingProperties>(), value, diffs, objName);
  }
  
  private static void SetNumberingProperties(DXW.PreviousParagraphProperties openXmlElement, DMW.NumberingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingPropertiesConverter.CreateOpenXmlElement<DXW.NumberingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  private static Boolean? GetSuppressLineNumbers(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>());
  }
  
  private static bool CmpSuppressLineNumbers(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>(), value, diffs, objName);
  }
  
  private static void SetSuppressLineNumbers(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressLineNumbers>(openXmlElement, value);
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  private static DMW.ParagraphBorders? GetParagraphBorders(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphBorders>();
    if (element != null)
      return DMXW.ParagraphBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphBorders(DXW.PreviousParagraphProperties openXmlElement, DMW.ParagraphBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphBorders>(), value, diffs, objName);
  }
  
  private static void SetParagraphBorders(DXW.PreviousParagraphProperties openXmlElement, DMW.ParagraphBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphBordersConverter.CreateOpenXmlElement<DXW.ParagraphBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.PreviousParagraphProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.PreviousParagraphProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DMW.Tabs? GetTabs(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Tabs>();
    if (element != null)
      return DMXW.TabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabs(DXW.PreviousParagraphProperties openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXW.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Tabs>(), value, diffs, objName);
  }
  
  private static void SetTabs(DXW.PreviousParagraphProperties openXmlElement, DMW.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TabsConverter.CreateOpenXmlElement<DXW.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  private static Boolean? GetSuppressAutoHyphens(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>());
  }
  
  private static bool CmpSuppressAutoHyphens(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>(), value, diffs, objName);
  }
  
  private static void SetSuppressAutoHyphens(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressAutoHyphens>(openXmlElement, value);
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  private static Boolean? GetKinsoku(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Kinsoku>());
  }
  
  private static bool CmpKinsoku(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Kinsoku>(), value, diffs, objName);
  }
  
  private static void SetKinsoku(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Kinsoku>(openXmlElement, value);
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  private static Boolean? GetWordWrap(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WordWrap>());
  }
  
  private static bool CmpWordWrap(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WordWrap>(), value, diffs, objName);
  }
  
  private static void SetWordWrap(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WordWrap>(openXmlElement, value);
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  private static Boolean? GetOverflowPunctuation(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.OverflowPunctuation>());
  }
  
  private static bool CmpOverflowPunctuation(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.OverflowPunctuation>(), value, diffs, objName);
  }
  
  private static void SetOverflowPunctuation(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.OverflowPunctuation>(openXmlElement, value);
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  private static Boolean? GetTopLinePunctuation(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TopLinePunctuation>());
  }
  
  private static bool CmpTopLinePunctuation(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TopLinePunctuation>(), value, diffs, objName);
  }
  
  private static void SetTopLinePunctuation(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TopLinePunctuation>(openXmlElement, value);
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  private static Boolean? GetAutoSpaceDE(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDE>());
  }
  
  private static bool CmpAutoSpaceDE(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDE>(), value, diffs, objName);
  }
  
  private static void SetAutoSpaceDE(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoSpaceDE>(openXmlElement, value);
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  private static Boolean? GetAutoSpaceDN(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDN>());
  }
  
  private static bool CmpAutoSpaceDN(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDN>(), value, diffs, objName);
  }
  
  private static void SetAutoSpaceDN(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoSpaceDN>(openXmlElement, value);
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  private static Boolean? GetBiDi(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDi>());
  }
  
  private static bool CmpBiDi(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDi>(), value, diffs, objName);
  }
  
  private static void SetBiDi(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BiDi>(openXmlElement, value);
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  private static Boolean? GetAdjustRightIndent(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AdjustRightIndent>());
  }
  
  private static bool CmpAdjustRightIndent(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AdjustRightIndent>(), value, diffs, objName);
  }
  
  private static void SetAdjustRightIndent(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AdjustRightIndent>(openXmlElement, value);
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  private static Boolean? GetSnapToGrid(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>());
  }
  
  private static bool CmpSnapToGrid(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>(), value, diffs, objName);
  }
  
  private static void SetSnapToGrid(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SnapToGrid>(openXmlElement, value);
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  private static DMW.SpacingBetweenLines? GetSpacingBetweenLines(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SpacingBetweenLines>();
    if (element != null)
      return DMXW.SpacingBetweenLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpacingBetweenLines(DXW.PreviousParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value, DiffList? diffs, string? objName)
  {
    return DMXW.SpacingBetweenLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SpacingBetweenLines>(), value, diffs, objName);
  }
  
  private static void SetSpacingBetweenLines(DXW.PreviousParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SpacingBetweenLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SpacingBetweenLinesConverter.CreateOpenXmlElement<DXW.SpacingBetweenLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  private static DMW.Indentation? GetIndentation(DXW.PreviousParagraphProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Indentation>();
    if (element != null)
      return DMXW.IndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpIndentation(DXW.PreviousParagraphProperties openXmlElement, DMW.Indentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.IndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Indentation>(), value, diffs, objName);
  }
  
  private static void SetIndentation(DXW.PreviousParagraphProperties openXmlElement, DMW.Indentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Indentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.IndentationConverter.CreateOpenXmlElement<DXW.Indentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  private static Boolean? GetContextualSpacing(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ContextualSpacing>());
  }
  
  private static bool CmpContextualSpacing(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ContextualSpacing>(), value, diffs, objName);
  }
  
  private static void SetContextualSpacing(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ContextualSpacing>(openXmlElement, value);
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  private static Boolean? GetMirrorIndents(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.MirrorIndents>());
  }
  
  private static bool CmpMirrorIndents(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.MirrorIndents>(), value, diffs, objName);
  }
  
  private static void SetMirrorIndents(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.MirrorIndents>(openXmlElement, value);
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  private static Boolean? GetSuppressOverlap(DXW.PreviousParagraphProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressOverlap>());
  }
  
  private static bool CmpSuppressOverlap(DXW.PreviousParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressOverlap>(), value, diffs, objName);
  }
  
  private static void SetSuppressOverlap(DXW.PreviousParagraphProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressOverlap>(openXmlElement, value);
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMW.JustificationKind? GetJustification(DXW.PreviousParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value);
  }
  
  private static bool CmpJustification(DXW.PreviousParagraphProperties openXmlElement, DMW.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetJustification(DXW.PreviousParagraphProperties openXmlElement, DMW.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Justification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(itemElement, (DMW.JustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Justification, DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>((DMW.JustificationKind)value));
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  private static DMW.TextDirectionKind? GetTextDirection(DXW.PreviousParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }
  
  private static bool CmpTextDirection(DXW.PreviousParagraphProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTextDirection(DXW.PreviousParagraphProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  private static DMW.VerticalTextAlignmentKind? GetTextAlignment(DXW.PreviousParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTextAlignment(DXW.PreviousParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTextAlignment(DXW.PreviousParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(itemElement, (DMW.VerticalTextAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>((DMW.VerticalTextAlignmentKind)value));
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  private static DMW.TextBoxTightWrapKind? GetTextBoxTightWrap(DXW.PreviousParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value);
  }
  
  private static bool CmpTextBoxTightWrap(DXW.PreviousParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTextBoxTightWrap(DXW.PreviousParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(itemElement, (DMW.TextBoxTightWrapKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxTightWrap, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>((DMW.TextBoxTightWrapKind)value));
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  private static Int32? GetOutlineLevel(DXW.PreviousParagraphProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val);
  }
  
  private static bool CmpOutlineLevel(DXW.PreviousParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val, value, diffs, objName, "OutlineLevel");
  }
  
  private static void SetOutlineLevel(DXW.PreviousParagraphProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.OutlineLevel,System.Int32>(openXmlElement, value);
  }
  
  public static DMW.PreviousParagraphProperties? CreateModelElement(DXW.PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousParagraphProperties();
      value.ParagraphStyleId = GetParagraphStyleId(openXmlElement);
      value.KeepNext = GetKeepNext(openXmlElement);
      value.KeepLines = GetKeepLines(openXmlElement);
      value.PageBreakBefore = GetPageBreakBefore(openXmlElement);
      value.FrameProperties = GetFrameProperties(openXmlElement);
      value.WidowControl = GetWidowControl(openXmlElement);
      value.NumberingProperties = GetNumberingProperties(openXmlElement);
      value.SuppressLineNumbers = GetSuppressLineNumbers(openXmlElement);
      value.ParagraphBorders = GetParagraphBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.SuppressAutoHyphens = GetSuppressAutoHyphens(openXmlElement);
      value.Kinsoku = GetKinsoku(openXmlElement);
      value.WordWrap = GetWordWrap(openXmlElement);
      value.OverflowPunctuation = GetOverflowPunctuation(openXmlElement);
      value.TopLinePunctuation = GetTopLinePunctuation(openXmlElement);
      value.AutoSpaceDE = GetAutoSpaceDE(openXmlElement);
      value.AutoSpaceDN = GetAutoSpaceDN(openXmlElement);
      value.BiDi = GetBiDi(openXmlElement);
      value.AdjustRightIndent = GetAdjustRightIndent(openXmlElement);
      value.SnapToGrid = GetSnapToGrid(openXmlElement);
      value.SpacingBetweenLines = GetSpacingBetweenLines(openXmlElement);
      value.Indentation = GetIndentation(openXmlElement);
      value.ContextualSpacing = GetContextualSpacing(openXmlElement);
      value.MirrorIndents = GetMirrorIndents(openXmlElement);
      value.SuppressOverlap = GetSuppressOverlap(openXmlElement);
      value.Justification = GetJustification(openXmlElement);
      value.TextDirection = GetTextDirection(openXmlElement);
      value.TextAlignment = GetTextAlignment(openXmlElement);
      value.TextBoxTightWrap = GetTextBoxTightWrap(openXmlElement);
      value.OutlineLevel = GetOutlineLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousParagraphProperties? openXmlElement, DMW.PreviousParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParagraphStyleId(openXmlElement, value.ParagraphStyleId, diffs, objName))
        ok = false;
      if (!CmpKeepNext(openXmlElement, value.KeepNext, diffs, objName))
        ok = false;
      if (!CmpKeepLines(openXmlElement, value.KeepLines, diffs, objName))
        ok = false;
      if (!CmpPageBreakBefore(openXmlElement, value.PageBreakBefore, diffs, objName))
        ok = false;
      if (!CmpFrameProperties(openXmlElement, value.FrameProperties, diffs, objName))
        ok = false;
      if (!CmpWidowControl(openXmlElement, value.WidowControl, diffs, objName))
        ok = false;
      if (!CmpNumberingProperties(openXmlElement, value.NumberingProperties, diffs, objName))
        ok = false;
      if (!CmpSuppressLineNumbers(openXmlElement, value.SuppressLineNumbers, diffs, objName))
        ok = false;
      if (!CmpParagraphBorders(openXmlElement, value.ParagraphBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName))
        ok = false;
      if (!CmpSuppressAutoHyphens(openXmlElement, value.SuppressAutoHyphens, diffs, objName))
        ok = false;
      if (!CmpKinsoku(openXmlElement, value.Kinsoku, diffs, objName))
        ok = false;
      if (!CmpWordWrap(openXmlElement, value.WordWrap, diffs, objName))
        ok = false;
      if (!CmpOverflowPunctuation(openXmlElement, value.OverflowPunctuation, diffs, objName))
        ok = false;
      if (!CmpTopLinePunctuation(openXmlElement, value.TopLinePunctuation, diffs, objName))
        ok = false;
      if (!CmpAutoSpaceDE(openXmlElement, value.AutoSpaceDE, diffs, objName))
        ok = false;
      if (!CmpAutoSpaceDN(openXmlElement, value.AutoSpaceDN, diffs, objName))
        ok = false;
      if (!CmpBiDi(openXmlElement, value.BiDi, diffs, objName))
        ok = false;
      if (!CmpAdjustRightIndent(openXmlElement, value.AdjustRightIndent, diffs, objName))
        ok = false;
      if (!CmpSnapToGrid(openXmlElement, value.SnapToGrid, diffs, objName))
        ok = false;
      if (!CmpSpacingBetweenLines(openXmlElement, value.SpacingBetweenLines, diffs, objName))
        ok = false;
      if (!CmpIndentation(openXmlElement, value.Indentation, diffs, objName))
        ok = false;
      if (!CmpContextualSpacing(openXmlElement, value.ContextualSpacing, diffs, objName))
        ok = false;
      if (!CmpMirrorIndents(openXmlElement, value.MirrorIndents, diffs, objName))
        ok = false;
      if (!CmpSuppressOverlap(openXmlElement, value.SuppressOverlap, diffs, objName))
        ok = false;
      if (!CmpJustification(openXmlElement, value.Justification, diffs, objName))
        ok = false;
      if (!CmpTextDirection(openXmlElement, value.TextDirection, diffs, objName))
        ok = false;
      if (!CmpTextAlignment(openXmlElement, value.TextAlignment, diffs, objName))
        ok = false;
      if (!CmpTextBoxTightWrap(openXmlElement, value.TextBoxTightWrap, diffs, objName))
        ok = false;
      if (!CmpOutlineLevel(openXmlElement, value.OutlineLevel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousParagraphProperties value)
    where OpenXmlElementType: DXW.PreviousParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousParagraphProperties openXmlElement, DMW.PreviousParagraphProperties value)
  {
    SetParagraphStyleId(openXmlElement, value?.ParagraphStyleId);
    SetKeepNext(openXmlElement, value?.KeepNext);
    SetKeepLines(openXmlElement, value?.KeepLines);
    SetPageBreakBefore(openXmlElement, value?.PageBreakBefore);
    SetFrameProperties(openXmlElement, value?.FrameProperties);
    SetWidowControl(openXmlElement, value?.WidowControl);
    SetNumberingProperties(openXmlElement, value?.NumberingProperties);
    SetSuppressLineNumbers(openXmlElement, value?.SuppressLineNumbers);
    SetParagraphBorders(openXmlElement, value?.ParagraphBorders);
    SetShading(openXmlElement, value?.Shading);
    SetTabs(openXmlElement, value?.Tabs);
    SetSuppressAutoHyphens(openXmlElement, value?.SuppressAutoHyphens);
    SetKinsoku(openXmlElement, value?.Kinsoku);
    SetWordWrap(openXmlElement, value?.WordWrap);
    SetOverflowPunctuation(openXmlElement, value?.OverflowPunctuation);
    SetTopLinePunctuation(openXmlElement, value?.TopLinePunctuation);
    SetAutoSpaceDE(openXmlElement, value?.AutoSpaceDE);
    SetAutoSpaceDN(openXmlElement, value?.AutoSpaceDN);
    SetBiDi(openXmlElement, value?.BiDi);
    SetAdjustRightIndent(openXmlElement, value?.AdjustRightIndent);
    SetSnapToGrid(openXmlElement, value?.SnapToGrid);
    SetSpacingBetweenLines(openXmlElement, value?.SpacingBetweenLines);
    SetIndentation(openXmlElement, value?.Indentation);
    SetContextualSpacing(openXmlElement, value?.ContextualSpacing);
    SetMirrorIndents(openXmlElement, value?.MirrorIndents);
    SetSuppressOverlap(openXmlElement, value?.SuppressOverlap);
    SetJustification(openXmlElement, value?.Justification);
    SetTextDirection(openXmlElement, value?.TextDirection);
    SetTextAlignment(openXmlElement, value?.TextAlignment);
    SetTextBoxTightWrap(openXmlElement, value?.TextBoxTightWrap);
    SetOutlineLevel(openXmlElement, value?.OutlineLevel);
  }
}
