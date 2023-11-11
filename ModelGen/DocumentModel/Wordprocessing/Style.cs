namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the definition of a single style within a WordprocessingML document. A style is a predefined set of table, numbering, paragraph, and/or character properties which can be applied to regions within a document.
/// </summary>
public partial class Style: ModelElement<DXW.Style>
{
  public Style(): base(){ }
  
  public Style(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Style(DXW.Style openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Style ID
  /// </summary>
  [DataMember]
  public String? StyleId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StyleId);
    }
    set
    {
      _ExistingElement.StyleId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default Style
  /// </summary>
  [DataMember]
  public Boolean? Default
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Default);
    }
    set
    {
      _ExistingElement.Default = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   User-Defined Style
  /// </summary>
  [DataMember]
  public Boolean? CustomStyle
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.CustomStyle);
    }
    set
    {
      _ExistingElement.CustomStyle = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  [DataMember]
  public String? StyleName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.StyleName>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.StyleName>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  [DataMember]
  public DMW.Aliases? Aliases
  {
    get
    {
      return _Element?.GetObject<DMW.Aliases,DXW.Aliases>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Aliases,DXW.Aliases>(value);
    }
  }
  
  
  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  [DataMember]
  public DMW.BasedOn? BasedOn
  {
    get
    {
      return _Element?.GetObject<DMW.BasedOn,DXW.BasedOn>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BasedOn,DXW.BasedOn>(value);
    }
  }
  
  
  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  [DataMember]
  public DMW.NextParagraphStyle? NextParagraphStyle
  {
    get
    {
      return _Element?.GetObject<DMW.NextParagraphStyle,DXW.NextParagraphStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NextParagraphStyle,DXW.NextParagraphStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  [DataMember]
  public DMW.LinkedStyle? LinkedStyle
  {
    get
    {
      return _Element?.GetObject<DMW.LinkedStyle,DXW.LinkedStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LinkedStyle,DXW.LinkedStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  [DataMember]
  public DMW.AutoRedefine? AutoRedefine
  {
    get
    {
      return _Element?.GetObject<DMW.AutoRedefine,DXW.AutoRedefine>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoRedefine,DXW.AutoRedefine>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  [DataMember]
  public DMW.StyleHidden? StyleHidden
  {
    get
    {
      return _Element?.GetObject<DMW.StyleHidden,DXW.StyleHidden>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleHidden,DXW.StyleHidden>(value);
    }
  }
  
  
  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  [DataMember]
  public Int32? UIPriority
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.UIPriority>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.UIPriority,System.Int32>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  [DataMember]
  public DMW.SemiHidden? SemiHidden
  {
    get
    {
      return _Element?.GetObject<DMW.SemiHidden,DXW.SemiHidden>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SemiHidden,DXW.SemiHidden>(value);
    }
  }
  
  
  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  [DataMember]
  public DMW.UnhideWhenUsed? UnhideWhenUsed
  {
    get
    {
      return _Element?.GetObject<DMW.UnhideWhenUsed,DXW.UnhideWhenUsed>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UnhideWhenUsed,DXW.UnhideWhenUsed>(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Style.
  /// </summary>
  [DataMember]
  public DMW.PrimaryStyle? PrimaryStyle
  {
    get
    {
      return _Element?.GetObject<DMW.PrimaryStyle,DXW.PrimaryStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrimaryStyle,DXW.PrimaryStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  [DataMember]
  public DMW.Locked? Locked
  {
    get
    {
      return _Element?.GetObject<DMW.Locked,DXW.Locked>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Locked,DXW.Locked>(value);
    }
  }
  
  
  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  [DataMember]
  public DMW.Personal? Personal
  {
    get
    {
      return _Element?.GetObject<DMW.Personal,DXW.Personal>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Personal,DXW.Personal>(value);
    }
  }
  
  
  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  [DataMember]
  public DMW.PersonalCompose? PersonalCompose
  {
    get
    {
      return _Element?.GetObject<DMW.PersonalCompose,DXW.PersonalCompose>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PersonalCompose,DXW.PersonalCompose>(value);
    }
  }
  
  
  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  [DataMember]
  public DMW.PersonalReply? PersonalReply
  {
    get
    {
      return _Element?.GetObject<DMW.PersonalReply,DXW.PersonalReply>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PersonalReply,DXW.PersonalReply>(value);
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  [DataMember]
  public HexInt? Rsid
  {
    get
    {
      return _Element?.GetObject<DMW.Rsid,DXW.Rsid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Rsid,DXW.Rsid>(value);
    }
  }
  
  
  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleParagraphProperties? StyleParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMW.StyleParagraphProperties,DXW.StyleParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleParagraphProperties,DXW.StyleParagraphProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleRunProperties? StyleRunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.StyleRunProperties,DXW.StyleRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleRunProperties,DXW.StyleRunProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleTableProperties? StyleTableProperties
  {
    get
    {
      return _Element?.GetObject<DMW.StyleTableProperties,DXW.StyleTableProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleTableProperties,DXW.StyleTableProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get
    {
      return _Element?.GetObject<DMW.TableStyleConditionalFormattingTableRowProperties,DXW.TableStyleConditionalFormattingTableRowProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleConditionalFormattingTableRowProperties,DXW.TableStyleConditionalFormattingTableRowProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleTableCellProperties? StyleTableCellProperties
  {
    get
    {
      return _Element?.GetObject<DMW.StyleTableCellProperties,DXW.StyleTableCellProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleTableCellProperties,DXW.StyleTableCellProperties>(value);
    }
  }
  
}
