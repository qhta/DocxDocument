namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of paragraph properties which shall be applied to the contents of the parent paragraph after all style/numbering/table properties have been applied to the text. These properties are defined as direct formatting, since they are directly applied to the paragraph and supersede any formatting from styles.
/// </summary>
public partial class ParagraphProperties: ModelElement<DXW.ParagraphProperties>
{
  public ParagraphProperties(): base(){ }
  
  public ParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphProperties(DXW.ParagraphProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ParagraphStyleId.
  /// </summary>
  [DataMember]
  public DMW.ParagraphStyleId? ParagraphStyleId
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphStyleId,DXW.ParagraphStyleId>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphStyleId,DXW.ParagraphStyleId>(value);
    }
  }
  
  
  /// <summary>
  ///   KeepNext.
  /// </summary>
  [DataMember]
  public DMW.KeepNext? KeepNext
  {
    get
    {
      return _Element?.GetObject<DMW.KeepNext,DXW.KeepNext>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.KeepNext,DXW.KeepNext>(value);
    }
  }
  
  
  /// <summary>
  ///   KeepLines.
  /// </summary>
  [DataMember]
  public DMW.KeepLines? KeepLines
  {
    get
    {
      return _Element?.GetObject<DMW.KeepLines,DXW.KeepLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.KeepLines,DXW.KeepLines>(value);
    }
  }
  
  
  /// <summary>
  ///   PageBreakBefore.
  /// </summary>
  [DataMember]
  public DMW.PageBreakBefore? PageBreakBefore
  {
    get
    {
      return _Element?.GetObject<DMW.PageBreakBefore,DXW.PageBreakBefore>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PageBreakBefore,DXW.PageBreakBefore>(value);
    }
  }
  
  
  /// <summary>
  ///   FrameProperties.
  /// </summary>
  [DataMember]
  public DMW.FrameProperties? FrameProperties
  {
    get
    {
      return _Element?.GetObject<DMW.FrameProperties,DXW.FrameProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FrameProperties,DXW.FrameProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   WidowControl.
  /// </summary>
  [DataMember]
  public DMW.WidowControl? WidowControl
  {
    get
    {
      return _Element?.GetObject<DMW.WidowControl,DXW.WidowControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WidowControl,DXW.WidowControl>(value);
    }
  }
  
  
  /// <summary>
  ///   NumberingProperties.
  /// </summary>
  [DataMember]
  public DMW.NumberingProperties? NumberingProperties
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingProperties,DXW.NumberingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingProperties,DXW.NumberingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   SuppressLineNumbers.
  /// </summary>
  [DataMember]
  public DMW.SuppressLineNumbers? SuppressLineNumbers
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressLineNumbers,DXW.SuppressLineNumbers>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressLineNumbers,DXW.SuppressLineNumbers>(value);
    }
  }
  
  
  /// <summary>
  ///   ParagraphBorders.
  /// </summary>
  [DataMember]
  public DMW.ParagraphBorders? ParagraphBorders
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphBorders,DXW.ParagraphBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphBorders,DXW.ParagraphBorders>(value);
    }
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      return _Element?.GetObject<DMW.Shading,DXW.Shading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shading,DXW.Shading>(value);
    }
  }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  [DataMember]
  public DMW.Tabs? Tabs
  {
    get
    {
      return _Element?.GetObject<DMW.Tabs,DXW.Tabs>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Tabs,DXW.Tabs>(value);
    }
  }
  
  
  /// <summary>
  ///   SuppressAutoHyphens.
  /// </summary>
  [DataMember]
  public DMW.SuppressAutoHyphens? SuppressAutoHyphens
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressAutoHyphens,DXW.SuppressAutoHyphens>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressAutoHyphens,DXW.SuppressAutoHyphens>(value);
    }
  }
  
  
  /// <summary>
  ///   Kinsoku.
  /// </summary>
  [DataMember]
  public DMW.Kinsoku? Kinsoku
  {
    get
    {
      return _Element?.GetObject<DMW.Kinsoku,DXW.Kinsoku>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Kinsoku,DXW.Kinsoku>(value);
    }
  }
  
  
  /// <summary>
  ///   WordWrap.
  /// </summary>
  [DataMember]
  public DMW.WordWrap? WordWrap
  {
    get
    {
      return _Element?.GetObject<DMW.WordWrap,DXW.WordWrap>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WordWrap,DXW.WordWrap>(value);
    }
  }
  
  
  /// <summary>
  ///   OverflowPunctuation.
  /// </summary>
  [DataMember]
  public DMW.OverflowPunctuation? OverflowPunctuation
  {
    get
    {
      return _Element?.GetObject<DMW.OverflowPunctuation,DXW.OverflowPunctuation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.OverflowPunctuation,DXW.OverflowPunctuation>(value);
    }
  }
  
  
  /// <summary>
  ///   TopLinePunctuation.
  /// </summary>
  [DataMember]
  public DMW.TopLinePunctuation? TopLinePunctuation
  {
    get
    {
      return _Element?.GetObject<DMW.TopLinePunctuation,DXW.TopLinePunctuation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopLinePunctuation,DXW.TopLinePunctuation>(value);
    }
  }
  
  
  /// <summary>
  ///   AutoSpaceDE.
  /// </summary>
  [DataMember]
  public DMW.AutoSpaceDE? AutoSpaceDE
  {
    get
    {
      return _Element?.GetObject<DMW.AutoSpaceDE,DXW.AutoSpaceDE>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoSpaceDE,DXW.AutoSpaceDE>(value);
    }
  }
  
  
  /// <summary>
  ///   AutoSpaceDN.
  /// </summary>
  [DataMember]
  public DMW.AutoSpaceDN? AutoSpaceDN
  {
    get
    {
      return _Element?.GetObject<DMW.AutoSpaceDN,DXW.AutoSpaceDN>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoSpaceDN,DXW.AutoSpaceDN>(value);
    }
  }
  
  
  /// <summary>
  ///   BiDi.
  /// </summary>
  [DataMember]
  public DMW.BiDi? BiDi
  {
    get
    {
      return _Element?.GetObject<DMW.BiDi,DXW.BiDi>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BiDi,DXW.BiDi>(value);
    }
  }
  
  
  /// <summary>
  ///   AdjustRightIndent.
  /// </summary>
  [DataMember]
  public DMW.AdjustRightIndent? AdjustRightIndent
  {
    get
    {
      return _Element?.GetObject<DMW.AdjustRightIndent,DXW.AdjustRightIndent>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AdjustRightIndent,DXW.AdjustRightIndent>(value);
    }
  }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  [DataMember]
  public DMW.SnapToGrid? SnapToGrid
  {
    get
    {
      return _Element?.GetObject<DMW.SnapToGrid,DXW.SnapToGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SnapToGrid,DXW.SnapToGrid>(value);
    }
  }
  
  
  /// <summary>
  ///   SpacingBetweenLines.
  /// </summary>
  [DataMember]
  public DMW.SpacingBetweenLines? SpacingBetweenLines
  {
    get
    {
      return _Element?.GetObject<DMW.SpacingBetweenLines,DXW.SpacingBetweenLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SpacingBetweenLines,DXW.SpacingBetweenLines>(value);
    }
  }
  
  
  /// <summary>
  ///   Indentation.
  /// </summary>
  [DataMember]
  public DMW.Indentation? Indentation
  {
    get
    {
      return _Element?.GetObject<DMW.Indentation,DXW.Indentation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Indentation,DXW.Indentation>(value);
    }
  }
  
  
  /// <summary>
  ///   ContextualSpacing.
  /// </summary>
  [DataMember]
  public DMW.ContextualSpacing? ContextualSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.ContextualSpacing,DXW.ContextualSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ContextualSpacing,DXW.ContextualSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   MirrorIndents.
  /// </summary>
  [DataMember]
  public DMW.MirrorIndents? MirrorIndents
  {
    get
    {
      return _Element?.GetObject<DMW.MirrorIndents,DXW.MirrorIndents>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MirrorIndents,DXW.MirrorIndents>(value);
    }
  }
  
  
  /// <summary>
  ///   SuppressOverlap.
  /// </summary>
  [DataMember]
  public DMW.SuppressOverlap? SuppressOverlap
  {
    get
    {
      return _Element?.GetObject<DMW.SuppressOverlap,DXW.SuppressOverlap>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SuppressOverlap,DXW.SuppressOverlap>(value);
    }
  }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [DataMember]
  public DMW.JustificationKind? Justification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(_ExistingElement.GetFirstChild<DXW.Justification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Justification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(itemElement, (DMW.JustificationKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Justification, DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>((DMW.JustificationKind)value));
    }
  }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  [DataMember]
  public DMW.TextDirectionKind? TextDirection
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(_ExistingElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextDirection>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
    }
  }
  
  
  /// <summary>
  ///   TextAlignment.
  /// </summary>
  [DataMember]
  public DMW.VerticalTextAlignmentKind? TextAlignment
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextAlignment>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(itemElement, (DMW.VerticalTextAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>((DMW.VerticalTextAlignmentKind)value));
    }
  }
  
  
  /// <summary>
  ///   TextBoxTightWrap.
  /// </summary>
  [DataMember]
  public DMW.TextBoxTightWrapKind? TextBoxTightWrap
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(_ExistingElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextBoxTightWrap>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(itemElement, (DMW.TextBoxTightWrapKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxTightWrap, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>((DMW.TextBoxTightWrapKind)value));
    }
  }
  
  
  /// <summary>
  ///   OutlineLevel.
  /// </summary>
  [DataMember]
  public DMW.OutlineLevel? OutlineLevel
  {
    get
    {
      return _Element?.GetObject<DMW.OutlineLevel,DXW.OutlineLevel>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.OutlineLevel,DXW.OutlineLevel>(value);
    }
  }
  
  
  /// <summary>
  ///   DivId.
  /// </summary>
  [DataMember]
  public String? DivId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.DivId>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.DivId>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  [DataMember]
  public DMW.ConditionalFormatStyle? ConditionalFormatStyle
  {
    get
    {
      return _Element?.GetObject<DMW.ConditionalFormatStyle,DXW.ConditionalFormatStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ConditionalFormatStyle,DXW.ConditionalFormatStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   Run Properties for the Paragraph Mark.
  /// </summary>
  [DataMember]
  public DMW.ParagraphMarkRunProperties? ParagraphMarkRunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphMarkRunProperties,DXW.ParagraphMarkRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphMarkRunProperties,DXW.ParagraphMarkRunProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Section Properties.
  /// </summary>
  [DataMember]
  public DMW.SectionProperties? SectionProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SectionProperties,DXW.SectionProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SectionProperties,DXW.SectionProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ParagraphPropertiesChange.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesChange? ParagraphPropertiesChange
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphPropertiesChange,DXW.ParagraphPropertiesChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphPropertiesChange,DXW.ParagraphPropertiesChange>(value);
    }
  }
  
}
