using DocumentFormat.OpenXml.Wordprocessing;
using CompatibilitySetting = DocumentModel.Wordprocessing.CompatibilitySetting;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Compatibility Settings.
/// </summary>
public static class CompatibilityConverter
{
  /// <summary>
  ///   Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public static Boolean? GetUseSingleBorderForContiguousCells(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseSingleBorderForContiguousCells>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseSingleBorderForContiguousCells(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseSingleBorderForContiguousCells>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseSingleBorderForContiguousCells();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public static Boolean? GetWordPerfectJustification(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WordPerfectJustification>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWordPerfectJustification(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WordPerfectJustification>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WordPerfectJustification();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public static Boolean? GetNoTabHangIndent(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoTabHangIndent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoTabHangIndent(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoTabHangIndent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoTabHangIndent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Add Leading Between Lines of Text.
  /// </summary>
  public static Boolean? GetNoLeading(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoLeading>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoLeading(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoLeading>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoLeading();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public static Boolean? GetSpaceForUnderline(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpaceForUnderline>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSpaceForUnderline(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SpaceForUnderline>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SpaceForUnderline();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Balance Text Columns within a Section.
  /// </summary>
  public static Boolean? GetNoColumnBalance(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoColumnBalance>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoColumnBalance(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoColumnBalance>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoColumnBalance();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Balance Single Byte and Double Byte Characters.
  /// </summary>
  public static Boolean? GetBalanceSingleByteDoubleByteWidth(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BalanceSingleByteDoubleByteWidth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBalanceSingleByteDoubleByteWidth(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BalanceSingleByteDoubleByteWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BalanceSingleByteDoubleByteWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public static Boolean? GetNoExtraLineSpacing(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoExtraLineSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoExtraLineSpacing(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoExtraLineSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoExtraLineSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public static Boolean? GetDoNotLeaveBackslashAlone(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotLeaveBackslashAlone>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotLeaveBackslashAlone(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotLeaveBackslashAlone>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotLeaveBackslashAlone();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Underline All Trailing Spaces.
  /// </summary>
  public static Boolean? GetUnderlineTrailingSpaces(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineTrailingSpaces>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineTrailingSpaces(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UnderlineTrailingSpaces>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UnderlineTrailingSpaces();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public static Boolean? GetDoNotExpandShiftReturn(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotExpandShiftReturn>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotExpandShiftReturn(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotExpandShiftReturn>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotExpandShiftReturn();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Only Expand/Condense Text By Whole Points.
  /// </summary>
  public static Boolean? GetSpacingInWholePoints(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpacingInWholePoints>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSpacingInWholePoints(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SpacingInWholePoints>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SpacingInWholePoints();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public static Boolean? GetLineWrapLikeWord6(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineWrapLikeWord6>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineWrapLikeWord6(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineWrapLikeWord6>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineWrapLikeWord6();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Print Body Text before Header/Footer Contents.
  /// </summary>
  public static Boolean? GetPrintBodyTextBeforeHeader(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintBodyTextBeforeHeader>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintBodyTextBeforeHeader(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintBodyTextBeforeHeader>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintBodyTextBeforeHeader();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Print Colors as Black And White without Dithering.
  /// </summary>
  public static Boolean? GetPrintColorBlackWhite(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintColorBlackWhite>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintColorBlackWhite(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintColorBlackWhite>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintColorBlackWhite();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Space width.
  /// </summary>
  public static Boolean? GetWordPerfectSpaceWidth(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WordPerfectSpaceWidth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWordPerfectSpaceWidth(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WordPerfectSpaceWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WordPerfectSpaceWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Display Page/Column Breaks Present in Frames.
  /// </summary>
  public static Boolean? GetShowBreaksInFrames(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowBreaksInFrames>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowBreaksInFrames(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowBreaksInFrames>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowBreaksInFrames();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public static Boolean? GetSubFontBySize(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SubFontBySize>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSubFontBySize(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SubFontBySize>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SubFontBySize();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public static Boolean? GetSuppressBottomSpacing(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressBottomSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressBottomSpacing(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressBottomSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressBottomSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public static Boolean? GetSuppressTopSpacing(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressTopSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressTopSpacing(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressTopSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressTopSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public static Boolean? GetSuppressSpacingAtTopOfPage(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressSpacingAtTopOfPage>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressSpacingAtTopOfPage(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressSpacingAtTopOfPage>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressSpacingAtTopOfPage();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public static Boolean? GetSuppressTopSpacingWordPerfect(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressTopSpacingWordPerfect>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressTopSpacingWordPerfect(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressTopSpacingWordPerfect>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressTopSpacingWordPerfect();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public static Boolean? GetSuppressSpacingBeforeAfterPageBreak(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SuppressSpacingBeforeAfterPageBreak>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSuppressSpacingBeforeAfterPageBreak(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SuppressSpacingBeforeAfterPageBreak>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SuppressSpacingBeforeAfterPageBreak();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public static Boolean? GetSwapBordersFacingPages(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SwapBordersFacingPages>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSwapBordersFacingPages(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SwapBordersFacingPages>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SwapBordersFacingPages();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public static Boolean? GetConvertMailMergeEscape(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConvertMailMergeEscape>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetConvertMailMergeEscape(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ConvertMailMergeEscape>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ConvertMailMergeEscape();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public static Boolean? GetTruncateFontHeightsLikeWordPerfect(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TruncateFontHeightsLikeWordPerfect>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTruncateFontHeightsLikeWordPerfect(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TruncateFontHeightsLikeWordPerfect>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TruncateFontHeightsLikeWordPerfect();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public static Boolean? GetMacWordSmallCaps(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MacWordSmallCaps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMacWordSmallCaps(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MacWordSmallCaps>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MacWordSmallCaps();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Printer Metrics To Display Documents.
  /// </summary>
  public static Boolean? GetUsePrinterMetrics(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UsePrinterMetrics>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUsePrinterMetrics(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UsePrinterMetrics>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UsePrinterMetrics();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public static Boolean? GetDoNotSuppressParagraphBorders(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotSuppressParagraphBorders>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotSuppressParagraphBorders(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotSuppressParagraphBorders>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotSuppressParagraphBorders();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Line Wrap Trailing Spaces.
  /// </summary>
  public static Boolean? GetWrapTrailSpaces(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WrapTrailSpaces>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWrapTrailSpaces(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WrapTrailSpaces>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WrapTrailSpaces();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public static Boolean? GetFootnoteLayoutLikeWord8(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnoteLayoutLikeWord8>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFootnoteLayoutLikeWord8(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<FootnoteLayoutLikeWord8>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new FootnoteLayoutLikeWord8();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public static Boolean? GetShapeLayoutLikeWord8(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeLayoutLikeWord8>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShapeLayoutLikeWord8(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShapeLayoutLikeWord8>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShapeLayoutLikeWord8();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Align Table Rows Independently.
  /// </summary>
  public static Boolean? GetAlignTablesRowByRow(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlignTablesRowByRow>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlignTablesRowByRow(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlignTablesRowByRow>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlignTablesRowByRow();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public static Boolean? GetForgetLastTabAlignment(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ForgetLastTabAlignment>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetForgetLastTabAlignment(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ForgetLastTabAlignment>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ForgetLastTabAlignment();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public static Boolean? GetAdjustLineHeightInTable(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AdjustLineHeightInTable>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAdjustLineHeightInTable(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AdjustLineHeightInTable>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AdjustLineHeightInTable();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public static Boolean? GetAutoSpaceLikeWord95(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoSpaceLikeWord95>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoSpaceLikeWord95(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoSpaceLikeWord95>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoSpaceLikeWord95();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public static Boolean? GetNoSpaceRaiseLower(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoSpaceRaiseLower>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoSpaceRaiseLower(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoSpaceRaiseLower>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoSpaceRaiseLower();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public static Boolean? GetDoNotUseHTMLParagraphAutoSpacing(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotUseHTMLParagraphAutoSpacing>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotUseHTMLParagraphAutoSpacing(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotUseHTMLParagraphAutoSpacing>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotUseHTMLParagraphAutoSpacing();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public static Boolean? GetLayoutRawTableWidth(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LayoutRawTableWidth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLayoutRawTableWidth(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LayoutRawTableWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LayoutRawTableWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  public static Boolean? GetLayoutTableRowsApart(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LayoutTableRowsApart>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLayoutTableRowsApart(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LayoutTableRowsApart>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LayoutTableRowsApart();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public static Boolean? GetUseWord97LineBreakRules(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseWord97LineBreakRules>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseWord97LineBreakRules(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseWord97LineBreakRules>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseWord97LineBreakRules();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public static Boolean? GetDoNotBreakWrappedTables(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotBreakWrappedTables>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotBreakWrappedTables(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotBreakWrappedTables>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotBreakWrappedTables();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public static Boolean? GetDoNotSnapToGridInCell(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotSnapToGridInCell>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotSnapToGridInCell(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotSnapToGridInCell>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotSnapToGridInCell();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Select Field When First or Last Character Is Selected.
  /// </summary>
  public static Boolean? GetSelectFieldWithFirstOrLastChar(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SelectFieldWithFirstOrLastChar>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSelectFieldWithFirstOrLastChar(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SelectFieldWithFirstOrLastChar>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SelectFieldWithFirstOrLastChar();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public static Boolean? GetApplyBreakingRules(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ApplyBreakingRules>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetApplyBreakingRules(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ApplyBreakingRules>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ApplyBreakingRules();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public static Boolean? GetDoNotWrapTextWithPunctuation(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotWrapTextWithPunctuation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotWrapTextWithPunctuation(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotWrapTextWithPunctuation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotWrapTextWithPunctuation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public static Boolean? GetDoNotUseEastAsianBreakRules(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotUseEastAsianBreakRules>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotUseEastAsianBreakRules(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotUseEastAsianBreakRules>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotUseEastAsianBreakRules();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emulate Word 2002 Table Style Rules.
  /// </summary>
  public static Boolean? GetUseWord2002TableStyleRules(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseWord2002TableStyleRules>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseWord2002TableStyleRules(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseWord2002TableStyleRules>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseWord2002TableStyleRules();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public static Boolean? GetGrowAutofit(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GrowAutofit>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGrowAutofit(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<GrowAutofit>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new GrowAutofit();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public static Boolean? GetUseFarEastLayout(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseFarEastLayout>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseFarEastLayout(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseFarEastLayout>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseFarEastLayout();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public static Boolean? GetUseNormalStyleForList(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseNormalStyleForList>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseNormalStyleForList(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseNormalStyleForList>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseNormalStyleForList();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public static Boolean? GetDoNotUseIndentAsNumberingTabStop(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotUseIndentAsNumberingTabStop>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotUseIndentAsNumberingTabStop(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotUseIndentAsNumberingTabStop>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotUseIndentAsNumberingTabStop();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public static Boolean? GetUseAltKinsokuLineBreakRules(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseAltKinsokuLineBreakRules>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseAltKinsokuLineBreakRules(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseAltKinsokuLineBreakRules>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseAltKinsokuLineBreakRules();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public static Boolean? GetAllowSpaceOfSameStyleInTable(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AllowSpaceOfSameStyleInTable>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAllowSpaceOfSameStyleInTable(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AllowSpaceOfSameStyleInTable>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AllowSpaceOfSameStyleInTable();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public static Boolean? GetDoNotSuppressIndentation(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotSuppressIndentation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotSuppressIndentation(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotSuppressIndentation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotSuppressIndentation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public static Boolean? GetDoNotAutofitConstrainedTables(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotAutofitConstrainedTables>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotAutofitConstrainedTables(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotAutofitConstrainedTables>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotAutofitConstrainedTables();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public static Boolean? GetAutofitToFirstFixedWidthCell(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutofitToFirstFixedWidthCell>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutofitToFirstFixedWidthCell(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutofitToFirstFixedWidthCell>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutofitToFirstFixedWidthCell();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  public static Boolean? GetUnderlineTabInNumberingList(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineTabInNumberingList>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineTabInNumberingList(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UnderlineTabInNumberingList>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UnderlineTabInNumberingList();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public static Boolean? GetDisplayHangulFixedWidth(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayHangulFixedWidth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDisplayHangulFixedWidth(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DisplayHangulFixedWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DisplayHangulFixedWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public static Boolean? GetSplitPageBreakAndParagraphMark(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SplitPageBreakAndParagraphMark>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSplitPageBreakAndParagraphMark(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SplitPageBreakAndParagraphMark>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SplitPageBreakAndParagraphMark();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public static Boolean? GetDoNotVerticallyAlignCellWithShape(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotVerticallyAlignCellWithShape>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotVerticallyAlignCellWithShape(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotVerticallyAlignCellWithShape>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotVerticallyAlignCellWithShape();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public static Boolean? GetDoNotBreakConstrainedForcedTable(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotBreakConstrainedForcedTable>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotBreakConstrainedForcedTable(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotBreakConstrainedForcedTable>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotBreakConstrainedForcedTable();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public static Boolean? GetDoNotVerticallyAlignInTextBox(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotVerticallyAlignInTextBox>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotVerticallyAlignInTextBox(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotVerticallyAlignInTextBox>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotVerticallyAlignInTextBox();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public static Boolean? GetUseAnsiKerningPairs(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseAnsiKerningPairs>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseAnsiKerningPairs(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseAnsiKerningPairs>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseAnsiKerningPairs();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public static Boolean? GetCachedColumnBalance(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CachedColumnBalance>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCachedColumnBalance(Compatibility? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<CachedColumnBalance>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new CachedColumnBalance();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<CompatibilitySetting>? GetCompatibilitySettings(Compatibility? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CompatibilitySetting>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>())
      {
        var newItem = CompatibilitySettingConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCompatibilitySettings(Compatibility? openXmlElement, Collection<CompatibilitySetting>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CompatibilitySettingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Compatibility? CreateModelElement(Compatibility? openXmlElement)
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
    where OpenXmlElementType : Compatibility, new()
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