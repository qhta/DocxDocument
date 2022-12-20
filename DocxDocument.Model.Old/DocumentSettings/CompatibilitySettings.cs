using System.Runtime.CompilerServices;

using Microsoft.Office.Interop.Word;

namespace DocxDocument.Model;

public class CompatibilitySettings : IDocxBasedElement, ICompatibilitySettings, IEnumerable<KeyValuePair<string, object?>>
{
  const string wordUrl = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

  public CompatibilitySettings()
  {
    WdCompatibility = new WD.Compatibility();
  }

  public CompatibilitySettings(WD.Compatibility wdCompatibilitySettings)
  {
    WdCompatibility = wdCompatibilitySettings;
  }

  [XmlIgnore]
  public OO.OpenXmlElement OpenXmlElement { get => WdCompatibility; set => WdCompatibility = (WD.Compatibility)value; }

  [XmlIgnore]
  public WD.Compatibility WdCompatibility { get; set; }

  /// <summary> 
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  ///</summary> 
  public bool? AdjustLineHeightInTable
  {
    get => WdCompatibility.AdjustLineHeightInTable?.Val?.Value;
    set
    {
      WdCompatibility.AdjustLineHeightInTable = (value != null) ? new WD.AdjustLineHeightInTable { Val = value } : null;
    }
  }

  /// <summary> 
  /// Align Table Rows Independently.
  ///</summary> 
  public bool? AlignTablesRowByRow
  {
    get => WdCompatibility.AlignTablesRowByRow?.Val?.Value;
    set
    {
      WdCompatibility.AlignTablesRowByRow = (value != null) ? new WD.AlignTablesRowByRow { Val = value } : null;
      //if (value == AlignTablesRowByRow)
      //  return;
      //if (value == null)
      //  WdCompatibilitySettings.AlignTablesRowByRow?.Remove();
      //else
      //  WdCompatibilitySettings.AlignTablesRowByRow = new WD.AlignTablesRowByRow { Val = value };
    }
  }

  /// <summary> 
  /// Allow Contextual Spacing of Paragraphs in Tables.
  ///</summary> 
  public bool? AllowSpaceOfSameStyleInTable
  {
    get => WdCompatibility.AllowSpaceOfSameStyleInTable?.Val?.Value;
    set
    {
      WdCompatibility.AllowSpaceOfSameStyleInTable = (value != null) ? new WD.AllowSpaceOfSameStyleInTable { Val = value } : null;
    }
  }

  /// <summary> 
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  ///</summary> 
  public bool? ApplyBreakingRules
  {
    get => WdCompatibility.ApplyBreakingRules?.Val?.Value;
    set
    {
      WdCompatibility.ApplyBreakingRules = (value != null) ? new WD.ApplyBreakingRules { Val = value } : null;
    }
  }

  /// <summary> 
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  ///</summary> 
  public bool? AutofitToFirstFixedWidthCell
  {
    get => WdCompatibility.AutofitToFirstFixedWidthCell?.Val?.Value;
    set
    {
      WdCompatibility.AutofitToFirstFixedWidthCell = (value != null) ? new WD.AutofitToFirstFixedWidthCell { Val = value } : null;
    }
  }

  /// <summary> 
  /// Emulate Word 95 Full-Width Character Spacing.
  ///</summary> 
  public bool? AutoSpaceLikeWord95
  {
    get => WdCompatibility.AutoSpaceLikeWord95?.Val?.Value;
    set
    {
      WdCompatibility.AutoSpaceLikeWord95 = (value != null) ? new WD.AutoSpaceLikeWord95 { Val = value } : null;
    }
  }

  /// <summary> 
  /// Balance Single Byte and Double Byte Characters.
  ///</summary> 
  public bool? BalanceSingleByteDoubleByteWidth
  {
    get => WdCompatibility.BalanceSingleByteDoubleByteWidth?.Val?.Value;
    set
    {
      WdCompatibility.BalanceSingleByteDoubleByteWidth = (value != null) ? new WD.BalanceSingleByteDoubleByteWidth { Val = value } : null;
    }
  }

