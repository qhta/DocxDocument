namespace DocumentModel.Wordprocessing;


/// <summary>
///   Compatibility Settings.
/// </summary>
public partial class Compatibility: ModelElement<DXW.Compatibility>
{
  public Compatibility(): base(){ }
  
  public Compatibility(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Compatibility(DXW.Compatibility openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  [DataMember]
  public DMW.UseSingleBorderForContiguousCells? UseSingleBorderForContiguousCells
  {
    get
    {
      return _Element?.GetObject<DMW.UseSingleBorderForContiguousCells,DXW.UseSingleBorderForContiguousCells>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseSingleBorderForContiguousCells,DXW.UseSingleBorderForContiguousCells>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  [DataMember]
  public DMW.WordPerfectJustification? WordPerfectJustification
  {
    get
    {
      return _Element?.GetObject<DMW.WordPerfectJustification,DXW.WordPerfectJustification>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WordPerfectJustification,DXW.WordPerfectJustification>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  [DataMember]
  public DMW.NoTabHangIndent? NoTabHangIndent
  {
    get
    {
      return _Element?.GetObject<DMW.NoTabHangIndent,DXW.NoTabHangIndent>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoTabHangIndent,DXW.NoTabHangIndent>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Add Leading Between Lines of Text.
  /// </summary>
  [DataMember]
  public DMW.NoLeading? NoLeading
  {
    get
    {
      return _Element?.GetObject<DMW.NoLeading,DXW.NoLeading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoLeading,DXW.NoLeading>(value);
    }
  }
  
  
  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  [DataMember]
  public DMW.SpaceForUnderline? SpaceForUnderline
  {
    get
    {
      return _Element?.GetObject<DMW.SpaceForUnderline,DXW.SpaceForUnderline>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SpaceForUnderline,DXW.SpaceForUnderline>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Balance Text Columns within a Section.
  /// </summary>
  [DataMember]
  public DMW.NoColumnBalance? NoColumnBalance
  {
    get
    {
      return _Element?.GetObject<DMW.NoColumnBalance,DXW.NoColumnBalance>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoColumnBalance,DXW.NoColumnBalance>(value);
    }
  }
  
  
  /// <summary>
  ///   Balance Single Byte and Double Byte Characters.
  /// </summary>
  [DataMember]
  public DMW.BalanceSingleByteDoubleByteWidth? BalanceSingleByteDoubleByteWidth
  {
    get
    {
      return _Element?.GetObject<DMW.BalanceSingleByteDoubleByteWidth,DXW.BalanceSingleByteDoubleByteWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BalanceSingleByteDoubleByteWidth,DXW.BalanceSingleByteDoubleByteWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  [DataMember]
  public DMW.NoExtraLineSpacing? NoExtraLineSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.NoExtraLineSpacing,DXW.NoExtraLineSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoExtraLineSpacing,DXW.NoExtraLineSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   Convert Backslash To Yen Sign When Entered.
  /// </summary>
  [DataMember]
  public DMW.DoNotLeaveBackslashAlone? DoNotLeaveBackslashAlone
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotLeaveBackslashAlone,DXW.DoNotLeaveBackslashAlone>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotLeaveBackslashAlone,DXW.DoNotLeaveBackslashAlone>(value);
    }
  }
  
  
  /// <summary>
  ///   Underline All Trailing Spaces.
  /// </summary>
  [DataMember]
  public DMW.UnderlineTrailingSpaces? UnderlineTrailingSpaces
  {
    get
    {
      return _Element?.GetObject<DMW.UnderlineTrailingSpaces,DXW.UnderlineTrailingSpaces>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UnderlineTrailingSpaces,DXW.UnderlineTrailingSpaces>(value);
    }
  }
  
  
  /// <summary>
  ///   Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  [DataMember]
  public DMW.DoNotExpandShiftReturn? DoNotExpandShiftReturn
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotExpandShiftReturn,DXW.DoNotExpandShiftReturn>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotExpandShiftReturn,DXW.DoNotExpandShiftReturn>(value);
    }
  }
  
  
  /// <summary>
  ///   Only Expand/Condense Text By Whole Points.
  /// </summary>
  [DataMember]
  public DMW.SpacingInWholePoints? SpacingInWholePoints
  {
    get
    {
      return _Element?.GetObject<DMW.SpacingInWholePoints,DXW.SpacingInWholePoints>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SpacingInWholePoints,DXW.SpacingInWholePoints>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  [DataMember]
  public DMW.LineWrapLikeWord6? LineWrapLikeWord6
  {
    get
    {
      return _Element?.GetObject<DMW.LineWrapLikeWord6,DXW.LineWrapLikeWord6>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LineWrapLikeWord6,DXW.LineWrapLikeWord6>(value);
    }
  }
  
  
  /// <summary>
  ///   Print Body Text before Header/Footer Contents.
  /// </summary>
  [DataMember]
  public DMW.PrintBodyTextBeforeHeader? PrintBodyTextBeforeHeader
  {
    get
    {
      return _Element?.GetObject<DMW.PrintBodyTextBeforeHeader,DXW.PrintBodyTextBeforeHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintBodyTextBeforeHeader,DXW.PrintBodyTextBeforeHeader>(value);
    }
  }
  
  
  /// <summary>
  ///   Print Colors as Black And White without Dithering.
  /// </summary>
  [DataMember]
  public DMW.PrintColorBlackWhite? PrintColorBlackWhite
  {
    get
    {
      return _Element?.GetObject<DMW.PrintColorBlackWhite,DXW.PrintColorBlackWhite>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintColorBlackWhite,DXW.PrintColorBlackWhite>(value);
    }
  }
  
  
  /// <summary>
  ///   Space width.
  /// </summary>
  [DataMember]
  public DMW.WordPerfectSpaceWidth? WordPerfectSpaceWidth
  {
    get
    {
      return _Element?.GetObject<DMW.WordPerfectSpaceWidth,DXW.WordPerfectSpaceWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WordPerfectSpaceWidth,DXW.WordPerfectSpaceWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Display Page/Column Breaks Present in Frames.
  /// </summary>
  [DataMember]
  public DMW.ShowBreaksInFrames? ShowBreaksInFrames
  {
    get
    {
      return _Element?.GetObject<DMW.ShowBreaksInFrames,DXW.ShowBreaksInFrames>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ShowBreaksInFrames,DXW.ShowBreaksInFrames>(value);
    }
  }
  
  
  /// <summary>
  ///   Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  [DataMember]
  public DMW.SubFontBySize? SubFontBySize
  {
    get
    {
      return _Element?.GetObject<DMW.SubFontBySize,DXW.SubFontBySize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SubFontBySize,DXW.SubFontBySize>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  [DataMember]
  public DMW.SuppressBottomSpacing? SuppressBottomSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressBottomSpacing,DXW.SuppressBottomSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressBottomSpacing,DXW.SuppressBottomSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public DMW.SuppressTopSpacing? SuppressTopSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressTopSpacing,DXW.SuppressTopSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressTopSpacing,DXW.SuppressTopSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public DMW.SuppressSpacingAtTopOfPage? SuppressSpacingAtTopOfPage
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressSpacingAtTopOfPage,DXW.SuppressSpacingAtTopOfPage>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressSpacingAtTopOfPage,DXW.SuppressSpacingAtTopOfPage>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  [DataMember]
  public DMW.SuppressTopSpacingWordPerfect? SuppressTopSpacingWordPerfect
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressTopSpacingWordPerfect,DXW.SuppressTopSpacingWordPerfect>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressTopSpacingWordPerfect,DXW.SuppressTopSpacingWordPerfect>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  [DataMember]
  public DMW.SuppressSpacingBeforeAfterPageBreak? SuppressSpacingBeforeAfterPageBreak
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressSpacingBeforeAfterPageBreak,DXW.SuppressSpacingBeforeAfterPageBreak>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressSpacingBeforeAfterPageBreak,DXW.SuppressSpacingBeforeAfterPageBreak>(value);
    }
  }
  
  
  /// <summary>
  ///   Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  [DataMember]
  public DMW.SwapBordersFacingPages? SwapBordersFacingPages
  {
    get
    {
      return _Element?.GetObject<DMW.SwapBordersFacingPages,DXW.SwapBordersFacingPages>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SwapBordersFacingPages,DXW.SwapBordersFacingPages>(value);
    }
  }
  
  
  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  [DataMember]
  public DMW.ConvertMailMergeEscape? ConvertMailMergeEscape
  {
    get
    {
      return _Element?.GetObject<DMW.ConvertMailMergeEscape,DXW.ConvertMailMergeEscape>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ConvertMailMergeEscape,DXW.ConvertMailMergeEscape>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  [DataMember]
  public DMW.TruncateFontHeightsLikeWordPerfect? TruncateFontHeightsLikeWordPerfect
  {
    get
    {
      return _Element?.GetObject<DMW.TruncateFontHeightsLikeWordPerfect,DXW.TruncateFontHeightsLikeWordPerfect>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TruncateFontHeightsLikeWordPerfect,DXW.TruncateFontHeightsLikeWordPerfect>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  [DataMember]
  public DMW.MacWordSmallCaps? MacWordSmallCaps
  {
    get
    {
      return _Element?.GetObject<DMW.MacWordSmallCaps,DXW.MacWordSmallCaps>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MacWordSmallCaps,DXW.MacWordSmallCaps>(value);
    }
  }
  
  
  /// <summary>
  ///   Use Printer Metrics To Display Documents.
  /// </summary>
  [DataMember]
  public DMW.UsePrinterMetrics? UsePrinterMetrics
  {
    get
    {
      return _Element?.GetObject<DMW.UsePrinterMetrics,DXW.UsePrinterMetrics>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UsePrinterMetrics,DXW.UsePrinterMetrics>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  [DataMember]
  public DMW.DoNotSuppressParagraphBorders? DoNotSuppressParagraphBorders
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotSuppressParagraphBorders,DXW.DoNotSuppressParagraphBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotSuppressParagraphBorders,DXW.DoNotSuppressParagraphBorders>(value);
    }
  }
  
  
  /// <summary>
  ///   Line Wrap Trailing Spaces.
  /// </summary>
  [DataMember]
  public DMW.WrapTrailSpaces? WrapTrailSpaces
  {
    get
    {
      return _Element?.GetObject<DMW.WrapTrailSpaces,DXW.WrapTrailSpaces>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WrapTrailSpaces,DXW.WrapTrailSpaces>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  [DataMember]
  public DMW.FootnoteLayoutLikeWord8? FootnoteLayoutLikeWord8
  {
    get
    {
      return _Element?.GetObject<DMW.FootnoteLayoutLikeWord8,DXW.FootnoteLayoutLikeWord8>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FootnoteLayoutLikeWord8,DXW.FootnoteLayoutLikeWord8>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  [DataMember]
  public DMW.ShapeLayoutLikeWord8? ShapeLayoutLikeWord8
  {
    get
    {
      return _Element?.GetObject<DMW.ShapeLayoutLikeWord8,DXW.ShapeLayoutLikeWord8>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ShapeLayoutLikeWord8,DXW.ShapeLayoutLikeWord8>(value);
    }
  }
  
  
  /// <summary>
  ///   Align Table Rows Independently.
  /// </summary>
  [DataMember]
  public DMW.AlignTablesRowByRow? AlignTablesRowByRow
  {
    get
    {
      return _Element?.GetObject<DMW.AlignTablesRowByRow,DXW.AlignTablesRowByRow>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AlignTablesRowByRow,DXW.AlignTablesRowByRow>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  [DataMember]
  public DMW.ForgetLastTabAlignment? ForgetLastTabAlignment
  {
    get
    {
      return _Element?.GetObject<DMW.ForgetLastTabAlignment,DXW.ForgetLastTabAlignment>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ForgetLastTabAlignment,DXW.ForgetLastTabAlignment>(value);
    }
  }
  
  
  /// <summary>
  ///   Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  [DataMember]
  public DMW.AdjustLineHeightInTable? AdjustLineHeightInTable
  {
    get
    {
      return _Element?.GetObject<DMW.AdjustLineHeightInTable,DXW.AdjustLineHeightInTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AdjustLineHeightInTable,DXW.AdjustLineHeightInTable>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  [DataMember]
  public DMW.AutoSpaceLikeWord95? AutoSpaceLikeWord95
  {
    get
    {
      return _Element?.GetObject<DMW.AutoSpaceLikeWord95,DXW.AutoSpaceLikeWord95>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoSpaceLikeWord95,DXW.AutoSpaceLikeWord95>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  [DataMember]
  public DMW.NoSpaceRaiseLower? NoSpaceRaiseLower
  {
    get
    {
      return _Element?.GetObject<DMW.NoSpaceRaiseLower,DXW.NoSpaceRaiseLower>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoSpaceRaiseLower,DXW.NoSpaceRaiseLower>(value);
    }
  }
  
  
  /// <summary>
  ///   Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  [DataMember]
  public DMW.DoNotUseHTMLParagraphAutoSpacing? DoNotUseHTMLParagraphAutoSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotUseHTMLParagraphAutoSpacing,DXW.DoNotUseHTMLParagraphAutoSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotUseHTMLParagraphAutoSpacing,DXW.DoNotUseHTMLParagraphAutoSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  [DataMember]
  public DMW.LayoutRawTableWidth? LayoutRawTableWidth
  {
    get
    {
      return _Element?.GetObject<DMW.LayoutRawTableWidth,DXW.LayoutRawTableWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LayoutRawTableWidth,DXW.LayoutRawTableWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  [DataMember]
  public DMW.UseWord97LineBreakRules? UseWord97LineBreakRules
  {
    get
    {
      return _Element?.GetObject<DMW.UseWord97LineBreakRules,DXW.UseWord97LineBreakRules>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseWord97LineBreakRules,DXW.UseWord97LineBreakRules>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  [DataMember]
  public DMW.DoNotBreakWrappedTables? DoNotBreakWrappedTables
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotBreakWrappedTables,DXW.DoNotBreakWrappedTables>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotBreakWrappedTables,DXW.DoNotBreakWrappedTables>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  [DataMember]
  public DMW.DoNotSnapToGridInCell? DoNotSnapToGridInCell
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotSnapToGridInCell,DXW.DoNotSnapToGridInCell>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotSnapToGridInCell,DXW.DoNotSnapToGridInCell>(value);
    }
  }
  
  
  /// <summary>
  ///   Select Field When First or Last Character Is Selected.
  /// </summary>
  [DataMember]
  public DMW.SelectFieldWithFirstOrLastChar? SelectFieldWithFirstOrLastChar
  {
    get
    {
      return _Element?.GetObject<DMW.SelectFieldWithFirstOrLastChar,DXW.SelectFieldWithFirstOrLastChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SelectFieldWithFirstOrLastChar,DXW.SelectFieldWithFirstOrLastChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  [DataMember]
  public DMW.ApplyBreakingRules? ApplyBreakingRules
  {
    get
    {
      return _Element?.GetObject<DMW.ApplyBreakingRules,DXW.ApplyBreakingRules>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ApplyBreakingRules,DXW.ApplyBreakingRules>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  [DataMember]
  public DMW.DoNotWrapTextWithPunctuation? DoNotWrapTextWithPunctuation
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotWrapTextWithPunctuation,DXW.DoNotWrapTextWithPunctuation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotWrapTextWithPunctuation,DXW.DoNotWrapTextWithPunctuation>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  [DataMember]
  public DMW.DoNotUseEastAsianBreakRules? DoNotUseEastAsianBreakRules
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotUseEastAsianBreakRules,DXW.DoNotUseEastAsianBreakRules>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotUseEastAsianBreakRules,DXW.DoNotUseEastAsianBreakRules>(value);
    }
  }
  
  
  /// <summary>
  ///   Emulate Word 2002 Table Style Rules.
  /// </summary>
  [DataMember]
  public DMW.UseWord2002TableStyleRules? UseWord2002TableStyleRules
  {
    get
    {
      return _Element?.GetObject<DMW.UseWord2002TableStyleRules,DXW.UseWord2002TableStyleRules>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseWord2002TableStyleRules,DXW.UseWord2002TableStyleRules>(value);
    }
  }
  
  
  /// <summary>
  ///   Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  [DataMember]
  public DMW.GrowAutofit? GrowAutofit
  {
    get
    {
      return _Element?.GetObject<DMW.GrowAutofit,DXW.GrowAutofit>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.GrowAutofit,DXW.GrowAutofit>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  [DataMember]
  public DMW.UseFarEastLayout? UseFarEastLayout
  {
    get
    {
      return _Element?.GetObject<DMW.UseFarEastLayout,DXW.UseFarEastLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseFarEastLayout,DXW.UseFarEastLayout>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  [DataMember]
  public DMW.UseNormalStyleForList? UseNormalStyleForList
  {
    get
    {
      return _Element?.GetObject<DMW.UseNormalStyleForList,DXW.UseNormalStyleForList>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseNormalStyleForList,DXW.UseNormalStyleForList>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  [DataMember]
  public DMW.DoNotUseIndentAsNumberingTabStop? DoNotUseIndentAsNumberingTabStop
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotUseIndentAsNumberingTabStop,DXW.DoNotUseIndentAsNumberingTabStop>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotUseIndentAsNumberingTabStop,DXW.DoNotUseIndentAsNumberingTabStop>(value);
    }
  }
  
  
  /// <summary>
  ///   Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  [DataMember]
  public DMW.UseAltKinsokuLineBreakRules? UseAltKinsokuLineBreakRules
  {
    get
    {
      return _Element?.GetObject<DMW.UseAltKinsokuLineBreakRules,DXW.UseAltKinsokuLineBreakRules>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseAltKinsokuLineBreakRules,DXW.UseAltKinsokuLineBreakRules>(value);
    }
  }
  
  
  /// <summary>
  ///   Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  [DataMember]
  public DMW.AllowSpaceOfSameStyleInTable? AllowSpaceOfSameStyleInTable
  {
    get
    {
      return _Element?.GetObject<DMW.AllowSpaceOfSameStyleInTable,DXW.AllowSpaceOfSameStyleInTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AllowSpaceOfSameStyleInTable,DXW.AllowSpaceOfSameStyleInTable>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  [DataMember]
  public DMW.DoNotSuppressIndentation? DoNotSuppressIndentation
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotSuppressIndentation,DXW.DoNotSuppressIndentation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotSuppressIndentation,DXW.DoNotSuppressIndentation>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  [DataMember]
  public DMW.DoNotAutofitConstrainedTables? DoNotAutofitConstrainedTables
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotAutofitConstrainedTables,DXW.DoNotAutofitConstrainedTables>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotAutofitConstrainedTables,DXW.DoNotAutofitConstrainedTables>(value);
    }
  }
  
  
  /// <summary>
  ///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  [DataMember]
  public DMW.AutofitToFirstFixedWidthCell? AutofitToFirstFixedWidthCell
  {
    get
    {
      return _Element?.GetObject<DMW.AutofitToFirstFixedWidthCell,DXW.AutofitToFirstFixedWidthCell>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutofitToFirstFixedWidthCell,DXW.AutofitToFirstFixedWidthCell>(value);
    }
  }
  
  
  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  [DataMember]
  public DMW.UnderlineTabInNumberingList? UnderlineTabInNumberingList
  {
    get
    {
      return _Element?.GetObject<DMW.UnderlineTabInNumberingList,DXW.UnderlineTabInNumberingList>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UnderlineTabInNumberingList,DXW.UnderlineTabInNumberingList>(value);
    }
  }
  
  
  /// <summary>
  ///   Always Use Fixed Width for Hangul Characters.
  /// </summary>
  [DataMember]
  public DMW.DisplayHangulFixedWidth? DisplayHangulFixedWidth
  {
    get
    {
      return _Element?.GetObject<DMW.DisplayHangulFixedWidth,DXW.DisplayHangulFixedWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DisplayHangulFixedWidth,DXW.DisplayHangulFixedWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  [DataMember]
  public DMW.SplitPageBreakAndParagraphMark? SplitPageBreakAndParagraphMark
  {
    get
    {
      return _Element?.GetObject<DMW.SplitPageBreakAndParagraphMark,DXW.SplitPageBreakAndParagraphMark>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SplitPageBreakAndParagraphMark,DXW.SplitPageBreakAndParagraphMark>(value);
    }
  }
  
  
  /// <summary>
  ///   Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  [DataMember]
  public DMW.DoNotVerticallyAlignCellWithShape? DoNotVerticallyAlignCellWithShape
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotVerticallyAlignCellWithShape,DXW.DoNotVerticallyAlignCellWithShape>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotVerticallyAlignCellWithShape,DXW.DoNotVerticallyAlignCellWithShape>(value);
    }
  }
  
  
  /// <summary>
  ///   Don't Break Table Rows Around Floating Tables.
  /// </summary>
  [DataMember]
  public DMW.DoNotBreakConstrainedForcedTable? DoNotBreakConstrainedForcedTable
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotBreakConstrainedForcedTable,DXW.DoNotBreakConstrainedForcedTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotBreakConstrainedForcedTable,DXW.DoNotBreakConstrainedForcedTable>(value);
    }
  }
  
  
  /// <summary>
  ///   Ignore Vertical Alignment in Textboxes.
  /// </summary>
  [DataMember]
  public DMW.DoNotVerticallyAlignInTextBox? DoNotVerticallyAlignInTextBox
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotVerticallyAlignInTextBox,DXW.DoNotVerticallyAlignInTextBox>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotVerticallyAlignInTextBox,DXW.DoNotVerticallyAlignInTextBox>(value);
    }
  }
  
  
  /// <summary>
  ///   Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  [DataMember]
  public DMW.UseAnsiKerningPairs? UseAnsiKerningPairs
  {
    get
    {
      return _Element?.GetObject<DMW.UseAnsiKerningPairs,DXW.UseAnsiKerningPairs>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseAnsiKerningPairs,DXW.UseAnsiKerningPairs>(value);
    }
  }
  
  
  /// <summary>
  ///   Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  [DataMember]
  public DMW.CachedColumnBalance? CachedColumnBalance
  {
    get
    {
      return _Element?.GetObject<DMW.CachedColumnBalance,DXW.CachedColumnBalance>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CachedColumnBalance,DXW.CachedColumnBalance>(value);
    }
  }
  
}
