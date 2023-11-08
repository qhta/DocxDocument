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
      StringValueConverter.SetValue<DXW.StyleName>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXW.Aliases>();
      if (element != null)
        return AliasesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Aliases>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AliasesConverter.CreateOpenXmlElement<DXW.Aliases>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BasedOn>();
      if (element != null)
        return BasedOnConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BasedOn>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BasedOnConverter.CreateOpenXmlElement<DXW.BasedOn>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NextParagraphStyle>();
      if (element != null)
        return NextParagraphStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NextParagraphStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NextParagraphStyleConverter.CreateOpenXmlElement<DXW.NextParagraphStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.LinkedStyle>();
      if (element != null)
        return LinkedStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LinkedStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinkedStyleConverter.CreateOpenXmlElement<DXW.LinkedStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AutoRedefine>();
      if (element != null)
        return AutoRedefineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoRedefine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoRedefineConverter.CreateOpenXmlElement<DXW.AutoRedefine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StyleHidden>();
      if (element != null)
        return StyleHiddenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleHidden>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleHiddenConverter.CreateOpenXmlElement<DXW.StyleHidden>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.UIPriority,System.Int32>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXW.SemiHidden>();
      if (element != null)
        return SemiHiddenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SemiHidden>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SemiHiddenConverter.CreateOpenXmlElement<DXW.SemiHidden>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.UnhideWhenUsed>();
      if (element != null)
        return UnhideWhenUsedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UnhideWhenUsed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnhideWhenUsedConverter.CreateOpenXmlElement<DXW.UnhideWhenUsed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrimaryStyle>();
      if (element != null)
        return PrimaryStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrimaryStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrimaryStyleConverter.CreateOpenXmlElement<DXW.PrimaryStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Locked>();
      if (element != null)
        return LockedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Locked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LockedConverter.CreateOpenXmlElement<DXW.Locked>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Personal>();
      if (element != null)
        return PersonalConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Personal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PersonalConverter.CreateOpenXmlElement<DXW.Personal>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PersonalCompose>();
      if (element != null)
        return PersonalComposeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PersonalCompose>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PersonalComposeConverter.CreateOpenXmlElement<DXW.PersonalCompose>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PersonalReply>();
      if (element != null)
        return PersonalReplyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PersonalReply>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PersonalReplyConverter.CreateOpenXmlElement<DXW.PersonalReply>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Rsid>();
      if (element != null)
        return RsidConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Rsid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RsidConverter.CreateOpenXmlElement<DXW.Rsid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StyleParagraphProperties>();
      if (element != null)
        return StyleParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StyleRunProperties>();
      if (element != null)
        return StyleRunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleRunPropertiesConverter.CreateOpenXmlElement<DXW.StyleRunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StyleTableProperties>();
      if (element != null)
        return StyleTablePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleTableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleTablePropertiesConverter.CreateOpenXmlElement<DXW.StyleTableProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
      if (element != null)
        return TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StyleTableCellProperties>();
      if (element != null)
        return StyleTableCellPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleTableCellPropertiesConverter.CreateOpenXmlElement<DXW.StyleTableCellProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