  /// <summary> 
  /// Use Cached Paragraph Information for Column Balancing.
  ///</summary> 
  public bool? CachedColumnBalance
  {
    get => WdCompatibility.CachedColumnBalance?.Val?.Value;
    set
    {
      WdCompatibility.CachedColumnBalance = (value != null) ? new WD.CachedColumnBalance { Val = value } : null;
    }
  }

  /// <summary> 
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  ///</summary> 
  public bool? ConvertMailMergeEscape
  {
    get => WdCompatibility.ConvertMailMergeEscape?.Val?.Value;
    set
    {
      WdCompatibility.ConvertMailMergeEscape = (value != null) ? new WD.ConvertMailMergeEscape { Val = value } : null;
    }
  }

  /// <summary> 
  /// Always Use Fixed Width for Hangul Characters.
  ///</summary> 
  public bool? DisplayHangulFixedWidth
  {
    get => WdCompatibility.DisplayHangulFixedWidth?.Val?.Value;
    set
    {
      WdCompatibility.DisplayHangulFixedWidth = (value != null) ? new WD.DisplayHangulFixedWidth { Val = value } : null;
    }
  }

  /// <summary> 
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  ///</summary> 
  public bool? DoNotAutofitConstrainedTables
  {
    get => WdCompatibility.DoNotAutofitConstrainedTables?.Val?.Value;
    set
    {
      WdCompatibility.DoNotAutofitConstrainedTables = (value != null) ? new WD.DoNotAutofitConstrainedTables { Val = value } : null;
    }
  }

  /// <summary> 
  /// Don't Break Table Rows Around Floating Tables.
  ///</summary> 
  public bool? DoNotBreakConstrainedForcedTable
  {
    get => WdCompatibility.DoNotBreakConstrainedForcedTable?.Val?.Value;
    set
    {
      WdCompatibility.DoNotBreakConstrainedForcedTable = (value != null) ? new WD.DoNotBreakConstrainedForcedTable { Val = value } : null;
    }
  }

  /// <summary> 
  /// Do Not Allow Floating Tables To Break Across Pages.
  ///</summary> 
  public bool? DoNotBreakWrappedTables
  {
    get => WdCompatibility.DoNotBreakWrappedTables?.Val?.Value;
    set
    {
      WdCompatibility.DoNotBreakWrappedTables = (value != null) ? new WD.DoNotBreakWrappedTables { Val = value } : null;
    }
  }

  /// <summary> 
  /// Don't Justify Lines Ending in Soft Line Break.
  ///</summary> 
  public bool? DoNotExpandShiftReturn
  {
    get => WdCompatibility.DoNotExpandShiftReturn?.Val?.Value;
    set
    {
      WdCompatibility.DoNotExpandShiftReturn = (value != null) ? new WD.DoNotExpandShiftReturn { Val = value } : null;
    }
  }

  /// <summary> 
  /// Convert Backslash To Yen Sign When Entered.
  ///</summary> 
  public bool? DoNotLeaveBackslashAlone
  {
    get => WdCompatibility.DoNotLeaveBackslashAlone?.Val?.Value;
    set
    {
      WdCompatibility.DoNotLeaveBackslashAlone = (value != null) ? new WD.DoNotLeaveBackslashAlone { Val = value } : null;
    }
  }

  /// <summary> 
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  ///</summary> 
  public bool? DoNotSnapToGridInCell
  {
    get => WdCompatibility.DoNotLeaveBackslashAlone?.Val?.Value;
    set
    {
      WdCompatibility.DoNotLeaveBackslashAlone = (value != null) ? new WD.DoNotLeaveBackslashAlone { Val = value } : null;
    }
  }

