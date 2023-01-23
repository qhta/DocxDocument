namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Paragraph Properties.
/// </summary>
public static class StyleParagraphPropertiesConverter
{
  /// <summary>
  /// KeepNext.
  /// </summary>
  private static Boolean? GetKeepNext(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.KeepNext>()?.Val?.Value;
  }
  
  private static bool CmpKeepNext(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.KeepNext>()?.Val?.Value == value;
  }
  
  private static void SetKeepNext(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.KeepNext>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.KeepNext();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  private static Boolean? GetKeepLines(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.KeepLines>()?.Val?.Value;
  }
  
  private static bool CmpKeepLines(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.KeepLines>()?.Val?.Value == value;
  }
  
  private static void SetKeepLines(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.KeepLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.KeepLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  private static Boolean? GetPageBreakBefore(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PageBreakBefore>()?.Val?.Value;
  }
  
  private static bool CmpPageBreakBefore(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.PageBreakBefore>()?.Val?.Value == value;
  }
  
  private static void SetPageBreakBefore(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PageBreakBefore>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PageBreakBefore();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  private static DMW.FrameProperties? GetFrameProperties(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.FramePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FrameProperties>());
  }
  
  private static bool CmpFrameProperties(DXW.StyleParagraphProperties openXmlElement, DMW.FrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.FrameProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFrameProperties(DXW.StyleParagraphProperties openXmlElement, DMW.FrameProperties? value)
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
  private static Boolean? GetWidowControl(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WidowControl>()?.Val?.Value;
  }
  
  private static bool CmpWidowControl(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.WidowControl>()?.Val?.Value == value;
  }
  
  private static void SetWidowControl(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WidowControl>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WidowControl();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  private static DMW.NumberingProperties? GetNumberingProperties(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.NumberingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.NumberingProperties>());
  }
  
  private static bool CmpNumberingProperties(DXW.StyleParagraphProperties openXmlElement, DMW.NumberingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.NumberingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingProperties(DXW.StyleParagraphProperties openXmlElement, DMW.NumberingProperties? value)
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
  private static Boolean? GetSuppressLineNumbers(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>()?.Val?.Value;
  }
  
  private static bool CmpSuppressLineNumbers(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>()?.Val?.Value == value;
  }
  
  private static void SetSuppressLineNumbers(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressLineNumbers();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  private static DMW.ParagraphBorders? GetParagraphBorders(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.ParagraphBordersConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphBorders>());
  }
  
  private static bool CmpParagraphBorders(DXW.StyleParagraphProperties openXmlElement, DMW.ParagraphBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphBordersConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphBorders(DXW.StyleParagraphProperties openXmlElement, DMW.ParagraphBorders? value)
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
  private static DMW.Shading? GetShading(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.ShadingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Shading>());
  }
  
  private static bool CmpShading(DXW.StyleParagraphProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.StyleParagraphProperties openXmlElement, DMW.Shading? value)
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
  private static DMW.Tabs? GetTabs(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.TabsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Tabs>());
  }
  
  private static bool CmpTabs(DXW.StyleParagraphProperties openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXW.TabsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Tabs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTabs(DXW.StyleParagraphProperties openXmlElement, DMW.Tabs? value)
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
  private static Boolean? GetSuppressAutoHyphens(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>()?.Val?.Value;
  }
  
  private static bool CmpSuppressAutoHyphens(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>()?.Val?.Value == value;
  }
  
  private static void SetSuppressAutoHyphens(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressAutoHyphens();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  private static Boolean? GetKinsoku(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Kinsoku>()?.Val?.Value;
  }
  
  private static bool CmpKinsoku(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.Kinsoku>()?.Val?.Value == value;
  }
  
  private static void SetKinsoku(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Kinsoku>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Kinsoku();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  private static Boolean? GetWordWrap(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WordWrap>()?.Val?.Value;
  }
  
  private static bool CmpWordWrap(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.WordWrap>()?.Val?.Value == value;
  }
  
  private static void SetWordWrap(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WordWrap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WordWrap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  private static Boolean? GetOverflowPunctuation(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.OverflowPunctuation>()?.Val?.Value;
  }
  
  private static bool CmpOverflowPunctuation(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.OverflowPunctuation>()?.Val?.Value == value;
  }
  
  private static void SetOverflowPunctuation(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.OverflowPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.OverflowPunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  private static Boolean? GetTopLinePunctuation(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TopLinePunctuation>()?.Val?.Value;
  }
  
  private static bool CmpTopLinePunctuation(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.TopLinePunctuation>()?.Val?.Value == value;
  }
  
  private static void SetTopLinePunctuation(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TopLinePunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TopLinePunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  private static Boolean? GetAutoSpaceDE(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDE>()?.Val?.Value;
  }
  
  private static bool CmpAutoSpaceDE(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDE>()?.Val?.Value == value;
  }
  
  private static void SetAutoSpaceDE(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceDE>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoSpaceDE();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  private static Boolean? GetAutoSpaceDN(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDN>()?.Val?.Value;
  }
  
  private static bool CmpAutoSpaceDN(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDN>()?.Val?.Value == value;
  }
  
  private static void SetAutoSpaceDN(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceDN>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoSpaceDN();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  private static Boolean? GetBiDi(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value;
  }
  
  private static bool CmpBiDi(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value == value;
  }
  
  private static void SetBiDi(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BiDi();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  private static Boolean? GetAdjustRightIndent(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AdjustRightIndent>()?.Val?.Value;
  }
  
  private static bool CmpAdjustRightIndent(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AdjustRightIndent>()?.Val?.Value == value;
  }
  
  private static void SetAdjustRightIndent(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AdjustRightIndent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AdjustRightIndent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  private static Boolean? GetSnapToGrid(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SnapToGrid>()?.Val?.Value;
  }
  
  private static bool CmpSnapToGrid(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SnapToGrid>()?.Val?.Value == value;
  }
  
  private static void SetSnapToGrid(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SnapToGrid();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  private static DMW.SpacingBetweenLines? GetSpacingBetweenLines(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.SpacingBetweenLinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SpacingBetweenLines>());
  }
  
  private static bool CmpSpacingBetweenLines(DXW.StyleParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value, DiffList? diffs, string? objName)
  {
    return DMXW.SpacingBetweenLinesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SpacingBetweenLines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpacingBetweenLines(DXW.StyleParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value)
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
  private static DMW.Indentation? GetIndentation(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.IndentationConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Indentation>());
  }
  
  private static bool CmpIndentation(DXW.StyleParagraphProperties openXmlElement, DMW.Indentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.IndentationConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Indentation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetIndentation(DXW.StyleParagraphProperties openXmlElement, DMW.Indentation? value)
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
  private static Boolean? GetContextualSpacing(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ContextualSpacing>()?.Val?.Value;
  }
  
  private static bool CmpContextualSpacing(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ContextualSpacing>()?.Val?.Value == value;
  }
  
  private static void SetContextualSpacing(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ContextualSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ContextualSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  private static Boolean? GetMirrorIndents(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MirrorIndents>()?.Val?.Value;
  }
  
  private static bool CmpMirrorIndents(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.MirrorIndents>()?.Val?.Value == value;
  }
  
  private static void SetMirrorIndents(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MirrorIndents>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MirrorIndents();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  private static Boolean? GetSuppressOverlap(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressOverlap>()?.Val?.Value;
  }
  
  private static bool CmpSuppressOverlap(DXW.StyleParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressOverlap>()?.Val?.Value == value;
  }
  
  private static void SetSuppressOverlap(DXW.StyleParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressOverlap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressOverlap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMW.JustificationKind? GetJustification(DXW.StyleParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value);
  }
  
  private static bool CmpJustification(DXW.StyleParagraphProperties openXmlElement, DMW.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetJustification(DXW.StyleParagraphProperties openXmlElement, DMW.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Justification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Justification, DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  private static DMW.TextDirectionKind? GetTextDirection(DXW.StyleParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }
  
  private static bool CmpTextDirection(DXW.StyleParagraphProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextDirection(DXW.StyleParagraphProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  private static DMW.VerticalTextAlignmentKind? GetTextAlignment(DXW.StyleParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTextAlignment(DXW.StyleParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextAlignment(DXW.StyleParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  private static DMW.TextBoxTightWrapKind? GetTextBoxTightWrap(DXW.StyleParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value);
  }
  
  private static bool CmpTextBoxTightWrap(DXW.StyleParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBoxTightWrap(DXW.StyleParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxTightWrap, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  private static Int32? GetOutlineLevel(DXW.StyleParagraphProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val?.Value;
  }
  
  private static bool CmpOutlineLevel(DXW.StyleParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val?.Value == value;
  }
  
  private static void SetOutlineLevel(DXW.StyleParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.OutlineLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.OutlineLevel{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ParagraphPropertiesChange.
  /// </summary>
  private static DMW.ParagraphPropertiesChange? GetParagraphPropertiesChange(DXW.StyleParagraphProperties openXmlElement)
  {
    return DMXW.ParagraphPropertiesChangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesChange>());
  }
  
  private static bool CmpParagraphPropertiesChange(DXW.StyleParagraphProperties openXmlElement, DMW.ParagraphPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesChangeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphPropertiesChange(DXW.StyleParagraphProperties openXmlElement, DMW.ParagraphPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.StyleParagraphProperties? CreateModelElement(DXW.StyleParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleParagraphProperties();
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
      value.ParagraphPropertiesChange = GetParagraphPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleParagraphProperties? openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs, string? objName)
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
      if (!CmpParagraphPropertiesChange(openXmlElement, value.ParagraphPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleParagraphProperties? value)
    where OpenXmlElementType: DXW.StyleParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      SetParagraphPropertiesChange(openXmlElement, value?.ParagraphPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}
