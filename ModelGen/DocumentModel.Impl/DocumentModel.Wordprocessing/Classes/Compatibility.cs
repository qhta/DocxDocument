namespace DocumentModel.Wordprocessing;

/// <summary>
/// Compatibility Settings.
/// </summary>
public class CompatibilityImpl: ModelElementImpl, Compatibility
{
  public DocumentFormat.OpenXml.Wordprocessing.Compatibility? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Compatibility?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CompatibilityImpl(): base() {}
  
  public CompatibilityImpl(DocumentFormat.OpenXml.Wordprocessing.Compatibility openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public Boolean? UseSingleBorderForContiguousCells
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseSingleBorderForContiguousCells();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public Boolean? WordPerfectJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.WordPerfectJustification();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public Boolean? NoTabHangIndent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoTabHangIndent();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  public Boolean? NoLeading
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLeading>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLeading>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoLeading();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public Boolean? SpaceForUnderline
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SpaceForUnderline();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  public Boolean? NoColumnBalance
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoColumnBalance();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  public Boolean? BalanceSingleByteDoubleByteWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BalanceSingleByteDoubleByteWidth();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public Boolean? NoExtraLineSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoExtraLineSpacing();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public Boolean? DoNotLeaveBackslashAlone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotLeaveBackslashAlone();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  public Boolean? UnderlineTrailingSpaces
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UnderlineTrailingSpaces();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public Boolean? DoNotExpandShiftReturn
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotExpandShiftReturn();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  public Boolean? SpacingInWholePoints
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SpacingInWholePoints();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public Boolean? LineWrapLikeWord6
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.LineWrapLikeWord6();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  public Boolean? PrintBodyTextBeforeHeader
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintBodyTextBeforeHeader();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  public Boolean? PrintColorBlackWhite
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintColorBlackWhite();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Space width.
  /// </summary>
  public Boolean? WordPerfectSpaceWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.WordPerfectSpaceWidth();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  public Boolean? ShowBreaksInFrames
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ShowBreaksInFrames();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public Boolean? SubFontBySize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SubFontBySize>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SubFontBySize>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SubFontBySize();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public Boolean? SuppressBottomSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressBottomSpacing();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public Boolean? SuppressTopSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacing();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public Boolean? SuppressSpacingAtTopOfPage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingAtTopOfPage();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public Boolean? SuppressTopSpacingWordPerfect
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressTopSpacingWordPerfect();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public Boolean? SuppressSpacingBeforeAfterPageBreak
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressSpacingBeforeAfterPageBreak();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public Boolean? SwapBordersFacingPages
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SwapBordersFacingPages();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public Boolean? ConvertMailMergeEscape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ConvertMailMergeEscape();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public Boolean? TruncateFontHeightsLikeWordPerfect
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TruncateFontHeightsLikeWordPerfect();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public Boolean? MacWordSmallCaps
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MacWordSmallCaps();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  public Boolean? UsePrinterMetrics
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UsePrinterMetrics();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public Boolean? DoNotSuppressParagraphBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressParagraphBorders();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  public Boolean? WrapTrailSpaces
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.WrapTrailSpaces();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public Boolean? FootnoteLayoutLikeWord8
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FootnoteLayoutLikeWord8();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public Boolean? ShapeLayoutLikeWord8
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ShapeLayoutLikeWord8();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  public Boolean? AlignTablesRowByRow
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AlignTablesRowByRow();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public Boolean? ForgetLastTabAlignment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ForgetLastTabAlignment();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public Boolean? AdjustLineHeightInTable
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AdjustLineHeightInTable();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public Boolean? AutoSpaceLikeWord95
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceLikeWord95();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public Boolean? NoSpaceRaiseLower
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoSpaceRaiseLower();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public Boolean? DoNotUseHTMLParagraphAutoSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public Boolean? LayoutRawTableWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.LayoutRawTableWidth();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  public Boolean? LayoutTableRowsApart
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.LayoutTableRowsApart();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public Boolean? UseWord97LineBreakRules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseWord97LineBreakRules();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public Boolean? DoNotBreakWrappedTables
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotBreakWrappedTables();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public Boolean? DoNotSnapToGridInCell
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotSnapToGridInCell();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  public Boolean? SelectFieldWithFirstOrLastChar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SelectFieldWithFirstOrLastChar();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public Boolean? ApplyBreakingRules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ApplyBreakingRules();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public Boolean? DoNotWrapTextWithPunctuation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotWrapTextWithPunctuation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public Boolean? DoNotUseEastAsianBreakRules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseEastAsianBreakRules();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  public Boolean? UseWord2002TableStyleRules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseWord2002TableStyleRules();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public Boolean? GrowAutofit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GrowAutofit>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GrowAutofit>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.GrowAutofit();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public Boolean? UseFarEastLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseFarEastLayout();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public Boolean? UseNormalStyleForList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseNormalStyleForList();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public Boolean? DoNotUseIndentAsNumberingTabStop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public Boolean? UseAltKinsokuLineBreakRules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseAltKinsokuLineBreakRules();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public Boolean? AllowSpaceOfSameStyleInTable
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AllowSpaceOfSameStyleInTable();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public Boolean? DoNotSuppressIndentation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressIndentation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public Boolean? DoNotAutofitConstrainedTables
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotAutofitConstrainedTables();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public Boolean? AutofitToFirstFixedWidthCell
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutofitToFirstFixedWidthCell();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  public Boolean? UnderlineTabInNumberingList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UnderlineTabInNumberingList();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public Boolean? DisplayHangulFixedWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DisplayHangulFixedWidth();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public Boolean? SplitPageBreakAndParagraphMark
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SplitPageBreakAndParagraphMark();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public Boolean? DoNotVerticallyAlignCellWithShape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignCellWithShape();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public Boolean? DoNotBreakConstrainedForcedTable
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotBreakConstrainedForcedTable();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public Boolean? DoNotVerticallyAlignInTextBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotVerticallyAlignInTextBox();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public Boolean? UseAnsiKerningPairs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseAnsiKerningPairs();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public Boolean? CachedColumnBalance
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.CachedColumnBalance();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.CompatibilitySetting>? CompatibilitySettings
  {
    get
    {
      if (_CompatibilitySettings != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>()
            .Select(item => new DocumentModel.Wordprocessing.CompatibilitySettingImpl(item)).ToList();
          _CompatibilitySettings = new ObservableCollection<DocumentModel.Wordprocessing.CompatibilitySetting>(items);
        }
        else
          _CompatibilitySettings = new ObservableCollection<DocumentModel.Wordprocessing.CompatibilitySetting>();
        _CompatibilitySettings.CollectionChanged += _CompatibilitySettings_CollectionChanged;
      }
      return _CompatibilitySettings;
    }
    set
    {
      if (value != null && value != _CompatibilitySettings && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.CompatibilitySettingImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.CompatibilitySetting> observableCollection)
        _CompatibilitySettings = observableCollection;
      else if (value != null)
        _CompatibilitySettings = new ObservableCollection<DocumentModel.Wordprocessing.CompatibilitySetting>(value);
      else
       _CompatibilitySettings = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.CompatibilitySetting>? _CompatibilitySettings;
  
  private void _CompatibilitySettings_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.CompatibilitySettingImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.CompatibilitySettingImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
