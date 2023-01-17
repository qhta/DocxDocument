namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Compatibility Settings.
/// </summary>
public static class CompatibilityConverter
{
  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  private static Boolean? GetUseSingleBorderForContiguousCells(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells>();
    return itemElement != null;
  }
  
  private static void SetUseSingleBorderForContiguousCells(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  private static Boolean? GetWordPerfectJustification(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification>();
    return itemElement != null;
  }
  
  private static void SetWordPerfectJustification(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  private static Boolean? GetNoTabHangIndent(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent>();
    return itemElement != null;
  }
  
  private static void SetNoTabHangIndent(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  private static Boolean? GetNoLeading(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLeading>();
    return itemElement != null;
  }
  
  private static void SetNoLeading(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLeading>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoLeading();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  private static Boolean? GetSpaceForUnderline(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline>();
    return itemElement != null;
  }
  
  private static void SetSpaceForUnderline(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  private static Boolean? GetNoColumnBalance(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance>();
    return itemElement != null;
  }
  
  private static void SetNoColumnBalance(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  private static Boolean? GetBalanceSingleByteDoubleByteWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth>();
    return itemElement != null;
  }
  
  private static void SetBalanceSingleByteDoubleByteWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  private static Boolean? GetNoExtraLineSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing>();
    return itemElement != null;
  }
  
  private static void SetNoExtraLineSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  private static Boolean? GetDoNotLeaveBackslashAlone(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone>();
    return itemElement != null;
  }
  
  private static void SetDoNotLeaveBackslashAlone(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  private static Boolean? GetUnderlineTrailingSpaces(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces>();
    return itemElement != null;
  }
  
  private static void SetUnderlineTrailingSpaces(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  private static Boolean? GetDoNotExpandShiftReturn(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn>();
    return itemElement != null;
  }
  
  private static void SetDoNotExpandShiftReturn(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  private static Boolean? GetSpacingInWholePoints(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints>();
    return itemElement != null;
  }
  
  private static void SetSpacingInWholePoints(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  private static Boolean? GetLineWrapLikeWord6(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6>();
    return itemElement != null;
  }
  
  private static void SetLineWrapLikeWord6(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  private static Boolean? GetPrintBodyTextBeforeHeader(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader>();
    return itemElement != null;
  }
  
  private static void SetPrintBodyTextBeforeHeader(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  private static Boolean? GetPrintColorBlackWhite(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite>();
    return itemElement != null;
  }
  
  private static void SetPrintColorBlackWhite(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space width.
  /// </summary>
  private static Boolean? GetWordPerfectSpaceWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth>();
    return itemElement != null;
  }
  
  private static void SetWordPerfectSpaceWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  private static Boolean? GetShowBreaksInFrames(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames>();
    return itemElement != null;
  }
  
  private static void SetShowBreaksInFrames(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  private static Boolean? GetSubFontBySize(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SubFontBySize>();
    return itemElement != null;
  }
  
  private static void SetSubFontBySize(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SubFontBySize>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SubFontBySize();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  private static Boolean? GetSuppressBottomSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing>();
    return itemElement != null;
  }
  
  private static void SetSuppressBottomSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressTopSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing>();
    return itemElement != null;
  }
  
  private static void SetSuppressTopSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  private static Boolean? GetSuppressSpacingAtTopOfPage(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage>();
    return itemElement != null;
  }
  
  private static void SetSuppressSpacingAtTopOfPage(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  private static Boolean? GetSuppressTopSpacingWordPerfect(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect>();
    return itemElement != null;
  }
  
  private static void SetSuppressTopSpacingWordPerfect(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  private static Boolean? GetSuppressSpacingBeforeAfterPageBreak(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak>();
    return itemElement != null;
  }
  
  private static void SetSuppressSpacingBeforeAfterPageBreak(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  private static Boolean? GetSwapBordersFacingPages(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages>();
    return itemElement != null;
  }
  
  private static void SetSwapBordersFacingPages(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  private static Boolean? GetConvertMailMergeEscape(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape>();
    return itemElement != null;
  }
  
  private static void SetConvertMailMergeEscape(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  private static Boolean? GetTruncateFontHeightsLikeWordPerfect(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect>();
    return itemElement != null;
  }
  
  private static void SetTruncateFontHeightsLikeWordPerfect(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  private static Boolean? GetMacWordSmallCaps(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps>();
    return itemElement != null;
  }
  
  private static void SetMacWordSmallCaps(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  private static Boolean? GetUsePrinterMetrics(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics>();
    return itemElement != null;
  }
  
  private static void SetUsePrinterMetrics(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  private static Boolean? GetDoNotSuppressParagraphBorders(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders>();
    return itemElement != null;
  }
  
  private static void SetDoNotSuppressParagraphBorders(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  private static Boolean? GetWrapTrailSpaces(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces>();
    return itemElement != null;
  }
  
  private static void SetWrapTrailSpaces(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  private static Boolean? GetFootnoteLayoutLikeWord8(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8>();
    return itemElement != null;
  }
  
  private static void SetFootnoteLayoutLikeWord8(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  private static Boolean? GetShapeLayoutLikeWord8(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8>();
    return itemElement != null;
  }
  
  private static void SetShapeLayoutLikeWord8(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  private static Boolean? GetAlignTablesRowByRow(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow>();
    return itemElement != null;
  }
  
  private static void SetAlignTablesRowByRow(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  private static Boolean? GetForgetLastTabAlignment(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment>();
    return itemElement != null;
  }
  
  private static void SetForgetLastTabAlignment(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  private static Boolean? GetAdjustLineHeightInTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable>();
    return itemElement != null;
  }
  
  private static void SetAdjustLineHeightInTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  private static Boolean? GetAutoSpaceLikeWord95(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95>();
    return itemElement != null;
  }
  
  private static void SetAutoSpaceLikeWord95(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  private static Boolean? GetNoSpaceRaiseLower(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower>();
    return itemElement != null;
  }
  
  private static void SetNoSpaceRaiseLower(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  private static Boolean? GetDoNotUseHTMLParagraphAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing>();
    return itemElement != null;
  }
  
  private static void SetDoNotUseHTMLParagraphAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  private static Boolean? GetLayoutRawTableWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth>();
    return itemElement != null;
  }
  
  private static void SetLayoutRawTableWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  private static Boolean? GetLayoutTableRowsApart(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart>();
    return itemElement != null;
  }
  
  private static void SetLayoutTableRowsApart(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  private static Boolean? GetUseWord97LineBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules>();
    return itemElement != null;
  }
  
  private static void SetUseWord97LineBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  private static Boolean? GetDoNotBreakWrappedTables(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables>();
    return itemElement != null;
  }
  
  private static void SetDoNotBreakWrappedTables(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  private static Boolean? GetDoNotSnapToGridInCell(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell>();
    return itemElement != null;
  }
  
  private static void SetDoNotSnapToGridInCell(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  private static Boolean? GetSelectFieldWithFirstOrLastChar(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar>();
    return itemElement != null;
  }
  
  private static void SetSelectFieldWithFirstOrLastChar(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  private static Boolean? GetApplyBreakingRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules>();
    return itemElement != null;
  }
  
  private static void SetApplyBreakingRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  private static Boolean? GetDoNotWrapTextWithPunctuation(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation>();
    return itemElement != null;
  }
  
  private static void SetDoNotWrapTextWithPunctuation(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  private static Boolean? GetDoNotUseEastAsianBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules>();
    return itemElement != null;
  }
  
  private static void SetDoNotUseEastAsianBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  private static Boolean? GetUseWord2002TableStyleRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules>();
    return itemElement != null;
  }
  
  private static void SetUseWord2002TableStyleRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  private static Boolean? GetGrowAutofit(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GrowAutofit>();
    return itemElement != null;
  }
  
  private static void SetGrowAutofit(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GrowAutofit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.GrowAutofit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  private static Boolean? GetUseFarEastLayout(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout>();
    return itemElement != null;
  }
  
  private static void SetUseFarEastLayout(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  private static Boolean? GetUseNormalStyleForList(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList>();
    return itemElement != null;
  }
  
  private static void SetUseNormalStyleForList(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  private static Boolean? GetDoNotUseIndentAsNumberingTabStop(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop>();
    return itemElement != null;
  }
  
  private static void SetDoNotUseIndentAsNumberingTabStop(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  private static Boolean? GetUseAltKinsokuLineBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules>();
    return itemElement != null;
  }
  
  private static void SetUseAltKinsokuLineBreakRules(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  private static Boolean? GetAllowSpaceOfSameStyleInTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable>();
    return itemElement != null;
  }
  
  private static void SetAllowSpaceOfSameStyleInTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  private static Boolean? GetDoNotSuppressIndentation(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation>();
    return itemElement != null;
  }
  
  private static void SetDoNotSuppressIndentation(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  private static Boolean? GetDoNotAutofitConstrainedTables(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables>();
    return itemElement != null;
  }
  
  private static void SetDoNotAutofitConstrainedTables(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  private static Boolean? GetAutofitToFirstFixedWidthCell(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell>();
    return itemElement != null;
  }
  
  private static void SetAutofitToFirstFixedWidthCell(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  private static Boolean? GetUnderlineTabInNumberingList(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList>();
    return itemElement != null;
  }
  
  private static void SetUnderlineTabInNumberingList(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  private static Boolean? GetDisplayHangulFixedWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth>();
    return itemElement != null;
  }
  
  private static void SetDisplayHangulFixedWidth(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  private static Boolean? GetSplitPageBreakAndParagraphMark(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark>();
    return itemElement != null;
  }
  
  private static void SetSplitPageBreakAndParagraphMark(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignCellWithShape(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape>();
    return itemElement != null;
  }
  
  private static void SetDoNotVerticallyAlignCellWithShape(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  private static Boolean? GetDoNotBreakConstrainedForcedTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable>();
    return itemElement != null;
  }
  
  private static void SetDoNotBreakConstrainedForcedTable(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  private static Boolean? GetDoNotVerticallyAlignInTextBox(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox>();
    return itemElement != null;
  }
  
  private static void SetDoNotVerticallyAlignInTextBox(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  private static Boolean? GetUseAnsiKerningPairs(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs>();
    return itemElement != null;
  }
  
  private static void SetUseAnsiKerningPairs(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  private static Boolean? GetCachedColumnBalance(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance>();
    return itemElement != null;
  }
  
  private static void SetCachedColumnBalance(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CompatibilitySetting> GetCompatibilitySettings(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CompatibilitySetting>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.CompatibilitySettingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCompatibilitySettings(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CompatibilitySetting>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CompatibilitySettingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Compatibility? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Compatibility();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Compatibility? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Compatibility, new()
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
