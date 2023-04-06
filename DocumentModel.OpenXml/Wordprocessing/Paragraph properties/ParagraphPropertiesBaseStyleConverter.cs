namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// ParagraphPropertiesBaseStyle class from/to OpenXml converter.
/// </summary>
public static class ParagraphPropertiesBaseStyleConverter
{
  #region KeepNext conversion.
  private static Boolean? GetKeepNext(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.KeepNext>());
  }

  private static bool CmpKeepNext(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.KeepNext>(), value, diffs, objName);
  }

  private static void SetKeepNext(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.KeepNext>(openXmlElement, value);
  }
  #endregion

  #region KeepLines conversion.
  private static Boolean? GetKeepLines(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.KeepLines>());
  }

  private static bool CmpKeepLines(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.KeepLines>(), value, diffs, objName);
  }

  private static void SetKeepLines(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.KeepLines>(openXmlElement, value);
  }
  #endregion

  #region PageBreakBefore conversion.
  private static Boolean? GetPageBreakBefore(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PageBreakBefore>());
  }

  private static bool CmpPageBreakBefore(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PageBreakBefore>(), value, diffs, objName);
  }

  private static void SetPageBreakBefore(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PageBreakBefore>(openXmlElement, value);
  }
  #endregion

  #region FrameProperties conversion.
  private static DMW.FrameProperties? GetFrameProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FrameProperties>();
    if (element != null)
      return DMXW.FramePropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpFrameProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.FrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FrameProperties>(), value, diffs, objName);
  }

  private static void SetFrameProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.FrameProperties? value)
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
  #endregion

  #region WidowControl conversion.
  private static Boolean? GetWidowControl(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WidowControl>());
  }

  private static bool CmpWidowControl(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WidowControl>(), value, diffs, objName);
  }

  private static void SetWidowControl(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WidowControl>(openXmlElement, value);
  }
  #endregion

  #region NumberingProperties conversion.
  private static DMW.NumberingProperties? GetNumberingProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingProperties>();
    if (element != null)
      return DMXW.NumberingPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpNumberingProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingProperties>(), value, diffs, objName);
  }

  private static void SetNumberingProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.NumberingProperties? value)
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
  #endregion

  #region SuppressLineNumbers conversion
  private static Boolean? GetSuppressLineNumbers(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>());
  }

  private static bool CmpSuppressLineNumbers(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>(), value, diffs, objName);
  }

  private static void SetSuppressLineNumbers(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressLineNumbers>(openXmlElement, value);
  }
  #endregion

  #region ParagraphBorders conversion
  private static DMW.ParagraphBorders? GetParagraphBorders(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphBorders>();
    if (element != null)
      return DMXW.ParagraphBordersConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpParagraphBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphBorders>(), value, diffs, objName);
  }

  private static void SetParagraphBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphBorders? value)
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
  #endregion

  #region Shading conversion.
  private static DMW.Shading? GetShading(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }

  private static void SetShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value)
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
  #endregion

  #region Tabs conversion.
  private static DMW.Tabs? GetTabs(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Tabs>();
    if (element != null)
      return DMXW.TabsConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTabs(DX.OpenXmlCompositeElement openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXW.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Tabs>(), value, diffs, objName);
  }

  private static void SetTabs(DX.OpenXmlCompositeElement openXmlElement, DMW.Tabs? value)
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
  #endregion

  #region SuppressAutoHyphens conversion.
  private static Boolean? GetSuppressAutoHyphens(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>());
  }

  private static bool CmpSuppressAutoHyphens(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>(), value, diffs, objName);
  }

  private static void SetSuppressAutoHyphens(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressAutoHyphens>(openXmlElement, value);
  }
  #endregion

  #region Kinsoku conversion.
  private static Boolean? GetKinsoku(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Kinsoku>());
  }

  private static bool CmpKinsoku(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Kinsoku>(), value, diffs, objName);
  }

  private static void SetKinsoku(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Kinsoku>(openXmlElement, value);
  }
  #endregion

  #region WordWrap conversion.
  private static Boolean? GetWordWrap(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WordWrap>());
  }

  private static bool CmpWordWrap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WordWrap>(), value, diffs, objName);
  }

  private static void SetWordWrap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WordWrap>(openXmlElement, value);
  }
  #endregion

  #region OverflowPunctuation conversion.
  private static Boolean? GetOverflowPunctuation(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.OverflowPunctuation>());
  }

  private static bool CmpOverflowPunctuation(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.OverflowPunctuation>(), value, diffs, objName);
  }

  private static void SetOverflowPunctuation(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.OverflowPunctuation>(openXmlElement, value);
  }
  #endregion

  #region TopLinePunctuation conversion.
  private static Boolean? GetTopLinePunctuation(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TopLinePunctuation>());
  }

  private static bool CmpTopLinePunctuation(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TopLinePunctuation>(), value, diffs, objName);
  }

  private static void SetTopLinePunctuation(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TopLinePunctuation>(openXmlElement, value);
  }
  #endregion

  #region AutoSpaceDE conversion.
  private static Boolean? GetAutoSpaceDE(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDE>());
  }

  private static bool CmpAutoSpaceDE(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDE>(), value, diffs, objName);
  }

  private static void SetAutoSpaceDE(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoSpaceDE>(openXmlElement, value);
  }
  #endregion

  #region AutoSpaceDN conversion.
  private static Boolean? GetAutoSpaceDN(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDN>());
  }

  private static bool CmpAutoSpaceDN(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoSpaceDN>(), value, diffs, objName);
  }

  private static void SetAutoSpaceDN(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoSpaceDN>(openXmlElement, value);
  }
  #endregion

  #region BiDi conversion.
  private static Boolean? GetBiDi(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDi>());
  }

  private static bool CmpBiDi(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDi>(), value, diffs, objName);
  }

  private static void SetBiDi(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BiDi>(openXmlElement, value);
  }
  #endregion

  #region AdjustRightIndent conversion.
  private static Boolean? GetAdjustRightIndent(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AdjustRightIndent>());
  }

  private static bool CmpAdjustRightIndent(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AdjustRightIndent>(), value, diffs, objName);
  }

  private static void SetAdjustRightIndent(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AdjustRightIndent>(openXmlElement, value);
  }
  #endregion

  #region SnapToGrid conversion.
  private static Boolean? GetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>());
  }

  private static bool CmpSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>(), value, diffs, objName);
  }

  private static void SetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SnapToGrid>(openXmlElement, value);
  }
  #endregion

  #region SpacingBetweenLines conversion.
  private static DMW.SpacingBetweenLines? GetSpacingBetweenLines(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SpacingBetweenLines>();
    if (element != null)
      return DMXW.SpacingBetweenLinesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpSpacingBetweenLines(DX.OpenXmlCompositeElement openXmlElement, DMW.SpacingBetweenLines? value, DiffList? diffs, string? objName)
  {
    return DMXW.SpacingBetweenLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SpacingBetweenLines>(), value, diffs, objName);
  }

  private static void SetSpacingBetweenLines(DX.OpenXmlCompositeElement openXmlElement, DMW.SpacingBetweenLines? value)
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
  #endregion

  #region Indentation conversion.
  private static DMW.Indentation? GetIndentation(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Indentation>();
    if (element != null)
      return DMXW.IndentationConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpIndentation(DX.OpenXmlCompositeElement openXmlElement, DMW.Indentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.IndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Indentation>(), value, diffs, objName);
  }

  private static void SetIndentation(DX.OpenXmlCompositeElement openXmlElement, DMW.Indentation? value)
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
  #endregion

  #region ContextualSpacing conversion.
  private static Boolean? GetContextualSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ContextualSpacing>());
  }

  private static bool CmpContextualSpacing(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ContextualSpacing>(), value, diffs, objName);
  }

  private static void SetContextualSpacing(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ContextualSpacing>(openXmlElement, value);
  }
  #endregion

  #region MirrorIndents conversion.
  private static Boolean? GetMirrorIndents(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.MirrorIndents>());
  }

  private static bool CmpMirrorIndents(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.MirrorIndents>(), value, diffs, objName);
  }

  private static void SetMirrorIndents(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.MirrorIndents>(openXmlElement, value);
  }
  #endregion

  #region SuppressOverlap conversion.
  private static Boolean? GetSuppressOverlap(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressOverlap>());
  }

  private static bool CmpSuppressOverlap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressOverlap>(), value, diffs, objName);
  }

  private static void SetSuppressOverlap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressOverlap>(openXmlElement, value);
  }
  #endregion

  #region Justification conversion.
  private static DMW.JustificationKind? GetJustification(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value);
  }

  private static bool CmpJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.JustificationKind? value)
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
  #endregion

  #region TextDirection conversion.
  private static DMW.TextDirectionKind? GetTextDirection(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }

  private static bool CmpTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value)
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
  #endregion

  #region TextAlignment conversion.
  private static DMW.VerticalTextAlignmentKind? GetTextAlignment(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value);
  }

  private static bool CmpTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalTextAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalTextAlignmentKind? value)
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
  #endregion

  #region TextBoxTightWrap conversion.
  private static DMW.TextBoxTightWrapKind? GetTextBoxTightWrap(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value);
  }

  private static bool CmpTextBoxTightWrap(DX.OpenXmlCompositeElement openXmlElement, DMW.TextBoxTightWrapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTextBoxTightWrap(DX.OpenXmlCompositeElement openXmlElement, DMW.TextBoxTightWrapKind? value)
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
  #endregion

  #region OutlineLevel conversion.
  private static Int32? GetOutlineLevel(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val);
  }

  private static bool CmpOutlineLevel(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val, value, diffs, objName, "OutlineLevel");
  }

  private static void SetOutlineLevel(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.OutlineLevel, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region ParagraphPropertiesBaseStyle base model conversion methods - for use in other ParagraphProperties converters
  public static ModelElementType? CreateModelElement<ModelElementType>(DX.OpenXmlCompositeElement? openXmlElement)
    where ModelElementType : DMW.BaseParagraphProperties, new()
  {
    if (openXmlElement != null)
    {
      var value = new ModelElementType();
      UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }

  public static DXW.ParagraphPropertiesBaseStyle CreateOpenXmlElement(DMW.BaseParagraphProperties value)
  {
    var openXmlElement = new DXW.ParagraphPropertiesBaseStyle();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateModelElement(DMW.BaseParagraphProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
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
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.BaseParagraphProperties value)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseParagraphProperties value)
  {
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
  #endregion
}
