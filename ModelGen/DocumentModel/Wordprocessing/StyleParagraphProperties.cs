namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of paragraph properties which shall be applied to the paragraph.
/// </summary>
public partial class StyleParagraphProperties: ModelElement<DXW.StyleParagraphProperties>
{
  public StyleParagraphProperties(): base(){ }
  
  public StyleParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleParagraphProperties(DXW.StyleParagraphProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   KeepNext.
  /// </summary>
  [DataMember]
  public DMW.KeepNext? KeepNext
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.KeepNext>();
      if (element != null)
        return KeepNextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.KeepNext>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = KeepNextConverter.CreateOpenXmlElement<DXW.KeepNext>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.KeepLines>();
      if (element != null)
        return KeepLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.KeepLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = KeepLinesConverter.CreateOpenXmlElement<DXW.KeepLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PageBreakBefore>();
      if (element != null)
        return PageBreakBeforeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PageBreakBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageBreakBeforeConverter.CreateOpenXmlElement<DXW.PageBreakBefore>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.FrameProperties>();
      if (element != null)
        return FramePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramePropertiesConverter.CreateOpenXmlElement<DXW.FrameProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WidowControl>();
      if (element != null)
        return WidowControlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WidowControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WidowControlConverter.CreateOpenXmlElement<DXW.WidowControl>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NumberingProperties>();
      if (element != null)
        return NumberingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingPropertiesConverter.CreateOpenXmlElement<DXW.NumberingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressLineNumbers>();
      if (element != null)
        return SuppressLineNumbersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressLineNumbers>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressLineNumbersConverter.CreateOpenXmlElement<DXW.SuppressLineNumbers>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ParagraphBorders>();
      if (element != null)
        return ParagraphBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ParagraphBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphBordersConverter.CreateOpenXmlElement<DXW.ParagraphBorders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Shading>();
      if (element != null)
        return ShadingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Tabs>();
      if (element != null)
        return TabsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabsConverter.CreateOpenXmlElement<DXW.Tabs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressAutoHyphens>();
      if (element != null)
        return SuppressAutoHyphensConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressAutoHyphens>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressAutoHyphensConverter.CreateOpenXmlElement<DXW.SuppressAutoHyphens>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Kinsoku>();
      if (element != null)
        return KinsokuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Kinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = KinsokuConverter.CreateOpenXmlElement<DXW.Kinsoku>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WordWrap>();
      if (element != null)
        return WordWrapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WordWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WordWrapConverter.CreateOpenXmlElement<DXW.WordWrap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.OverflowPunctuation>();
      if (element != null)
        return OverflowPunctuationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.OverflowPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OverflowPunctuationConverter.CreateOpenXmlElement<DXW.OverflowPunctuation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TopLinePunctuation>();
      if (element != null)
        return TopLinePunctuationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TopLinePunctuation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopLinePunctuationConverter.CreateOpenXmlElement<DXW.TopLinePunctuation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AutoSpaceDE>();
      if (element != null)
        return AutoSpaceDEConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoSpaceDE>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoSpaceDEConverter.CreateOpenXmlElement<DXW.AutoSpaceDE>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AutoSpaceDN>();
      if (element != null)
        return AutoSpaceDNConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoSpaceDN>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoSpaceDNConverter.CreateOpenXmlElement<DXW.AutoSpaceDN>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BiDi>();
      if (element != null)
        return BiDiConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BiDiConverter.CreateOpenXmlElement<DXW.BiDi>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AdjustRightIndent>();
      if (element != null)
        return AdjustRightIndentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AdjustRightIndent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustRightIndentConverter.CreateOpenXmlElement<DXW.AdjustRightIndent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SnapToGrid>();
      if (element != null)
        return SnapToGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SnapToGridConverter.CreateOpenXmlElement<DXW.SnapToGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SpacingBetweenLines>();
      if (element != null)
        return SpacingBetweenLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SpacingBetweenLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpacingBetweenLinesConverter.CreateOpenXmlElement<DXW.SpacingBetweenLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Indentation>();
      if (element != null)
        return IndentationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Indentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IndentationConverter.CreateOpenXmlElement<DXW.Indentation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ContextualSpacing>();
      if (element != null)
        return ContextualSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ContextualSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextualSpacingConverter.CreateOpenXmlElement<DXW.ContextualSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MirrorIndents>();
      if (element != null)
        return MirrorIndentsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MirrorIndents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MirrorIndentsConverter.CreateOpenXmlElement<DXW.MirrorIndents>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SuppressOverlap>();
      if (element != null)
        return SuppressOverlapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SuppressOverlap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuppressOverlapConverter.CreateOpenXmlElement<DXW.SuppressOverlap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.OutlineLevel>();
      if (element != null)
        return OutlineLevelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.OutlineLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineLevelConverter.CreateOpenXmlElement<DXW.OutlineLevel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ParagraphPropertiesChange>();
      if (element != null)
        return ParagraphPropertiesChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ParagraphPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
