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
      var element = _Element?.GetFirstChild<DXW.UseSingleBorderForContiguousCells>();
      if (element != null)
        return UseSingleBorderForContiguousCellsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseSingleBorderForContiguousCells>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseSingleBorderForContiguousCellsConverter.CreateOpenXmlElement<DXW.UseSingleBorderForContiguousCells>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WordPerfectJustification>();
      if (element != null)
        return WordPerfectJustificationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WordPerfectJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WordPerfectJustificationConverter.CreateOpenXmlElement<DXW.WordPerfectJustification>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NoTabHangIndent>();
      if (element != null)
        return NoTabHangIndentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoTabHangIndent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoTabHangIndentConverter.CreateOpenXmlElement<DXW.NoTabHangIndent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NoLeading>();
      if (element != null)
        return NoLeadingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoLeading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoLeadingConverter.CreateOpenXmlElement<DXW.NoLeading>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SpaceForUnderline>();
      if (element != null)
        return SpaceForUnderlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SpaceForUnderline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceForUnderlineConverter.CreateOpenXmlElement<DXW.SpaceForUnderline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NoColumnBalance>();
      if (element != null)
        return NoColumnBalanceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoColumnBalanceConverter.CreateOpenXmlElement<DXW.NoColumnBalance>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>();
      if (element != null)
        return BalanceSingleByteDoubleByteWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BalanceSingleByteDoubleByteWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BalanceSingleByteDoubleByteWidthConverter.CreateOpenXmlElement<DXW.BalanceSingleByteDoubleByteWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NoExtraLineSpacing>();
      if (element != null)
        return NoExtraLineSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoExtraLineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoExtraLineSpacingConverter.CreateOpenXmlElement<DXW.NoExtraLineSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotLeaveBackslashAlone>();
      if (element != null)
        return DoNotLeaveBackslashAloneConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotLeaveBackslashAlone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotLeaveBackslashAloneConverter.CreateOpenXmlElement<DXW.DoNotLeaveBackslashAlone>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UnderlineTrailingSpaces>();
      if (element != null)
        return UnderlineTrailingSpacesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UnderlineTrailingSpaces>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineTrailingSpacesConverter.CreateOpenXmlElement<DXW.UnderlineTrailingSpaces>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotExpandShiftReturn>();
      if (element != null)
        return DoNotExpandShiftReturnConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotExpandShiftReturn>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotExpandShiftReturnConverter.CreateOpenXmlElement<DXW.DoNotExpandShiftReturn>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SpacingInWholePoints>();
      if (element != null)
        return SpacingInWholePointsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SpacingInWholePoints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpacingInWholePointsConverter.CreateOpenXmlElement<DXW.SpacingInWholePoints>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LineWrapLikeWord6>();
      if (element != null)
        return LineWrapLikeWord6Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LineWrapLikeWord6>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineWrapLikeWord6Converter.CreateOpenXmlElement<DXW.LineWrapLikeWord6>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintBodyTextBeforeHeader>();
      if (element != null)
        return PrintBodyTextBeforeHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintBodyTextBeforeHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintBodyTextBeforeHeaderConverter.CreateOpenXmlElement<DXW.PrintBodyTextBeforeHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintColorBlackWhite>();
      if (element != null)
        return PrintColorBlackWhiteConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintColorBlackWhite>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintColorBlackWhiteConverter.CreateOpenXmlElement<DXW.PrintColorBlackWhite>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WordPerfectSpaceWidth>();
      if (element != null)
        return WordPerfectSpaceWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WordPerfectSpaceWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WordPerfectSpaceWidthConverter.CreateOpenXmlElement<DXW.WordPerfectSpaceWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ShowBreaksInFrames>();
      if (element != null)
        return ShowBreaksInFramesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ShowBreaksInFrames>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowBreaksInFramesConverter.CreateOpenXmlElement<DXW.ShowBreaksInFrames>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SubFontBySize>();
      if (element != null)
        return SubFontBySizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SubFontBySize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubFontBySizeConverter.CreateOpenXmlElement<DXW.SubFontBySize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressBottomSpacing>();
      if (element != null)
        return SuppressBottomSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressBottomSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressBottomSpacingConverter.CreateOpenXmlElement<DXW.SuppressBottomSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressTopSpacing>();
      if (element != null)
        return SuppressTopSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressTopSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressTopSpacingConverter.CreateOpenXmlElement<DXW.SuppressTopSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>();
      if (element != null)
        return SuppressSpacingAtTopOfPageConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressSpacingAtTopOfPage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressSpacingAtTopOfPageConverter.CreateOpenXmlElement<DXW.SuppressSpacingAtTopOfPage>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>();
      if (element != null)
        return SuppressTopSpacingWordPerfectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressTopSpacingWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressTopSpacingWordPerfectConverter.CreateOpenXmlElement<DXW.SuppressTopSpacingWordPerfect>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>();
      if (element != null)
        return SuppressSpacingBeforeAfterPageBreakConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressSpacingBeforeAfterPageBreak>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressSpacingBeforeAfterPageBreakConverter.CreateOpenXmlElement<DXW.SuppressSpacingBeforeAfterPageBreak>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SwapBordersFacingPages>();
      if (element != null)
        return SwapBordersFacingPagesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SwapBordersFacingPages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SwapBordersFacingPagesConverter.CreateOpenXmlElement<DXW.SwapBordersFacingPages>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ConvertMailMergeEscape>();
      if (element != null)
        return ConvertMailMergeEscapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ConvertMailMergeEscape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConvertMailMergeEscapeConverter.CreateOpenXmlElement<DXW.ConvertMailMergeEscape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>();
      if (element != null)
        return TruncateFontHeightsLikeWordPerfectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TruncateFontHeightsLikeWordPerfect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TruncateFontHeightsLikeWordPerfectConverter.CreateOpenXmlElement<DXW.TruncateFontHeightsLikeWordPerfect>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MacWordSmallCaps>();
      if (element != null)
        return MacWordSmallCapsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MacWordSmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MacWordSmallCapsConverter.CreateOpenXmlElement<DXW.MacWordSmallCaps>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UsePrinterMetrics>();
      if (element != null)
        return UsePrinterMetricsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UsePrinterMetrics>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UsePrinterMetricsConverter.CreateOpenXmlElement<DXW.UsePrinterMetrics>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotSuppressParagraphBorders>();
      if (element != null)
        return DoNotSuppressParagraphBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotSuppressParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotSuppressParagraphBordersConverter.CreateOpenXmlElement<DXW.DoNotSuppressParagraphBorders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WrapTrailSpaces>();
      if (element != null)
        return WrapTrailSpacesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WrapTrailSpaces>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapTrailSpacesConverter.CreateOpenXmlElement<DXW.WrapTrailSpaces>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.FootnoteLayoutLikeWord8>();
      if (element != null)
        return FootnoteLayoutLikeWord8Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FootnoteLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteLayoutLikeWord8Converter.CreateOpenXmlElement<DXW.FootnoteLayoutLikeWord8>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ShapeLayoutLikeWord8>();
      if (element != null)
        return ShapeLayoutLikeWord8Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ShapeLayoutLikeWord8>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeLayoutLikeWord8Converter.CreateOpenXmlElement<DXW.ShapeLayoutLikeWord8>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AlignTablesRowByRow>();
      if (element != null)
        return AlignTablesRowByRowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AlignTablesRowByRow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlignTablesRowByRowConverter.CreateOpenXmlElement<DXW.AlignTablesRowByRow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ForgetLastTabAlignment>();
      if (element != null)
        return ForgetLastTabAlignmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ForgetLastTabAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForgetLastTabAlignmentConverter.CreateOpenXmlElement<DXW.ForgetLastTabAlignment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AdjustLineHeightInTable>();
      if (element != null)
        return AdjustLineHeightInTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AdjustLineHeightInTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustLineHeightInTableConverter.CreateOpenXmlElement<DXW.AdjustLineHeightInTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AutoSpaceLikeWord95>();
      if (element != null)
        return AutoSpaceLikeWord95Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoSpaceLikeWord95>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoSpaceLikeWord95Converter.CreateOpenXmlElement<DXW.AutoSpaceLikeWord95>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NoSpaceRaiseLower>();
      if (element != null)
        return NoSpaceRaiseLowerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoSpaceRaiseLower>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoSpaceRaiseLowerConverter.CreateOpenXmlElement<DXW.NoSpaceRaiseLower>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>();
      if (element != null)
        return DoNotUseHTMLParagraphAutoSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotUseHTMLParagraphAutoSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotUseHTMLParagraphAutoSpacingConverter.CreateOpenXmlElement<DXW.DoNotUseHTMLParagraphAutoSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LayoutRawTableWidth>();
      if (element != null)
        return LayoutRawTableWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LayoutRawTableWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutRawTableWidthConverter.CreateOpenXmlElement<DXW.LayoutRawTableWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseWord97LineBreakRules>();
      if (element != null)
        return UseWord97LineBreakRulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseWord97LineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseWord97LineBreakRulesConverter.CreateOpenXmlElement<DXW.UseWord97LineBreakRules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotBreakWrappedTables>();
      if (element != null)
        return DoNotBreakWrappedTablesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotBreakWrappedTables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotBreakWrappedTablesConverter.CreateOpenXmlElement<DXW.DoNotBreakWrappedTables>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotSnapToGridInCell>();
      if (element != null)
        return DoNotSnapToGridInCellConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotSnapToGridInCell>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotSnapToGridInCellConverter.CreateOpenXmlElement<DXW.DoNotSnapToGridInCell>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>();
      if (element != null)
        return SelectFieldWithFirstOrLastCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SelectFieldWithFirstOrLastChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SelectFieldWithFirstOrLastCharConverter.CreateOpenXmlElement<DXW.SelectFieldWithFirstOrLastChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ApplyBreakingRules>();
      if (element != null)
        return ApplyBreakingRulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ApplyBreakingRules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplyBreakingRulesConverter.CreateOpenXmlElement<DXW.ApplyBreakingRules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>();
      if (element != null)
        return DoNotWrapTextWithPunctuationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotWrapTextWithPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotWrapTextWithPunctuationConverter.CreateOpenXmlElement<DXW.DoNotWrapTextWithPunctuation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>();
      if (element != null)
        return DoNotUseEastAsianBreakRulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotUseEastAsianBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotUseEastAsianBreakRulesConverter.CreateOpenXmlElement<DXW.DoNotUseEastAsianBreakRules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseWord2002TableStyleRules>();
      if (element != null)
        return UseWord2002TableStyleRulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseWord2002TableStyleRules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseWord2002TableStyleRulesConverter.CreateOpenXmlElement<DXW.UseWord2002TableStyleRules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.GrowAutofit>();
      if (element != null)
        return GrowAutofitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.GrowAutofit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GrowAutofitConverter.CreateOpenXmlElement<DXW.GrowAutofit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseFarEastLayout>();
      if (element != null)
        return UseFarEastLayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseFarEastLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseFarEastLayoutConverter.CreateOpenXmlElement<DXW.UseFarEastLayout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseNormalStyleForList>();
      if (element != null)
        return UseNormalStyleForListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseNormalStyleForList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseNormalStyleForListConverter.CreateOpenXmlElement<DXW.UseNormalStyleForList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>();
      if (element != null)
        return DoNotUseIndentAsNumberingTabStopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotUseIndentAsNumberingTabStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotUseIndentAsNumberingTabStopConverter.CreateOpenXmlElement<DXW.DoNotUseIndentAsNumberingTabStop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>();
      if (element != null)
        return UseAltKinsokuLineBreakRulesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseAltKinsokuLineBreakRules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseAltKinsokuLineBreakRulesConverter.CreateOpenXmlElement<DXW.UseAltKinsokuLineBreakRules>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>();
      if (element != null)
        return AllowSpaceOfSameStyleInTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AllowSpaceOfSameStyleInTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AllowSpaceOfSameStyleInTableConverter.CreateOpenXmlElement<DXW.AllowSpaceOfSameStyleInTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotSuppressIndentation>();
      if (element != null)
        return DoNotSuppressIndentationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotSuppressIndentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotSuppressIndentationConverter.CreateOpenXmlElement<DXW.DoNotSuppressIndentation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotAutofitConstrainedTables>();
      if (element != null)
        return DoNotAutofitConstrainedTablesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotAutofitConstrainedTables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotAutofitConstrainedTablesConverter.CreateOpenXmlElement<DXW.DoNotAutofitConstrainedTables>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>();
      if (element != null)
        return AutofitToFirstFixedWidthCellConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutofitToFirstFixedWidthCell>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutofitToFirstFixedWidthCellConverter.CreateOpenXmlElement<DXW.AutofitToFirstFixedWidthCell>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UnderlineTabInNumberingList>();
      if (element != null)
        return UnderlineTabInNumberingListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UnderlineTabInNumberingList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineTabInNumberingListConverter.CreateOpenXmlElement<DXW.UnderlineTabInNumberingList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DisplayHangulFixedWidth>();
      if (element != null)
        return DisplayHangulFixedWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DisplayHangulFixedWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayHangulFixedWidthConverter.CreateOpenXmlElement<DXW.DisplayHangulFixedWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>();
      if (element != null)
        return SplitPageBreakAndParagraphMarkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SplitPageBreakAndParagraphMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitPageBreakAndParagraphMarkConverter.CreateOpenXmlElement<DXW.SplitPageBreakAndParagraphMark>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>();
      if (element != null)
        return DoNotVerticallyAlignCellWithShapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotVerticallyAlignCellWithShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotVerticallyAlignCellWithShapeConverter.CreateOpenXmlElement<DXW.DoNotVerticallyAlignCellWithShape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>();
      if (element != null)
        return DoNotBreakConstrainedForcedTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotBreakConstrainedForcedTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotBreakConstrainedForcedTableConverter.CreateOpenXmlElement<DXW.DoNotBreakConstrainedForcedTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>();
      if (element != null)
        return DoNotVerticallyAlignInTextBoxConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotVerticallyAlignInTextBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotVerticallyAlignInTextBoxConverter.CreateOpenXmlElement<DXW.DoNotVerticallyAlignInTextBox>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UseAnsiKerningPairs>();
      if (element != null)
        return UseAnsiKerningPairsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseAnsiKerningPairs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseAnsiKerningPairsConverter.CreateOpenXmlElement<DXW.UseAnsiKerningPairs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.CachedColumnBalance>();
      if (element != null)
        return CachedColumnBalanceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CachedColumnBalance>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CachedColumnBalanceConverter.CreateOpenXmlElement<DXW.CachedColumnBalance>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
