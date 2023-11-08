namespace DocumentModel.Math;


/// <summary>
///   Math Properties.
/// </summary>
public partial class MathProperties: ModelElement<DXM.MathProperties>
{
  public MathProperties(): base(){ }
  
  public MathProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MathProperties(DXM.MathProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Math Font.
  /// </summary>
  [DataMember]
  public String? MathFont
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXM.MathFont>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXM.MathFont>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Break on Binary Operators.
  /// </summary>
  [DataMember]
  public DMM.BreakBinaryOperatorKind? BreakBinary
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>(_ExistingElement.GetFirstChild<DXM.BreakBinary>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BreakBinary>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>(itemElement, (DMM.BreakBinaryOperatorKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.BreakBinary, DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues, DMM.BreakBinaryOperatorKind>((DMM.BreakBinaryOperatorKind)value));
    }
  }
  
  
  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  [DataMember]
  public DMM.BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>(_ExistingElement.GetFirstChild<DXM.BreakBinarySubtraction>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BreakBinarySubtraction>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>(itemElement, (DMM.BreakBinarySubtractionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.BreakBinarySubtraction, DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues, DMM.BreakBinarySubtractionKind>((DMM.BreakBinarySubtractionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Small Fraction.
  /// </summary>
  [DataMember]
  public DMM.SmallFraction? SmallFraction
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SmallFraction>();
      if (element != null)
        return SmallFractionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SmallFraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SmallFractionConverter.CreateOpenXmlElement<DXM.SmallFraction>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  [DataMember]
  public DMM.DisplayDefaults? DisplayDefaults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.DisplayDefaults>();
      if (element != null)
        return DisplayDefaultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.DisplayDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayDefaultsConverter.CreateOpenXmlElement<DXM.DisplayDefaults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Left Margin.
  /// </summary>
  [DataMember]
  public DMM.LeftMargin? LeftMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.LeftMargin>();
      if (element != null)
        return LeftMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftMarginConverter.CreateOpenXmlElement<DXM.LeftMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Right Margin.
  /// </summary>
  [DataMember]
  public DMM.RightMargin? RightMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.RightMargin>();
      if (element != null)
        return RightMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightMarginConverter.CreateOpenXmlElement<DXM.RightMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Default Justification.
  /// </summary>
  [DataMember]
  public DMM.DefaultJustification? DefaultJustification
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.DefaultJustification>();
      if (element != null)
        return DefaultJustificationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.DefaultJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultJustificationConverter.CreateOpenXmlElement<DXM.DefaultJustification>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.PreSpacing? PreSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.PreSpacing>();
      if (element != null)
        return PreSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.PreSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreSpacingConverter.CreateOpenXmlElement<DXM.PreSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.PostSpacing? PostSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.PostSpacing>();
      if (element != null)
        return PostSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.PostSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PostSpacingConverter.CreateOpenXmlElement<DXM.PostSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.InterSpacing? InterSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.InterSpacing>();
      if (element != null)
        return InterSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.InterSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InterSpacingConverter.CreateOpenXmlElement<DXM.InterSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.IntraSpacing? IntraSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.IntraSpacing>();
      if (element != null)
        return IntraSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.IntraSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IntraSpacingConverter.CreateOpenXmlElement<DXM.IntraSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.WrapIndent? WrapIndent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.WrapIndent>();
      if (element != null)
        return WrapIndentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.WrapIndent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapIndentConverter.CreateOpenXmlElement<DXM.WrapIndent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.WrapRight? WrapRight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.WrapRight>();
      if (element != null)
        return WrapRightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.WrapRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapRightConverter.CreateOpenXmlElement<DXM.WrapRight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.IntegralLimitLocation? IntegralLimitLocation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.IntegralLimitLocation>();
      if (element != null)
        return IntegralLimitLocationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.IntegralLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IntegralLimitLocationConverter.CreateOpenXmlElement<DXM.IntegralLimitLocation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.NaryLimitLocation? NaryLimitLocation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.NaryLimitLocation>();
      if (element != null)
        return NaryLimitLocationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.NaryLimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NaryLimitLocationConverter.CreateOpenXmlElement<DXM.NaryLimitLocation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
