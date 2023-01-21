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
    var itemElement = openXmlElement.GetFirstChild<DXW.UseSingleBorderForContiguousCells>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseSingleBorderForContiguousCells(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseSingleBorderForContiguousCells>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseSingleBorderForContiguousCells();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  private static Boolean? GetWordPerfectJustification(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WordPerfectJustification>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetWordPerfectJustification(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WordPerfectJustification>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WordPerfectJustification();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  private static Boolean? GetNoTabHangIndent(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoTabHangIndent>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoTabHangIndent(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoTabHangIndent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoTabHangIndent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  private static Boolean? GetNoLeading(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoLeading>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoLeading(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoLeading>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoLeading();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  private static Boolean? GetSpaceForUnderline(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SpaceForUnderline>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSpaceForUnderline(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SpaceForUnderline>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SpaceForUnderline();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  private static Boolean? GetNoColumnBalance(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoColumnBalance>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoColumnBalance(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoColumnBalance();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  private static Boolean? GetBalanceSingleByteDoubleByteWidth(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBalanceSingleByteDoubleByteWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BalanceSingleByteDoubleByteWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  private static Boolean? GetNoExtraLineSpacing(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoExtraLineSpacing>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoExtraLineSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoExtraLineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoExtraLineSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  private static Boolean? GetDoNotLeaveBackslashAlone(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotLeaveBackslashAlone>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotLeaveBackslashAlone(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotLeaveBackslashAlone>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotLeaveBackslashAlone();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  private static Boolean? GetUnderlineTrailingSpaces(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnderlineTrailingSpaces>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUnderlineTrailingSpaces(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UnderlineTrailingSpaces>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UnderlineTrailingSpaces();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  private static Boolean? GetDoNotExpandShiftReturn(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotExpandShiftReturn>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotExpandShiftReturn(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotExpandShiftReturn>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotExpandShiftReturn();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  private static Boolean? GetSpacingInWholePoints(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SpacingInWholePoints>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSpacingInWholePoints(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SpacingInWholePoints>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SpacingInWholePoints();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  private static Boolean? GetLineWrapLikeWord6(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LineWrapLikeWord6>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetLineWrapLikeWord6(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LineWrapLikeWord6>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LineWrapLikeWord6();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  private static Boolean? GetPrintBodyTextBeforeHeader(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintBodyTextBeforeHeader>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetPrintBodyTextBeforeHeader(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintBodyTextBeforeHeader>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintBodyTextBeforeHeader();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  private static Boolean? GetPrintColorBlackWhite(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintColorBlackWhite>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetPrintColorBlackWhite(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintColorBlackWhite>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintColorBlackWhite();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space width.
  /// </summary>
  private static Boolean? GetWordPerfectSpaceWidth(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WordPerfectSpaceWidth>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetWordPerfectSpaceWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WordPerfectSpaceWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WordPerfectSpaceWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  private static Boolean? GetShowBreaksInFrames(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ShowBreaksInFrames>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetShowBreaksInFrames(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ShowBreaksInFrames>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ShowBreaksInFrames();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  private static Boolean? GetSubFontBySize(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SubFontBySize>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSubFontBySize(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SubFontBySize>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SubFontBySize();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  private static Boolean? GetSuppressBottomSpacing(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SuppressBottomSpacing>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSuppressBottomSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressBottomSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressBottomSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressTopSpacing(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SuppressTopSpacing>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSuppressTopSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressTopSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressTopSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressSpacingAtTopOfPage(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSuppressSpacingAtTopOfPage(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressSpacingAtTopOfPage();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  private static Boolean? GetSuppressTopSpacingWordPerfect(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSuppressTopSpacingWordPerfect(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressTopSpacingWordPerfect();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  private static Boolean? GetSuppressSpacingBeforeAfterPageBreak(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSuppressSpacingBeforeAfterPageBreak(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressSpacingBeforeAfterPageBreak();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  private static Boolean? GetSwapBordersFacingPages(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SwapBordersFacingPages>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSwapBordersFacingPages(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SwapBordersFacingPages>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SwapBordersFacingPages();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  private static Boolean? GetConvertMailMergeEscape(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConvertMailMergeEscape>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetConvertMailMergeEscape(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ConvertMailMergeEscape>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ConvertMailMergeEscape();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  private static Boolean? GetTruncateFontHeightsLikeWordPerfect(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetTruncateFontHeightsLikeWordPerfect(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TruncateFontHeightsLikeWordPerfect();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  private static Boolean? GetMacWordSmallCaps(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MacWordSmallCaps>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetMacWordSmallCaps(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MacWordSmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MacWordSmallCaps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  private static Boolean? GetUsePrinterMetrics(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UsePrinterMetrics>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUsePrinterMetrics(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UsePrinterMetrics>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UsePrinterMetrics();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  private static Boolean? GetDoNotSuppressParagraphBorders(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressParagraphBorders>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotSuppressParagraphBorders(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotSuppressParagraphBorders();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  private static Boolean? GetWrapTrailSpaces(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WrapTrailSpaces>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetWrapTrailSpaces(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WrapTrailSpaces>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WrapTrailSpaces();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  private static Boolean? GetFootnoteLayoutLikeWord8(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteLayoutLikeWord8>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetFootnoteLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.FootnoteLayoutLikeWord8();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  private static Boolean? GetShapeLayoutLikeWord8(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ShapeLayoutLikeWord8>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetShapeLayoutLikeWord8(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ShapeLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ShapeLayoutLikeWord8();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  private static Boolean? GetAlignTablesRowByRow(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AlignTablesRowByRow>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAlignTablesRowByRow(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AlignTablesRowByRow>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AlignTablesRowByRow();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  private static Boolean? GetForgetLastTabAlignment(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ForgetLastTabAlignment>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetForgetLastTabAlignment(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ForgetLastTabAlignment>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ForgetLastTabAlignment();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  private static Boolean? GetAdjustLineHeightInTable(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AdjustLineHeightInTable>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAdjustLineHeightInTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AdjustLineHeightInTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AdjustLineHeightInTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  private static Boolean? GetAutoSpaceLikeWord95(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceLikeWord95>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAutoSpaceLikeWord95(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceLikeWord95>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoSpaceLikeWord95();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  private static Boolean? GetNoSpaceRaiseLower(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoSpaceRaiseLower>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoSpaceRaiseLower(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoSpaceRaiseLower>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoSpaceRaiseLower();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  private static Boolean? GetDoNotUseHTMLParagraphAutoSpacing(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotUseHTMLParagraphAutoSpacing(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotUseHTMLParagraphAutoSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  private static Boolean? GetLayoutRawTableWidth(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LayoutRawTableWidth>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetLayoutRawTableWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LayoutRawTableWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LayoutRawTableWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  private static Boolean? GetLayoutTableRowsApart(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LayoutTableRowsApart>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetLayoutTableRowsApart(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LayoutTableRowsApart>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LayoutTableRowsApart();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  private static Boolean? GetUseWord97LineBreakRules(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseWord97LineBreakRules>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseWord97LineBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseWord97LineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseWord97LineBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  private static Boolean? GetDoNotBreakWrappedTables(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotBreakWrappedTables>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotBreakWrappedTables(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotBreakWrappedTables>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotBreakWrappedTables();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  private static Boolean? GetDoNotSnapToGridInCell(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSnapToGridInCell>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotSnapToGridInCell(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSnapToGridInCell>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotSnapToGridInCell();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  private static Boolean? GetSelectFieldWithFirstOrLastChar(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSelectFieldWithFirstOrLastChar(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SelectFieldWithFirstOrLastChar();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  private static Boolean? GetApplyBreakingRules(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ApplyBreakingRules>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetApplyBreakingRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ApplyBreakingRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ApplyBreakingRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  private static Boolean? GetDoNotWrapTextWithPunctuation(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotWrapTextWithPunctuation(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotWrapTextWithPunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  private static Boolean? GetDoNotUseEastAsianBreakRules(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotUseEastAsianBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotUseEastAsianBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  private static Boolean? GetUseWord2002TableStyleRules(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseWord2002TableStyleRules>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseWord2002TableStyleRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseWord2002TableStyleRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseWord2002TableStyleRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  private static Boolean? GetGrowAutofit(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.GrowAutofit>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetGrowAutofit(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.GrowAutofit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.GrowAutofit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  private static Boolean? GetUseFarEastLayout(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseFarEastLayout>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseFarEastLayout(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseFarEastLayout>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseFarEastLayout();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  private static Boolean? GetUseNormalStyleForList(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseNormalStyleForList>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseNormalStyleForList(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseNormalStyleForList>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseNormalStyleForList();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  private static Boolean? GetDoNotUseIndentAsNumberingTabStop(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotUseIndentAsNumberingTabStop(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotUseIndentAsNumberingTabStop();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  private static Boolean? GetUseAltKinsokuLineBreakRules(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseAltKinsokuLineBreakRules(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseAltKinsokuLineBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  private static Boolean? GetAllowSpaceOfSameStyleInTable(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAllowSpaceOfSameStyleInTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AllowSpaceOfSameStyleInTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  private static Boolean? GetDoNotSuppressIndentation(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressIndentation>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotSuppressIndentation(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressIndentation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotSuppressIndentation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  private static Boolean? GetDoNotAutofitConstrainedTables(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotAutofitConstrainedTables>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotAutofitConstrainedTables(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotAutofitConstrainedTables>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotAutofitConstrainedTables();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  private static Boolean? GetAutofitToFirstFixedWidthCell(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAutofitToFirstFixedWidthCell(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutofitToFirstFixedWidthCell();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  private static Boolean? GetUnderlineTabInNumberingList(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnderlineTabInNumberingList>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUnderlineTabInNumberingList(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UnderlineTabInNumberingList>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UnderlineTabInNumberingList();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  private static Boolean? GetDisplayHangulFixedWidth(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DisplayHangulFixedWidth>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDisplayHangulFixedWidth(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DisplayHangulFixedWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DisplayHangulFixedWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  private static Boolean? GetSplitPageBreakAndParagraphMark(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSplitPageBreakAndParagraphMark(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SplitPageBreakAndParagraphMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignCellWithShape(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotVerticallyAlignCellWithShape(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotVerticallyAlignCellWithShape();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  private static Boolean? GetDoNotBreakConstrainedForcedTable(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotBreakConstrainedForcedTable(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotBreakConstrainedForcedTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignInTextBox(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotVerticallyAlignInTextBox(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotVerticallyAlignInTextBox();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  private static Boolean? GetUseAnsiKerningPairs(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UseAnsiKerningPairs>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetUseAnsiKerningPairs(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseAnsiKerningPairs>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseAnsiKerningPairs();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  private static Boolean? GetCachedColumnBalance(DXW.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CachedColumnBalance>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetCachedColumnBalance(DXW.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.CachedColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.CachedColumnBalance();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.CompatibilitySetting> GetCompatibilitySettings(DXW.Compatibility openXmlElement)
  {
    var collection = new Collection<DMW.CompatibilitySetting>();
    foreach (var item in openXmlElement.Elements<DXW.CompatibilitySetting>())
    {
      var newItem = DMXW.CompatibilitySettingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCompatibilitySettings(DXW.Compatibility openXmlElement, Collection<DMW.CompatibilitySetting>? value)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Compatibility? value)
    where OpenXmlElementType: DXW.Compatibility, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
