namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Compatibility Settings.
/// </summary>
public static class CompatibilityConverter
{
  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  private static Boolean? GetUseSingleBorderForContiguousCells(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseSingleBorderForContiguousCells>());
  }
  
  private static bool CmpUseSingleBorderForContiguousCells(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseSingleBorderForContiguousCells>(), value, diffs, objName);
  }
  
  private static void SetUseSingleBorderForContiguousCells(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseSingleBorderForContiguousCells>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  private static Boolean? GetWordPerfectJustification(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WordPerfectJustification>());
  }
  
  private static bool CmpWordPerfectJustification(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WordPerfectJustification>(), value, diffs, objName);
  }
  
  private static void SetWordPerfectJustification(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WordPerfectJustification>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  private static Boolean? GetNoTabHangIndent(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoTabHangIndent>());
  }
  
  private static bool CmpNoTabHangIndent(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoTabHangIndent>(), value, diffs, objName);
  }
  
  private static void SetNoTabHangIndent(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoTabHangIndent>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  private static Boolean? GetNoLeading(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoLeading>());
  }
  
  private static bool CmpNoLeading(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoLeading>(), value, diffs, objName);
  }
  
  private static void SetNoLeading(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoLeading>(openXmlElement, value);
  }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  private static Boolean? GetSpaceForUnderline(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SpaceForUnderline>());
  }
  
  private static bool CmpSpaceForUnderline(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SpaceForUnderline>(), value, diffs, objName);
  }
  
  private static void SetSpaceForUnderline(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SpaceForUnderline>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  private static Boolean? GetNoColumnBalance(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoColumnBalance>());
  }
  
  private static bool CmpNoColumnBalance(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoColumnBalance>(), value, diffs, objName);
  }
  
  private static void SetNoColumnBalance(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoColumnBalance>(openXmlElement, value);
  }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  private static Boolean? GetBalanceSingleByteDoubleByteWidth(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>());
  }
  
  private static bool CmpBalanceSingleByteDoubleByteWidth(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>(), value, diffs, objName);
  }
  
  private static void SetBalanceSingleByteDoubleByteWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BalanceSingleByteDoubleByteWidth>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  private static Boolean? GetNoExtraLineSpacing(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoExtraLineSpacing>());
  }
  
  private static bool CmpNoExtraLineSpacing(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoExtraLineSpacing>(), value, diffs, objName);
  }
  
  private static void SetNoExtraLineSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoExtraLineSpacing>(openXmlElement, value);
  }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  private static Boolean? GetDoNotLeaveBackslashAlone(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotLeaveBackslashAlone>());
  }
  
  private static bool CmpDoNotLeaveBackslashAlone(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotLeaveBackslashAlone>(), value, diffs, objName);
  }
  
  private static void SetDoNotLeaveBackslashAlone(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotLeaveBackslashAlone>(openXmlElement, value);
  }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  private static Boolean? GetUnderlineTrailingSpaces(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UnderlineTrailingSpaces>());
  }
  
  private static bool CmpUnderlineTrailingSpaces(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UnderlineTrailingSpaces>(), value, diffs, objName);
  }
  
  private static void SetUnderlineTrailingSpaces(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UnderlineTrailingSpaces>(openXmlElement, value);
  }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  private static Boolean? GetDoNotExpandShiftReturn(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotExpandShiftReturn>());
  }
  
  private static bool CmpDoNotExpandShiftReturn(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotExpandShiftReturn>(), value, diffs, objName);
  }
  
  private static void SetDoNotExpandShiftReturn(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotExpandShiftReturn>(openXmlElement, value);
  }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  private static Boolean? GetSpacingInWholePoints(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SpacingInWholePoints>());
  }
  
  private static bool CmpSpacingInWholePoints(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SpacingInWholePoints>(), value, diffs, objName);
  }
  
  private static void SetSpacingInWholePoints(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SpacingInWholePoints>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  private static Boolean? GetLineWrapLikeWord6(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.LineWrapLikeWord6>());
  }
  
  private static bool CmpLineWrapLikeWord6(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LineWrapLikeWord6>(), value, diffs, objName);
  }
  
  private static void SetLineWrapLikeWord6(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.LineWrapLikeWord6>(openXmlElement, value);
  }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  private static Boolean? GetPrintBodyTextBeforeHeader(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintBodyTextBeforeHeader>());
  }
  
  private static bool CmpPrintBodyTextBeforeHeader(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintBodyTextBeforeHeader>(), value, diffs, objName);
  }
  
  private static void SetPrintBodyTextBeforeHeader(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintBodyTextBeforeHeader>(openXmlElement, value);
  }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  private static Boolean? GetPrintColorBlackWhite(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintColorBlackWhite>());
  }
  
  private static bool CmpPrintColorBlackWhite(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintColorBlackWhite>(), value, diffs, objName);
  }
  
  private static void SetPrintColorBlackWhite(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintColorBlackWhite>(openXmlElement, value);
  }
  
  /// <summary>
  /// Space width.
  /// </summary>
  private static Boolean? GetWordPerfectSpaceWidth(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WordPerfectSpaceWidth>());
  }
  
  private static bool CmpWordPerfectSpaceWidth(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WordPerfectSpaceWidth>(), value, diffs, objName);
  }
  
  private static void SetWordPerfectSpaceWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WordPerfectSpaceWidth>(openXmlElement, value);
  }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  private static Boolean? GetShowBreaksInFrames(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ShowBreaksInFrames>());
  }
  
  private static bool CmpShowBreaksInFrames(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ShowBreaksInFrames>(), value, diffs, objName);
  }
  
  private static void SetShowBreaksInFrames(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ShowBreaksInFrames>(openXmlElement, value);
  }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  private static Boolean? GetSubFontBySize(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SubFontBySize>());
  }
  
  private static bool CmpSubFontBySize(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SubFontBySize>(), value, diffs, objName);
  }
  
  private static void SetSubFontBySize(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SubFontBySize>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  private static Boolean? GetSuppressBottomSpacing(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressBottomSpacing>());
  }
  
  private static bool CmpSuppressBottomSpacing(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressBottomSpacing>(), value, diffs, objName);
  }
  
  private static void SetSuppressBottomSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressBottomSpacing>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressTopSpacing(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressTopSpacing>());
  }
  
  private static bool CmpSuppressTopSpacing(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressTopSpacing>(), value, diffs, objName);
  }
  
  private static void SetSuppressTopSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressTopSpacing>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressSpacingAtTopOfPage(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>());
  }
  
  private static bool CmpSuppressSpacingAtTopOfPage(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>(), value, diffs, objName);
  }
  
  private static void SetSuppressSpacingAtTopOfPage(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressSpacingAtTopOfPage>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  private static Boolean? GetSuppressTopSpacingWordPerfect(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>());
  }
  
  private static bool CmpSuppressTopSpacingWordPerfect(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>(), value, diffs, objName);
  }
  
  private static void SetSuppressTopSpacingWordPerfect(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressTopSpacingWordPerfect>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  private static Boolean? GetSuppressSpacingBeforeAfterPageBreak(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>());
  }
  
  private static bool CmpSuppressSpacingBeforeAfterPageBreak(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>(), value, diffs, objName);
  }
  
  private static void SetSuppressSpacingBeforeAfterPageBreak(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SuppressSpacingBeforeAfterPageBreak>(openXmlElement, value);
  }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  private static Boolean? GetSwapBordersFacingPages(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SwapBordersFacingPages>());
  }
  
  private static bool CmpSwapBordersFacingPages(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SwapBordersFacingPages>(), value, diffs, objName);
  }
  
  private static void SetSwapBordersFacingPages(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SwapBordersFacingPages>(openXmlElement, value);
  }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  private static Boolean? GetConvertMailMergeEscape(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ConvertMailMergeEscape>());
  }
  
  private static bool CmpConvertMailMergeEscape(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ConvertMailMergeEscape>(), value, diffs, objName);
  }
  
  private static void SetConvertMailMergeEscape(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ConvertMailMergeEscape>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  private static Boolean? GetTruncateFontHeightsLikeWordPerfect(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>());
  }
  
  private static bool CmpTruncateFontHeightsLikeWordPerfect(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>(), value, diffs, objName);
  }
  
  private static void SetTruncateFontHeightsLikeWordPerfect(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TruncateFontHeightsLikeWordPerfect>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  private static Boolean? GetMacWordSmallCaps(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.MacWordSmallCaps>());
  }
  
  private static bool CmpMacWordSmallCaps(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.MacWordSmallCaps>(), value, diffs, objName);
  }
  
  private static void SetMacWordSmallCaps(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.MacWordSmallCaps>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  private static Boolean? GetUsePrinterMetrics(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UsePrinterMetrics>());
  }
  
  private static bool CmpUsePrinterMetrics(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UsePrinterMetrics>(), value, diffs, objName);
  }
  
  private static void SetUsePrinterMetrics(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UsePrinterMetrics>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  private static Boolean? GetDoNotSuppressParagraphBorders(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotSuppressParagraphBorders>());
  }
  
  private static bool CmpDoNotSuppressParagraphBorders(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotSuppressParagraphBorders>(), value, diffs, objName);
  }
  
  private static void SetDoNotSuppressParagraphBorders(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotSuppressParagraphBorders>(openXmlElement, value);
  }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  private static Boolean? GetWrapTrailSpaces(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WrapTrailSpaces>());
  }
  
  private static bool CmpWrapTrailSpaces(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WrapTrailSpaces>(), value, diffs, objName);
  }
  
  private static void SetWrapTrailSpaces(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WrapTrailSpaces>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  private static Boolean? GetFootnoteLayoutLikeWord8(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FootnoteLayoutLikeWord8>());
  }
  
  private static bool CmpFootnoteLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FootnoteLayoutLikeWord8>(), value, diffs, objName);
  }
  
  private static void SetFootnoteLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.FootnoteLayoutLikeWord8>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  private static Boolean? GetShapeLayoutLikeWord8(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ShapeLayoutLikeWord8>());
  }
  
  private static bool CmpShapeLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ShapeLayoutLikeWord8>(), value, diffs, objName);
  }
  
  private static void SetShapeLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ShapeLayoutLikeWord8>(openXmlElement, value);
  }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  private static Boolean? GetAlignTablesRowByRow(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AlignTablesRowByRow>());
  }
  
  private static bool CmpAlignTablesRowByRow(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AlignTablesRowByRow>(), value, diffs, objName);
  }
  
  private static void SetAlignTablesRowByRow(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AlignTablesRowByRow>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  private static Boolean? GetForgetLastTabAlignment(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ForgetLastTabAlignment>());
  }
  
  private static bool CmpForgetLastTabAlignment(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ForgetLastTabAlignment>(), value, diffs, objName);
  }
  
  private static void SetForgetLastTabAlignment(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ForgetLastTabAlignment>(openXmlElement, value);
  }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  private static Boolean? GetAdjustLineHeightInTable(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AdjustLineHeightInTable>());
  }
  
  private static bool CmpAdjustLineHeightInTable(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AdjustLineHeightInTable>(), value, diffs, objName);
  }
  
  private static void SetAdjustLineHeightInTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AdjustLineHeightInTable>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  private static Boolean? GetAutoSpaceLikeWord95(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoSpaceLikeWord95>());
  }
  
  private static bool CmpAutoSpaceLikeWord95(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoSpaceLikeWord95>(), value, diffs, objName);
  }
  
  private static void SetAutoSpaceLikeWord95(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoSpaceLikeWord95>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  private static Boolean? GetNoSpaceRaiseLower(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoSpaceRaiseLower>());
  }
  
  private static bool CmpNoSpaceRaiseLower(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoSpaceRaiseLower>(), value, diffs, objName);
  }
  
  private static void SetNoSpaceRaiseLower(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoSpaceRaiseLower>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  private static Boolean? GetDoNotUseHTMLParagraphAutoSpacing(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>());
  }
  
  private static bool CmpDoNotUseHTMLParagraphAutoSpacing(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>(), value, diffs, objName);
  }
  
  private static void SetDoNotUseHTMLParagraphAutoSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotUseHTMLParagraphAutoSpacing>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  private static Boolean? GetLayoutRawTableWidth(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.LayoutRawTableWidth>());
  }
  
  private static bool CmpLayoutRawTableWidth(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LayoutRawTableWidth>(), value, diffs, objName);
  }
  
  private static void SetLayoutRawTableWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.LayoutRawTableWidth>(openXmlElement, value);
  }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  private static Boolean? GetLayoutTableRowsApart(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.LayoutTableRowsApart>());
  }
  
  private static bool CmpLayoutTableRowsApart(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LayoutTableRowsApart>(), value, diffs, objName);
  }
  
  private static void SetLayoutTableRowsApart(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.LayoutTableRowsApart>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  private static Boolean? GetUseWord97LineBreakRules(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseWord97LineBreakRules>());
  }
  
  private static bool CmpUseWord97LineBreakRules(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseWord97LineBreakRules>(), value, diffs, objName);
  }
  
  private static void SetUseWord97LineBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseWord97LineBreakRules>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  private static Boolean? GetDoNotBreakWrappedTables(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotBreakWrappedTables>());
  }
  
  private static bool CmpDoNotBreakWrappedTables(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotBreakWrappedTables>(), value, diffs, objName);
  }
  
  private static void SetDoNotBreakWrappedTables(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotBreakWrappedTables>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  private static Boolean? GetDoNotSnapToGridInCell(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotSnapToGridInCell>());
  }
  
  private static bool CmpDoNotSnapToGridInCell(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotSnapToGridInCell>(), value, diffs, objName);
  }
  
  private static void SetDoNotSnapToGridInCell(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotSnapToGridInCell>(openXmlElement, value);
  }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  private static Boolean? GetSelectFieldWithFirstOrLastChar(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>());
  }
  
  private static bool CmpSelectFieldWithFirstOrLastChar(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>(), value, diffs, objName);
  }
  
  private static void SetSelectFieldWithFirstOrLastChar(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SelectFieldWithFirstOrLastChar>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  private static Boolean? GetApplyBreakingRules(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ApplyBreakingRules>());
  }
  
  private static bool CmpApplyBreakingRules(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ApplyBreakingRules>(), value, diffs, objName);
  }
  
  private static void SetApplyBreakingRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ApplyBreakingRules>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  private static Boolean? GetDoNotWrapTextWithPunctuation(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>());
  }
  
  private static bool CmpDoNotWrapTextWithPunctuation(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>(), value, diffs, objName);
  }
  
  private static void SetDoNotWrapTextWithPunctuation(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotWrapTextWithPunctuation>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  private static Boolean? GetDoNotUseEastAsianBreakRules(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>());
  }
  
  private static bool CmpDoNotUseEastAsianBreakRules(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>(), value, diffs, objName);
  }
  
  private static void SetDoNotUseEastAsianBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotUseEastAsianBreakRules>(openXmlElement, value);
  }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  private static Boolean? GetUseWord2002TableStyleRules(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseWord2002TableStyleRules>());
  }
  
  private static bool CmpUseWord2002TableStyleRules(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseWord2002TableStyleRules>(), value, diffs, objName);
  }
  
  private static void SetUseWord2002TableStyleRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseWord2002TableStyleRules>(openXmlElement, value);
  }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  private static Boolean? GetGrowAutofit(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.GrowAutofit>());
  }
  
  private static bool CmpGrowAutofit(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.GrowAutofit>(), value, diffs, objName);
  }
  
  private static void SetGrowAutofit(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.GrowAutofit>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  private static Boolean? GetUseFarEastLayout(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseFarEastLayout>());
  }
  
  private static bool CmpUseFarEastLayout(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseFarEastLayout>(), value, diffs, objName);
  }
  
  private static void SetUseFarEastLayout(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseFarEastLayout>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  private static Boolean? GetUseNormalStyleForList(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseNormalStyleForList>());
  }
  
  private static bool CmpUseNormalStyleForList(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseNormalStyleForList>(), value, diffs, objName);
  }
  
  private static void SetUseNormalStyleForList(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseNormalStyleForList>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  private static Boolean? GetDoNotUseIndentAsNumberingTabStop(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>());
  }
  
  private static bool CmpDoNotUseIndentAsNumberingTabStop(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>(), value, diffs, objName);
  }
  
  private static void SetDoNotUseIndentAsNumberingTabStop(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotUseIndentAsNumberingTabStop>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  private static Boolean? GetUseAltKinsokuLineBreakRules(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>());
  }
  
  private static bool CmpUseAltKinsokuLineBreakRules(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>(), value, diffs, objName);
  }
  
  private static void SetUseAltKinsokuLineBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseAltKinsokuLineBreakRules>(openXmlElement, value);
  }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  private static Boolean? GetAllowSpaceOfSameStyleInTable(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>());
  }
  
  private static bool CmpAllowSpaceOfSameStyleInTable(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>(), value, diffs, objName);
  }
  
  private static void SetAllowSpaceOfSameStyleInTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AllowSpaceOfSameStyleInTable>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  private static Boolean? GetDoNotSuppressIndentation(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotSuppressIndentation>());
  }
  
  private static bool CmpDoNotSuppressIndentation(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotSuppressIndentation>(), value, diffs, objName);
  }
  
  private static void SetDoNotSuppressIndentation(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotSuppressIndentation>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  private static Boolean? GetDoNotAutofitConstrainedTables(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotAutofitConstrainedTables>());
  }
  
  private static bool CmpDoNotAutofitConstrainedTables(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotAutofitConstrainedTables>(), value, diffs, objName);
  }
  
  private static void SetDoNotAutofitConstrainedTables(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotAutofitConstrainedTables>(openXmlElement, value);
  }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  private static Boolean? GetAutofitToFirstFixedWidthCell(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>());
  }
  
  private static bool CmpAutofitToFirstFixedWidthCell(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>(), value, diffs, objName);
  }
  
  private static void SetAutofitToFirstFixedWidthCell(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutofitToFirstFixedWidthCell>(openXmlElement, value);
  }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  private static Boolean? GetUnderlineTabInNumberingList(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UnderlineTabInNumberingList>());
  }
  
  private static bool CmpUnderlineTabInNumberingList(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UnderlineTabInNumberingList>(), value, diffs, objName);
  }
  
  private static void SetUnderlineTabInNumberingList(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UnderlineTabInNumberingList>(openXmlElement, value);
  }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  private static Boolean? GetDisplayHangulFixedWidth(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DisplayHangulFixedWidth>());
  }
  
  private static bool CmpDisplayHangulFixedWidth(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DisplayHangulFixedWidth>(), value, diffs, objName);
  }
  
  private static void SetDisplayHangulFixedWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DisplayHangulFixedWidth>(openXmlElement, value);
  }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  private static Boolean? GetSplitPageBreakAndParagraphMark(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>());
  }
  
  private static bool CmpSplitPageBreakAndParagraphMark(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>(), value, diffs, objName);
  }
  
  private static void SetSplitPageBreakAndParagraphMark(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SplitPageBreakAndParagraphMark>(openXmlElement, value);
  }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignCellWithShape(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>());
  }
  
  private static bool CmpDoNotVerticallyAlignCellWithShape(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>(), value, diffs, objName);
  }
  
  private static void SetDoNotVerticallyAlignCellWithShape(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotVerticallyAlignCellWithShape>(openXmlElement, value);
  }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  private static Boolean? GetDoNotBreakConstrainedForcedTable(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>());
  }
  
  private static bool CmpDoNotBreakConstrainedForcedTable(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>(), value, diffs, objName);
  }
  
  private static void SetDoNotBreakConstrainedForcedTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotBreakConstrainedForcedTable>(openXmlElement, value);
  }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignInTextBox(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>());
  }
  
  private static bool CmpDoNotVerticallyAlignInTextBox(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>(), value, diffs, objName);
  }
  
  private static void SetDoNotVerticallyAlignInTextBox(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotVerticallyAlignInTextBox>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  private static Boolean? GetUseAnsiKerningPairs(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseAnsiKerningPairs>());
  }
  
  private static bool CmpUseAnsiKerningPairs(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseAnsiKerningPairs>(), value, diffs, objName);
  }
  
  private static void SetUseAnsiKerningPairs(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseAnsiKerningPairs>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  private static Boolean? GetCachedColumnBalance(DXW.Compatibility openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CachedColumnBalance>());
  }
  
  private static bool CmpCachedColumnBalance(DXW.Compatibility openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CachedColumnBalance>(), value, diffs, objName);
  }
  
  private static void SetCachedColumnBalance(DXW.Compatibility openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.CachedColumnBalance>(openXmlElement, value);
  }
  
  private static ElementCollection<DMW.CompatibilitySetting>? GetCompatibilitySettings(DXW.Compatibility openXmlElement)
  {
    var collection = new ElementCollection<DMW.CompatibilitySetting>();
    foreach (var item in openXmlElement.Elements<DXW.CompatibilitySetting>())
    {
      var newItem = DMXW.CompatibilitySettingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCompatibilitySettings(DXW.Compatibility openXmlElement, ICollection<DMW.CompatibilitySetting>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.CompatibilitySetting>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.CompatibilitySettingConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCompatibilitySettings(DXW.Compatibility openXmlElement, ICollection<DMW.CompatibilitySetting>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.CompatibilitySetting>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CompatibilitySettingConverter.CreateOpenXmlElement<DXW.CompatibilitySetting>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Compatibility? CreateModelElement(DXW.Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Compatibility();
      value.UseSingleBorderForContiguousCells = GetUseSingleBorderForContiguousCells(openXmlElement);
      value.WordPerfectJustification = GetWordPerfectJustification(openXmlElement);
      value.NoTabHangIndent = GetNoTabHangIndent(openXmlElement);
      value.NoLeading = GetNoLeading(openXmlElement);
      value.SpaceForUnderline = GetSpaceForUnderline(openXmlElement);
      value.NoColumnBalance = GetNoColumnBalance(openXmlElement);
      value.BalanceSingleByteDoubleByteWidth = GetBalanceSingleByteDoubleByteWidth(openXmlElement);
      value.NoExtraLineSpacing = GetNoExtraLineSpacing(openXmlElement);
      value.DoNotLeaveBackslashAlone = GetDoNotLeaveBackslashAlone(openXmlElement);
      value.UnderlineTrailingSpaces = GetUnderlineTrailingSpaces(openXmlElement);
      value.DoNotExpandShiftReturn = GetDoNotExpandShiftReturn(openXmlElement);
      value.SpacingInWholePoints = GetSpacingInWholePoints(openXmlElement);
      value.LineWrapLikeWord6 = GetLineWrapLikeWord6(openXmlElement);
      value.PrintBodyTextBeforeHeader = GetPrintBodyTextBeforeHeader(openXmlElement);
      value.PrintColorBlackWhite = GetPrintColorBlackWhite(openXmlElement);
      value.WordPerfectSpaceWidth = GetWordPerfectSpaceWidth(openXmlElement);
      value.ShowBreaksInFrames = GetShowBreaksInFrames(openXmlElement);
      value.SubFontBySize = GetSubFontBySize(openXmlElement);
      value.SuppressBottomSpacing = GetSuppressBottomSpacing(openXmlElement);
      value.SuppressTopSpacing = GetSuppressTopSpacing(openXmlElement);
      value.SuppressSpacingAtTopOfPage = GetSuppressSpacingAtTopOfPage(openXmlElement);
      value.SuppressTopSpacingWordPerfect = GetSuppressTopSpacingWordPerfect(openXmlElement);
      value.SuppressSpacingBeforeAfterPageBreak = GetSuppressSpacingBeforeAfterPageBreak(openXmlElement);
      value.SwapBordersFacingPages = GetSwapBordersFacingPages(openXmlElement);
      value.ConvertMailMergeEscape = GetConvertMailMergeEscape(openXmlElement);
      value.TruncateFontHeightsLikeWordPerfect = GetTruncateFontHeightsLikeWordPerfect(openXmlElement);
      value.MacWordSmallCaps = GetMacWordSmallCaps(openXmlElement);
      value.UsePrinterMetrics = GetUsePrinterMetrics(openXmlElement);
      value.DoNotSuppressParagraphBorders = GetDoNotSuppressParagraphBorders(openXmlElement);
      value.WrapTrailSpaces = GetWrapTrailSpaces(openXmlElement);
      value.FootnoteLayoutLikeWord8 = GetFootnoteLayoutLikeWord8(openXmlElement);
      value.ShapeLayoutLikeWord8 = GetShapeLayoutLikeWord8(openXmlElement);
      value.AlignTablesRowByRow = GetAlignTablesRowByRow(openXmlElement);
      value.ForgetLastTabAlignment = GetForgetLastTabAlignment(openXmlElement);
      value.AdjustLineHeightInTable = GetAdjustLineHeightInTable(openXmlElement);
      value.AutoSpaceLikeWord95 = GetAutoSpaceLikeWord95(openXmlElement);
      value.NoSpaceRaiseLower = GetNoSpaceRaiseLower(openXmlElement);
      value.DoNotUseHTMLParagraphAutoSpacing = GetDoNotUseHTMLParagraphAutoSpacing(openXmlElement);
      value.LayoutRawTableWidth = GetLayoutRawTableWidth(openXmlElement);
      value.LayoutTableRowsApart = GetLayoutTableRowsApart(openXmlElement);
      value.UseWord97LineBreakRules = GetUseWord97LineBreakRules(openXmlElement);
      value.DoNotBreakWrappedTables = GetDoNotBreakWrappedTables(openXmlElement);
      value.DoNotSnapToGridInCell = GetDoNotSnapToGridInCell(openXmlElement);
      value.SelectFieldWithFirstOrLastChar = GetSelectFieldWithFirstOrLastChar(openXmlElement);
      value.ApplyBreakingRules = GetApplyBreakingRules(openXmlElement);
      value.DoNotWrapTextWithPunctuation = GetDoNotWrapTextWithPunctuation(openXmlElement);
      value.DoNotUseEastAsianBreakRules = GetDoNotUseEastAsianBreakRules(openXmlElement);
      value.UseWord2002TableStyleRules = GetUseWord2002TableStyleRules(openXmlElement);
      value.GrowAutofit = GetGrowAutofit(openXmlElement);
      value.UseFarEastLayout = GetUseFarEastLayout(openXmlElement);
      value.UseNormalStyleForList = GetUseNormalStyleForList(openXmlElement);
      value.DoNotUseIndentAsNumberingTabStop = GetDoNotUseIndentAsNumberingTabStop(openXmlElement);
      value.UseAltKinsokuLineBreakRules = GetUseAltKinsokuLineBreakRules(openXmlElement);
      value.AllowSpaceOfSameStyleInTable = GetAllowSpaceOfSameStyleInTable(openXmlElement);
      value.DoNotSuppressIndentation = GetDoNotSuppressIndentation(openXmlElement);
      value.DoNotAutofitConstrainedTables = GetDoNotAutofitConstrainedTables(openXmlElement);
      value.AutofitToFirstFixedWidthCell = GetAutofitToFirstFixedWidthCell(openXmlElement);
      value.UnderlineTabInNumberingList = GetUnderlineTabInNumberingList(openXmlElement);
      value.DisplayHangulFixedWidth = GetDisplayHangulFixedWidth(openXmlElement);
      value.SplitPageBreakAndParagraphMark = GetSplitPageBreakAndParagraphMark(openXmlElement);
      value.DoNotVerticallyAlignCellWithShape = GetDoNotVerticallyAlignCellWithShape(openXmlElement);
      value.DoNotBreakConstrainedForcedTable = GetDoNotBreakConstrainedForcedTable(openXmlElement);
      value.DoNotVerticallyAlignInTextBox = GetDoNotVerticallyAlignInTextBox(openXmlElement);
      value.UseAnsiKerningPairs = GetUseAnsiKerningPairs(openXmlElement);
      value.CachedColumnBalance = GetCachedColumnBalance(openXmlElement);
      value.CompatibilitySettings = GetCompatibilitySettings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Compatibility? openXmlElement, DMW.Compatibility? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseSingleBorderForContiguousCells(openXmlElement, value.UseSingleBorderForContiguousCells, diffs, objName))
        ok = false;
      if (!CmpWordPerfectJustification(openXmlElement, value.WordPerfectJustification, diffs, objName))
        ok = false;
      if (!CmpNoTabHangIndent(openXmlElement, value.NoTabHangIndent, diffs, objName))
        ok = false;
      if (!CmpNoLeading(openXmlElement, value.NoLeading, diffs, objName))
        ok = false;
      if (!CmpSpaceForUnderline(openXmlElement, value.SpaceForUnderline, diffs, objName))
        ok = false;
      if (!CmpNoColumnBalance(openXmlElement, value.NoColumnBalance, diffs, objName))
        ok = false;
      if (!CmpBalanceSingleByteDoubleByteWidth(openXmlElement, value.BalanceSingleByteDoubleByteWidth, diffs, objName))
        ok = false;
      if (!CmpNoExtraLineSpacing(openXmlElement, value.NoExtraLineSpacing, diffs, objName))
        ok = false;
      if (!CmpDoNotLeaveBackslashAlone(openXmlElement, value.DoNotLeaveBackslashAlone, diffs, objName))
        ok = false;
      if (!CmpUnderlineTrailingSpaces(openXmlElement, value.UnderlineTrailingSpaces, diffs, objName))
        ok = false;
      if (!CmpDoNotExpandShiftReturn(openXmlElement, value.DoNotExpandShiftReturn, diffs, objName))
        ok = false;
      if (!CmpSpacingInWholePoints(openXmlElement, value.SpacingInWholePoints, diffs, objName))
        ok = false;
      if (!CmpLineWrapLikeWord6(openXmlElement, value.LineWrapLikeWord6, diffs, objName))
        ok = false;
      if (!CmpPrintBodyTextBeforeHeader(openXmlElement, value.PrintBodyTextBeforeHeader, diffs, objName))
        ok = false;
      if (!CmpPrintColorBlackWhite(openXmlElement, value.PrintColorBlackWhite, diffs, objName))
        ok = false;
      if (!CmpWordPerfectSpaceWidth(openXmlElement, value.WordPerfectSpaceWidth, diffs, objName))
        ok = false;
      if (!CmpShowBreaksInFrames(openXmlElement, value.ShowBreaksInFrames, diffs, objName))
        ok = false;
      if (!CmpSubFontBySize(openXmlElement, value.SubFontBySize, diffs, objName))
        ok = false;
      if (!CmpSuppressBottomSpacing(openXmlElement, value.SuppressBottomSpacing, diffs, objName))
        ok = false;
      if (!CmpSuppressTopSpacing(openXmlElement, value.SuppressTopSpacing, diffs, objName))
        ok = false;
      if (!CmpSuppressSpacingAtTopOfPage(openXmlElement, value.SuppressSpacingAtTopOfPage, diffs, objName))
        ok = false;
      if (!CmpSuppressTopSpacingWordPerfect(openXmlElement, value.SuppressTopSpacingWordPerfect, diffs, objName))
        ok = false;
      if (!CmpSuppressSpacingBeforeAfterPageBreak(openXmlElement, value.SuppressSpacingBeforeAfterPageBreak, diffs, objName))
        ok = false;
      if (!CmpSwapBordersFacingPages(openXmlElement, value.SwapBordersFacingPages, diffs, objName))
        ok = false;
      if (!CmpConvertMailMergeEscape(openXmlElement, value.ConvertMailMergeEscape, diffs, objName))
        ok = false;
      if (!CmpTruncateFontHeightsLikeWordPerfect(openXmlElement, value.TruncateFontHeightsLikeWordPerfect, diffs, objName))
        ok = false;
      if (!CmpMacWordSmallCaps(openXmlElement, value.MacWordSmallCaps, diffs, objName))
        ok = false;
      if (!CmpUsePrinterMetrics(openXmlElement, value.UsePrinterMetrics, diffs, objName))
        ok = false;
      if (!CmpDoNotSuppressParagraphBorders(openXmlElement, value.DoNotSuppressParagraphBorders, diffs, objName))
        ok = false;
      if (!CmpWrapTrailSpaces(openXmlElement, value.WrapTrailSpaces, diffs, objName))
        ok = false;
      if (!CmpFootnoteLayoutLikeWord8(openXmlElement, value.FootnoteLayoutLikeWord8, diffs, objName))
        ok = false;
      if (!CmpShapeLayoutLikeWord8(openXmlElement, value.ShapeLayoutLikeWord8, diffs, objName))
        ok = false;
      if (!CmpAlignTablesRowByRow(openXmlElement, value.AlignTablesRowByRow, diffs, objName))
        ok = false;
      if (!CmpForgetLastTabAlignment(openXmlElement, value.ForgetLastTabAlignment, diffs, objName))
        ok = false;
      if (!CmpAdjustLineHeightInTable(openXmlElement, value.AdjustLineHeightInTable, diffs, objName))
        ok = false;
      if (!CmpAutoSpaceLikeWord95(openXmlElement, value.AutoSpaceLikeWord95, diffs, objName))
        ok = false;
      if (!CmpNoSpaceRaiseLower(openXmlElement, value.NoSpaceRaiseLower, diffs, objName))
        ok = false;
      if (!CmpDoNotUseHTMLParagraphAutoSpacing(openXmlElement, value.DoNotUseHTMLParagraphAutoSpacing, diffs, objName))
        ok = false;
      if (!CmpLayoutRawTableWidth(openXmlElement, value.LayoutRawTableWidth, diffs, objName))
        ok = false;
      if (!CmpLayoutTableRowsApart(openXmlElement, value.LayoutTableRowsApart, diffs, objName))
        ok = false;
      if (!CmpUseWord97LineBreakRules(openXmlElement, value.UseWord97LineBreakRules, diffs, objName))
        ok = false;
      if (!CmpDoNotBreakWrappedTables(openXmlElement, value.DoNotBreakWrappedTables, diffs, objName))
        ok = false;
      if (!CmpDoNotSnapToGridInCell(openXmlElement, value.DoNotSnapToGridInCell, diffs, objName))
        ok = false;
      if (!CmpSelectFieldWithFirstOrLastChar(openXmlElement, value.SelectFieldWithFirstOrLastChar, diffs, objName))
        ok = false;
      if (!CmpApplyBreakingRules(openXmlElement, value.ApplyBreakingRules, diffs, objName))
        ok = false;
      if (!CmpDoNotWrapTextWithPunctuation(openXmlElement, value.DoNotWrapTextWithPunctuation, diffs, objName))
        ok = false;
      if (!CmpDoNotUseEastAsianBreakRules(openXmlElement, value.DoNotUseEastAsianBreakRules, diffs, objName))
        ok = false;
      if (!CmpUseWord2002TableStyleRules(openXmlElement, value.UseWord2002TableStyleRules, diffs, objName))
        ok = false;
      if (!CmpGrowAutofit(openXmlElement, value.GrowAutofit, diffs, objName))
        ok = false;
      if (!CmpUseFarEastLayout(openXmlElement, value.UseFarEastLayout, diffs, objName))
        ok = false;
      if (!CmpUseNormalStyleForList(openXmlElement, value.UseNormalStyleForList, diffs, objName))
        ok = false;
      if (!CmpDoNotUseIndentAsNumberingTabStop(openXmlElement, value.DoNotUseIndentAsNumberingTabStop, diffs, objName))
        ok = false;
      if (!CmpUseAltKinsokuLineBreakRules(openXmlElement, value.UseAltKinsokuLineBreakRules, diffs, objName))
        ok = false;
      if (!CmpAllowSpaceOfSameStyleInTable(openXmlElement, value.AllowSpaceOfSameStyleInTable, diffs, objName))
        ok = false;
      if (!CmpDoNotSuppressIndentation(openXmlElement, value.DoNotSuppressIndentation, diffs, objName))
        ok = false;
      if (!CmpDoNotAutofitConstrainedTables(openXmlElement, value.DoNotAutofitConstrainedTables, diffs, objName))
        ok = false;
      if (!CmpAutofitToFirstFixedWidthCell(openXmlElement, value.AutofitToFirstFixedWidthCell, diffs, objName))
        ok = false;
      if (!CmpUnderlineTabInNumberingList(openXmlElement, value.UnderlineTabInNumberingList, diffs, objName))
        ok = false;
      if (!CmpDisplayHangulFixedWidth(openXmlElement, value.DisplayHangulFixedWidth, diffs, objName))
        ok = false;
      if (!CmpSplitPageBreakAndParagraphMark(openXmlElement, value.SplitPageBreakAndParagraphMark, diffs, objName))
        ok = false;
      if (!CmpDoNotVerticallyAlignCellWithShape(openXmlElement, value.DoNotVerticallyAlignCellWithShape, diffs, objName))
        ok = false;
      if (!CmpDoNotBreakConstrainedForcedTable(openXmlElement, value.DoNotBreakConstrainedForcedTable, diffs, objName))
        ok = false;
      if (!CmpDoNotVerticallyAlignInTextBox(openXmlElement, value.DoNotVerticallyAlignInTextBox, diffs, objName))
        ok = false;
      if (!CmpUseAnsiKerningPairs(openXmlElement, value.UseAnsiKerningPairs, diffs, objName))
        ok = false;
      if (!CmpCachedColumnBalance(openXmlElement, value.CachedColumnBalance, diffs, objName))
        ok = false;
      if (!CmpCompatibilitySettings(openXmlElement, value.CompatibilitySettings, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Compatibility value)
    where OpenXmlElementType: DXW.Compatibility, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Compatibility openXmlElement, DMW.Compatibility value)
  {
    SetUseSingleBorderForContiguousCells(openXmlElement, value?.UseSingleBorderForContiguousCells);
    SetWordPerfectJustification(openXmlElement, value?.WordPerfectJustification);
    SetNoTabHangIndent(openXmlElement, value?.NoTabHangIndent);
    SetNoLeading(openXmlElement, value?.NoLeading);
    SetSpaceForUnderline(openXmlElement, value?.SpaceForUnderline);
    SetNoColumnBalance(openXmlElement, value?.NoColumnBalance);
    SetBalanceSingleByteDoubleByteWidth(openXmlElement, value?.BalanceSingleByteDoubleByteWidth);
    SetNoExtraLineSpacing(openXmlElement, value?.NoExtraLineSpacing);
    SetDoNotLeaveBackslashAlone(openXmlElement, value?.DoNotLeaveBackslashAlone);
    SetUnderlineTrailingSpaces(openXmlElement, value?.UnderlineTrailingSpaces);
    SetDoNotExpandShiftReturn(openXmlElement, value?.DoNotExpandShiftReturn);
    SetSpacingInWholePoints(openXmlElement, value?.SpacingInWholePoints);
    SetLineWrapLikeWord6(openXmlElement, value?.LineWrapLikeWord6);
    SetPrintBodyTextBeforeHeader(openXmlElement, value?.PrintBodyTextBeforeHeader);
    SetPrintColorBlackWhite(openXmlElement, value?.PrintColorBlackWhite);
    SetWordPerfectSpaceWidth(openXmlElement, value?.WordPerfectSpaceWidth);
    SetShowBreaksInFrames(openXmlElement, value?.ShowBreaksInFrames);
    SetSubFontBySize(openXmlElement, value?.SubFontBySize);
    SetSuppressBottomSpacing(openXmlElement, value?.SuppressBottomSpacing);
    SetSuppressTopSpacing(openXmlElement, value?.SuppressTopSpacing);
    SetSuppressSpacingAtTopOfPage(openXmlElement, value?.SuppressSpacingAtTopOfPage);
    SetSuppressTopSpacingWordPerfect(openXmlElement, value?.SuppressTopSpacingWordPerfect);
    SetSuppressSpacingBeforeAfterPageBreak(openXmlElement, value?.SuppressSpacingBeforeAfterPageBreak);
    SetSwapBordersFacingPages(openXmlElement, value?.SwapBordersFacingPages);
    SetConvertMailMergeEscape(openXmlElement, value?.ConvertMailMergeEscape);
    SetTruncateFontHeightsLikeWordPerfect(openXmlElement, value?.TruncateFontHeightsLikeWordPerfect);
    SetMacWordSmallCaps(openXmlElement, value?.MacWordSmallCaps);
    SetUsePrinterMetrics(openXmlElement, value?.UsePrinterMetrics);
    SetDoNotSuppressParagraphBorders(openXmlElement, value?.DoNotSuppressParagraphBorders);
    SetWrapTrailSpaces(openXmlElement, value?.WrapTrailSpaces);
    SetFootnoteLayoutLikeWord8(openXmlElement, value?.FootnoteLayoutLikeWord8);
    SetShapeLayoutLikeWord8(openXmlElement, value?.ShapeLayoutLikeWord8);
    SetAlignTablesRowByRow(openXmlElement, value?.AlignTablesRowByRow);
    SetForgetLastTabAlignment(openXmlElement, value?.ForgetLastTabAlignment);
    SetAdjustLineHeightInTable(openXmlElement, value?.AdjustLineHeightInTable);
    SetAutoSpaceLikeWord95(openXmlElement, value?.AutoSpaceLikeWord95);
    SetNoSpaceRaiseLower(openXmlElement, value?.NoSpaceRaiseLower);
    SetDoNotUseHTMLParagraphAutoSpacing(openXmlElement, value?.DoNotUseHTMLParagraphAutoSpacing);
    SetLayoutRawTableWidth(openXmlElement, value?.LayoutRawTableWidth);
    SetLayoutTableRowsApart(openXmlElement, value?.LayoutTableRowsApart);
    SetUseWord97LineBreakRules(openXmlElement, value?.UseWord97LineBreakRules);
    SetDoNotBreakWrappedTables(openXmlElement, value?.DoNotBreakWrappedTables);
    SetDoNotSnapToGridInCell(openXmlElement, value?.DoNotSnapToGridInCell);
    SetSelectFieldWithFirstOrLastChar(openXmlElement, value?.SelectFieldWithFirstOrLastChar);
    SetApplyBreakingRules(openXmlElement, value?.ApplyBreakingRules);
    SetDoNotWrapTextWithPunctuation(openXmlElement, value?.DoNotWrapTextWithPunctuation);
    SetDoNotUseEastAsianBreakRules(openXmlElement, value?.DoNotUseEastAsianBreakRules);
    SetUseWord2002TableStyleRules(openXmlElement, value?.UseWord2002TableStyleRules);
    SetGrowAutofit(openXmlElement, value?.GrowAutofit);
    SetUseFarEastLayout(openXmlElement, value?.UseFarEastLayout);
    SetUseNormalStyleForList(openXmlElement, value?.UseNormalStyleForList);
    SetDoNotUseIndentAsNumberingTabStop(openXmlElement, value?.DoNotUseIndentAsNumberingTabStop);
    SetUseAltKinsokuLineBreakRules(openXmlElement, value?.UseAltKinsokuLineBreakRules);
    SetAllowSpaceOfSameStyleInTable(openXmlElement, value?.AllowSpaceOfSameStyleInTable);
    SetDoNotSuppressIndentation(openXmlElement, value?.DoNotSuppressIndentation);
    SetDoNotAutofitConstrainedTables(openXmlElement, value?.DoNotAutofitConstrainedTables);
    SetAutofitToFirstFixedWidthCell(openXmlElement, value?.AutofitToFirstFixedWidthCell);
    SetUnderlineTabInNumberingList(openXmlElement, value?.UnderlineTabInNumberingList);
    SetDisplayHangulFixedWidth(openXmlElement, value?.DisplayHangulFixedWidth);
    SetSplitPageBreakAndParagraphMark(openXmlElement, value?.SplitPageBreakAndParagraphMark);
    SetDoNotVerticallyAlignCellWithShape(openXmlElement, value?.DoNotVerticallyAlignCellWithShape);
    SetDoNotBreakConstrainedForcedTable(openXmlElement, value?.DoNotBreakConstrainedForcedTable);
    SetDoNotVerticallyAlignInTextBox(openXmlElement, value?.DoNotVerticallyAlignInTextBox);
    SetUseAnsiKerningPairs(openXmlElement, value?.UseAnsiKerningPairs);
    SetCachedColumnBalance(openXmlElement, value?.CachedColumnBalance);
    SetCompatibilitySettings(openXmlElement, value?.CompatibilitySettings);
  }
}