  /// <summary> 
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  ///</summary> 
  public bool? DoNotSuppressIndentation
  {
    get => WdCompatibility.DoNotSuppressIndentation?.Val?.Value;
    set => WdCompatibility.DoNotSuppressIndentation = (value != null) ? new WD.DoNotSuppressIndentation { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Suppress Paragraph Borders Next To Frames.
  ///</summary> 
  public bool? DoNotSuppressParagraphBorders
  {
    get => WdCompatibility.DoNotSuppressParagraphBorders?.Val?.Value;
    set => WdCompatibility.DoNotSuppressParagraphBorders = (value != null) ? new WD.DoNotSuppressParagraphBorders { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Compress Compressible Characters When Using Document Grid.
  ///</summary> 
  public bool? DoNotUseEastAsianBreakRules
  {
    get => WdCompatibility.DoNotUseEastAsianBreakRules?.Val?.Value;
    set => WdCompatibility.DoNotUseEastAsianBreakRules = (value != null) ? new WD.DoNotUseEastAsianBreakRules { Val = value } : null;
  }

  /// <summary> 
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  ///</summary> 
  public bool? DoNotUseHTMLParagraphAutoSpacing
  {
    get => WdCompatibility.DoNotUseHTMLParagraphAutoSpacing?.Val?.Value;
    set => WdCompatibility.DoNotUseHTMLParagraphAutoSpacing = (value != null) ? new WD.DoNotUseHTMLParagraphAutoSpacing { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  ///</summary> 
  public bool? DoNotUseIndentAsNumberingTabStop
  {
    get => WdCompatibility.DoNotUseIndentAsNumberingTabStop?.Val?.Value;
    set => WdCompatibility.DoNotUseIndentAsNumberingTabStop = (value != null) ? new WD.DoNotUseIndentAsNumberingTabStop { Val = value } : null;
  }

  /// <summary> 
  /// Don't Vertically Align Cells Containing Floating Objects.
  ///</summary> 
  public bool? DoNotVerticallyAlignCellWithShape
  {
    get => WdCompatibility.DoNotVerticallyAlignCellWithShape?.Val?.Value;
    set => WdCompatibility.DoNotVerticallyAlignCellWithShape = (value != null) ? new WD.DoNotVerticallyAlignCellWithShape { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Vertical Alignment in Textboxes.
  ///</summary> 
  public bool? DoNotVerticallyAlignInTextBox
  {
    get => WdCompatibility.DoNotVerticallyAlignInTextBox?.Val?.Value;
    set => WdCompatibility.DoNotVerticallyAlignInTextBox = (value != null) ? new WD.DoNotVerticallyAlignInTextBox { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Allow Hanging Punctuation With Character Grid.
  ///</summary> 
  public bool? DoNotWrapTextWithPunctuation
  {
    get => WdCompatibility.DoNotWrapTextWithPunctuation?.Val?.Value;
    set => WdCompatibility.DoNotWrapTextWithPunctuation = (value != null) ? new WD.DoNotWrapTextWithPunctuation { Val = value } : null;
  }

  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? FootnoteLayoutLikeWord8
  {
    get => WdCompatibility.FootnoteLayoutLikeWord8?.Val?.Value;
    set => WdCompatibility.FootnoteLayoutLikeWord8 = (value != null) ? new WD.FootnoteLayoutLikeWord8 { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  ///</summary> 
  public bool? ForgetLastTabAlignment
  {
    get => WdCompatibility.ForgetLastTabAlignment?.Val?.Value;
    set => WdCompatibility.ForgetLastTabAlignment = (value != null) ? new WD.ForgetLastTabAlignment { Val = value } : null;
  }

  /// <summary> 
  /// Allow Tables to AutoFit Into Page Margins.
  ///</summary> 
  public bool? GrowAutofit
  {
    get => WdCompatibility.GrowAutofit?.Val?.Value;
    set => WdCompatibility.GrowAutofit = (value != null) ? new WD.GrowAutofit { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  ///</summary> 
  public bool? LayoutRawTableWidth
  {
    get => WdCompatibility.LayoutRawTableWidth?.Val?.Value;
    set => WdCompatibility.LayoutRawTableWidth = (value != null) ? new WD.LayoutRawTableWidth { Val = value } : null;
  }

  /// <summary> 
  /// Allow Table Rows to Wrap Inline Objects Independently.
  ///</summary> 
  public bool? LayoutTableRowsApart
  {
    get => WdCompatibility.LayoutTableRowsApart?.Val?.Value;
    set => WdCompatibility.LayoutTableRowsApart = (value != null) ? new WD.LayoutTableRowsApart { Val = value } : null;
  }

  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? LineWrapLikeWord6
  {
    get => WdCompatibility.LineWrapLikeWord6?.Val?.Value;
    set => WdCompatibility.LineWrapLikeWord6 = (value != null) ? new WD.LineWrapLikeWord6 { Val = value } : null;
  }

  /// <summary> 
  /// Gets the local name of the element.
  ///</summary> 
  public bool? MacWordSmallCaps
  {
    get => WdCompatibility.MacWordSmallCaps?.Val?.Value;
    set => WdCompatibility.MacWordSmallCaps = (value != null) ? new WD.MacWordSmallCaps { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Balance Text Columns within a Section.
  ///</summary> 
  public bool? NoColumnBalance
  {
    get => WdCompatibility.NoColumnBalance?.Val?.Value;
    set => WdCompatibility.NoColumnBalance = (value != null) ? new WD.NoColumnBalance { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Center Content on Lines With Exact Line Height.
  ///</summary> 
  public bool? NoExtraLineSpacing
  {
    get => WdCompatibility.NoExtraLineSpacing?.Val?.Value;
    set => WdCompatibility.NoExtraLineSpacing = (value != null) ? new WD.NoExtraLineSpacing { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Add Leading Between Lines of Text.
  ///</summary> 
  public bool? NoLeading
  {
    get => WdCompatibility.NoLeading?.Val?.Value;
    set => WdCompatibility.NoLeading = (value != null) ? new WD.NoLeading { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Increase Line Height for Raised/Lowered Text.
  ///</summary> 
  public bool? NoSpaceRaiseLower
  {
    get => WdCompatibility.NoSpaceRaiseLower?.Val?.Value;
    set => WdCompatibility.NoSpaceRaiseLower = (value != null) ? new WD.NoSpaceRaiseLower { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  ///</summary> 
  public bool? NoTabHangIndent
  {
    get => WdCompatibility.NoTabHangIndent?.Val?.Value;
    set => WdCompatibility.NoTabHangIndent = (value != null) ? new WD.NoTabHangIndent { Val = value } : null;
  }

  /// <summary> 
  /// Print Body Text before Header/Footer Contents.
  ///</summary> 
  public bool? PrintBodyTextBeforeHeader
  {
    get => WdCompatibility.PrintBodyTextBeforeHeader?.Val?.Value;
    set => WdCompatibility.PrintBodyTextBeforeHeader = (value != null) ? new WD.PrintBodyTextBeforeHeader { Val = value } : null;
  }

  /// <summary> 
  /// Print Colors as Black And White without Dithering.
  ///</summary> 
  public bool? PrintColorBlackWhite
  {
    get => WdCompatibility.PrintColorBlackWhite?.Val?.Value;
    set => WdCompatibility.PrintColorBlackWhite = (value != null) ? new WD.PrintColorBlackWhite { Val = value } : null;
  }

  /// <summary> 
  /// Select Field When First or Last Character Is Selected.
  ///</summary> 
  public bool? SelectFieldWithFirstOrLastChar
  {
    get => WdCompatibility.SelectFieldWithFirstOrLastChar?.Val?.Value;
    set => WdCompatibility.SelectFieldWithFirstOrLastChar = (value != null) ? new WD.SelectFieldWithFirstOrLastChar { Val = value } : null;
  }

  /// <summary> 
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  ///</summary> 
  public bool? ShapeLayoutLikeWord8
  {
    get => WdCompatibility.ShapeLayoutLikeWord8?.Val?.Value;
    set => WdCompatibility.ShapeLayoutLikeWord8 = (value != null) ? new WD.ShapeLayoutLikeWord8 { Val = value } : null;
  }

  /// <summary> 
  /// Display Page/Column Breaks Present in Frames.
  ///</summary> 
  public bool? ShowBreaksInFrames
  {
    get => WdCompatibility.ShowBreaksInFrames?.Val?.Value;
    set => WdCompatibility.ShowBreaksInFrames = (value != null) ? new WD.ShowBreaksInFrames { Val = value } : null;
  }

  /// <summary> 
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  ///</summary> 
  public bool? SpaceForUnderline
  {
    get => WdCompatibility.SpaceForUnderline?.Val?.Value;
    set => WdCompatibility.SpaceForUnderline = (value != null) ? new WD.SpaceForUnderline { Val = value } : null;
  }

  /// <summary> 
  /// Only Expand/Condense Text By Whole Points.
  ///</summary> 
  public bool? SpacingInWholePoints
  {
    get => WdCompatibility.SpacingInWholePoints?.Val?.Value;
    set => WdCompatibility.SpacingInWholePoints = (value != null) ? new WD.SpacingInWholePoints { Val = value } : null;
  }

  /// <summary> 
  /// Always Move Paragraph Mark to Page after a Page Break.
  ///</summary> 
  public bool? SplitPageBreakAndParagraphMark
  {
    get => WdCompatibility.SplitPageBreakAndParagraphMark?.Val?.Value;
    set => WdCompatibility.SplitPageBreakAndParagraphMark = (value != null) ? new WD.SplitPageBreakAndParagraphMark { Val = value } : null;
  }

  /// <summary> 
  /// Increase Priority Of Font Size During Font Substitution.
  ///</summary> 
  public bool? SubFontBySize
  {
    get => WdCompatibility.SubFontBySize?.Val?.Value;
    set => WdCompatibility.SubFontBySize = (value != null) ? new WD.SubFontBySize { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Exact Line Height for Last Line on Page.
  ///</summary> 
  public bool? SuppressBottomSpacing
  {
    get => WdCompatibility.SuppressBottomSpacing?.Val?.Value;
    set => WdCompatibility.SuppressBottomSpacing = (value != null) ? new WD.SuppressBottomSpacing { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Minimum Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressSpacingAtTopOfPage
  {
    get => WdCompatibility.SuppressSpacingAtTopOfPage?.Val?.Value;
    set => WdCompatibility.SuppressSpacingAtTopOfPage = (value != null) ? new WD.SuppressSpacingAtTopOfPage { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Use Space Before On First Line After a Page Break.
  ///</summary> 
  public bool? SuppressSpacingBeforeAfterPageBreak
  {
    get => WdCompatibility.SuppressSpacingBeforeAfterPageBreak?.Val?.Value;
    set => WdCompatibility.SuppressSpacingBeforeAfterPageBreak = (value != null) ? new WD.SuppressSpacingBeforeAfterPageBreak { Val = value } : null;
  }

  /// <summary> 
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressTopSpacing
  {
    get => WdCompatibility.SuppressTopSpacing?.Val?.Value;
    set => WdCompatibility.SuppressTopSpacing = (value != null) ? new WD.SuppressTopSpacing { Val = value } : null;
  }

  /// <summary> 
  /// Emulate WordPerfect 5.
  ///</summary> 
  public bool? SuppressTopSpacingWordPerfect
  {
    get => WdCompatibility.SuppressTopSpacingWordPerfect?.Val?.Value;
    set => WdCompatibility.SuppressTopSpacingWordPerfect = (value != null) ? new WD.SuppressTopSpacingWordPerfect { Val = value } : null;
  }

  /// <summary> 
  /// Swap Paragraph Borders on Odd Numbered Pages.
  ///</summary> 
  public bool? SwapBordersFacingPages
  {
    get => WdCompatibility.SwapBordersFacingPages?.Val?.Value;
    set => WdCompatibility.SwapBordersFacingPages = (value != null) ? new WD.SwapBordersFacingPages { Val = value } : null;
  }

  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? TruncateFontHeightsLikeWordPerfect
  {
    get => WdCompatibility.TruncateFontHeightsLikeWordPerfect?.Val?.Value;
    set => WdCompatibility.TruncateFontHeightsLikeWordPerfect = (value != null) ? new WD.TruncateFontHeightsLikeWordPerfect { Val = value } : null;
  }

  /// <summary> 
  /// Underline Following Character Following Numbering.
  ///</summary> 
  public bool? UnderlineTabInNumberingList
  {
    get => WdCompatibility.UnderlineTabInNumberingList?.Val?.Value;
    set => WdCompatibility.UnderlineTabInNumberingList = (value != null) ? new WD.UnderlineTabInNumberingList { Val = value } : null;
  }

  /// <summary> 
  /// Underline All Trailing Spaces.
  ///</summary> 
  public bool? UnderlineTrailingSpaces
  {
    get => WdCompatibility.UnderlineTrailingSpaces?.Val?.Value;
    set => WdCompatibility.UnderlineTrailingSpaces = (value != null) ? new WD.UnderlineTrailingSpaces { Val = value } : null;
  }

  /// <summary> 
  /// Use Alternate Set of East Asian Line Breaking Rules.
  ///</summary> 
  public bool? UseAltKinsokuLineBreakRules
  {
    get => WdCompatibility.UseAltKinsokuLineBreakRules?.Val?.Value;
    set => WdCompatibility.UseAltKinsokuLineBreakRules = (value != null) ? new WD.UseAltKinsokuLineBreakRules { Val = value } : null;
  }

  /// <summary> 
  /// Use ANSI Kerning Pairs from Fonts.
  ///</summary> 
  public bool? UseAnsiKerningPairs
  {
    get => WdCompatibility.UseAnsiKerningPairs?.Val?.Value;
    set => WdCompatibility.UseAnsiKerningPairs = (value != null) ? new WD.UseAnsiKerningPairs { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  ///</summary> 
  public bool? UseFarEastLayout
  {
    get => WdCompatibility.UseFarEastLayout?.Val?.Value;
    set => WdCompatibility.UseFarEastLayout = (value != null) ? new WD.UseFarEastLayout { Val = value } : null;
  }

  /// <summary> 
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  ///</summary> 
  public bool? UseNormalStyleForList
  {
    get => WdCompatibility.UseNormalStyleForList?.Val?.Value;
    set => WdCompatibility.UseNormalStyleForList = (value != null) ? new WD.UseNormalStyleForList { Val = value } : null;
  }

  /// <summary> 
  /// Use Printer Metrics To Display Documents.
  ///</summary> 
  public bool? UsePrinterMetrics
  {
    get => WdCompatibility.UsePrinterMetrics?.Val?.Value;
    set => WdCompatibility.UsePrinterMetrics = (value != null) ? new WD.UsePrinterMetrics { Val = value } : null;
  }

  /// <summary> 
  /// Use Simplified Rules For Table Border Conflicts.
  ///</summary> 
  public bool? UseSingleBorderForContiguousCells
  {
    get => WdCompatibility.UseSingleBorderForContiguousCells?.Val?.Value;
    set => WdCompatibility.UseSingleBorderForContiguousCells = (value != null) ? new WD.UseSingleBorderForContiguousCells { Val = value } : null;
  }

  /// <summary> 
  /// Emulate Word 2002 Table Style Rules.
  ///</summary> 
  public bool? UseWord2002TableStyleRules
  {
    get => WdCompatibility.UseWord2002TableStyleRules?.Val?.Value;
    set => WdCompatibility.UseWord2002TableStyleRules = (value != null) ? new WD.UseWord2002TableStyleRules { Val = value } : null;
  }

  /// <summary> 
  /// Emulate Word 97 East Asian Line Breaking.
  ///</summary> 
  public bool? UseWord97LineBreakRules
  {
    get => WdCompatibility.UseWord97LineBreakRules?.Val?.Value;
    set => WdCompatibility.UseWord97LineBreakRules = (value != null) ? new WD.UseWord97LineBreakRules { Val = value } : null;
  }

  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? WordPerfectJustification
  {
    get => WdCompatibility.WordPerfectJustification?.Val?.Value;
    set => WdCompatibility.WordPerfectJustification = (value != null) ? new WD.WordPerfectJustification { Val = value } : null;
  }

  /// <summary> 
  /// Space width.
  ///</summary> 
  public bool? WordPerfectSpaceWidth
  {
    get => WdCompatibility.WordPerfectSpaceWidth?.Val?.Value;
    set => WdCompatibility.WordPerfectSpaceWidth = (value != null) ? new WD.WordPerfectSpaceWidth { Val = value } : null;
  }

  /// <summary> 
  /// Line Wrap Trailing Spaces.
  ///</summary> 
  public bool? WrapTrailSpaces
  {
    get => WdCompatibility.WrapTrailSpaces?.Val?.Value;
    set => WdCompatibility.WrapTrailSpaces = (value != null) ? new WD.WrapTrailSpaces { Val = value } : null;
  }

  #region CompatibilitySettings collection

  private int? GetCompatibilitySettingAsInt(WD.CompatSettingNameValues wdCompatSettingName)
  {
    var wdCompatibilityMode = WdCompatibility.OfType<WD.CompatibilitySetting>()
      ?.FirstOrDefault(item => item.Name?.Value == wdCompatSettingName);
    if (wdCompatibilityMode != null)
    {
      var str = wdCompatibilityMode.Val?.Value;
      if (str != null)
        return int.Parse(str);
    }
    return null;
  }

  private void SetCompatibilitySettingAsInt(WD.CompatSettingNameValues wdCompatSettingName, int? value)
  {
    var wdCompatibilityMode = WdCompatibility.OfType<WD.CompatibilitySetting>()
      ?.FirstOrDefault(item => item.Name?.Value == WD.CompatSettingNameValues.CompatibilityMode);
    if (wdCompatibilityMode != null)
      wdCompatibilityMode.Remove();
    if (value != null)
    {
      WdCompatibility.AddChild(new WD.CompatibilitySetting
      {
        Name = WD.CompatSettingNameValues.CompatibilityMode,
        Val = value.ToString()
      });
    }
  }

  private bool? GetCompatibilitySettingAsBool(WD.CompatSettingNameValues wdCompatSettingName)
  {
    var val = GetCompatibilitySettingAsInt(wdCompatSettingName);
    if (val==1)
      return true;
    if (val==0)
      return false;
    return null;
  }

  private void SetCompatibilitySettingAsBool(WD.CompatSettingNameValues wdCompatSettingName, bool? value)
  {
    int? val = null;
    if (value == true)
      val = 1;
    else if (value == false)
      val = 0;
    SetCompatibilitySettingAsInt(wdCompatSettingName, val);
  }

  /// <summary>
  ///  Specifies the feature set to use when editing the document.
  /// </summary>
  public int? CompatibilityMode
  {
    get => GetCompatibilitySettingAsInt(WD.CompatSettingNameValues.CompatibilityMode);
    set => SetCompatibilitySettingAsInt(WD.CompatSettingNameValues.CompatibilityMode, value);
  }

  /// <summary>
  /// Specifies how the style hierarchy of the document is evaluated.
  /// </summary>
  public bool? OverrideTableStyleFontSizeAndJustification
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, value);
  }

  /// <summary>
  /// Specifies whether [OpenType] features such as kerning (see [ISO/IEC29500-1:2011] section 17.3.2.19), ligatures,
  /// contextual alternates, stylistic sets, number spacing, and number formatting are to be used when displaying the font.
  /// </summary>
  public bool? EnableOpenTypeFeatures
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.EnableOpenTypeFeatures);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.EnableOpenTypeFeatures, value);
  }

  /// <summary>
  /// specifies whether the values of the inside and outside attributes of the ind element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.12)
  /// are swapped when displaying paragraphs containing a mirrorIndents element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.18).
  /// </summary>
  public bool? DoNotFlipMirrorIndents
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.DoNotFlipMirrorIndents);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.DoNotFlipMirrorIndents, value);
  }

  /// <summary>
  /// Specifies formatting information for the layout and display of multi-row table headers.
  /// </summary>
  public bool? DifferentiateMultirowTableHeaders
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.DifferentiateMultirowTableHeaders);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.DifferentiateMultirowTableHeaders, value);
  }


  /// <summary>
  /// specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then useWord2013TrackBottomHyphenation(section 2.3.8) controls the layout of the document.
  ///  If the value of val is true, then a line that ends with a hyphenated word is allowed to be the last line in a page or column.
  /// </summary>
  public bool? AllowHyphenationAtTrackBottom
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.AllowHyphenationAtTrackBottom);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.AllowHyphenationAtTrackBottom, value);
  }

  /// <summary>
  /// Specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then such a hyphenated word is displayed on the following page or column but the rest of the line that contained it is displayed on the previous page.
  /// If the value of val is true, then the line containing such a hyphenated word is displayed on the following page or column.
  /// If useWord2013TrackBottomHyphenation is not present, then the line containing such a hyphenated word is displayed on the following page or column as though useWord2013TrackBottomHyphenation were present with val set to true.
  /// If allowHyphenationAtTrackBottom(section 2.3.7) is set to true, useWord2013TrackBottomHyphenation MUST be ignored.
  /// </summary>
  public bool? UseWord2013TrackBottomHyphenation
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.UseWord2013TrackBottomHyphenation);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.UseWord2013TrackBottomHyphenation, value);
  }

  /// <summary>
  /// specifies information about the layout of document content which follows a floating table that breaks across pages.
  /// If the value of val is false, which is the default, then the document content that follows the floating table is added after the end of the table.
  /// If the value of val is true, then the document content that follows the floating table can be added to the same pages as the table.
  /// The content follows the usual page breaking rules and can flow around the table.
  /// </summary>
  public bool? AllowTextAfterFloatingTableBreak
  {
    get => GetCompatibilitySettingAsBool(WD.CompatSettingNameValues.AllowTextAfterFloatingTableBreak);
    set => SetCompatibilitySettingAsBool(WD.CompatSettingNameValues.AllowTextAfterFloatingTableBreak, value);
  }

  #endregion

  public void Clear()
  {
    WdCompatibility.RemoveAllChildren();
  }

  [XmlIgnore]
  public int Count => WdCompatibility.Elements().Count();


  public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
  {
    foreach (var prop in this.GetType().GetProperties())
    {
      if (prop.CanRead && prop.GetCustomAttribute<XmlIgnoreAttribute>() is null)
      {
        var val = prop.GetValue(this, new object[0]);
        if (val!=null)
          yield return new KeyValuePair<string, object?>(prop.Name, val);
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public bool Remove(string name)
  {
    var prop = this.GetType().GetProperty(name);
    if (prop != null)
    {
      var val = prop.GetValue(this, null);
      if (val != null)
      {
        prop.SetValue(this, new object?[] { null });
        return true;
      }
    }
    return false;
  }
}