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
      StringValueConverter.SetValue<DXM.MathFont>(_ExistingElement, value);
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
      return _Element?.GetObject<DMM.SmallFraction,DXM.SmallFraction>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SmallFraction,DXM.SmallFraction>(value);
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
      return _Element?.GetObject<DMM.DisplayDefaults,DXM.DisplayDefaults>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.DisplayDefaults,DXM.DisplayDefaults>(value);
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
      return _Element?.GetObject<DMM.LeftMargin,DXM.LeftMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.LeftMargin,DXM.LeftMargin>(value);
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
      return _Element?.GetObject<DMM.RightMargin,DXM.RightMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RightMargin,DXM.RightMargin>(value);
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
      return _Element?.GetObject<DMM.DefaultJustification,DXM.DefaultJustification>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.DefaultJustification,DXM.DefaultJustification>(value);
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
      return _Element?.GetObject<DMM.PreSpacing,DXM.PreSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.PreSpacing,DXM.PreSpacing>(value);
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
      return _Element?.GetObject<DMM.PostSpacing,DXM.PostSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.PostSpacing,DXM.PostSpacing>(value);
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
      return _Element?.GetObject<DMM.InterSpacing,DXM.InterSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.InterSpacing,DXM.InterSpacing>(value);
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
      return _Element?.GetObject<DMM.IntraSpacing,DXM.IntraSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.IntraSpacing,DXM.IntraSpacing>(value);
    }
  }
  
  [DataMember]
  public DMM.WrapIndent? WrapIndent
  {
    get
    {
      return _Element?.GetObject<DMM.WrapIndent,DXM.WrapIndent>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.WrapIndent,DXM.WrapIndent>(value);
    }
  }
  
  [DataMember]
  public DMM.WrapRight? WrapRight
  {
    get
    {
      return _Element?.GetObject<DMM.WrapRight,DXM.WrapRight>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.WrapRight,DXM.WrapRight>(value);
    }
  }
  
  [DataMember]
  public DMM.IntegralLimitLocation? IntegralLimitLocation
  {
    get
    {
      return _Element?.GetObject<DMM.IntegralLimitLocation,DXM.IntegralLimitLocation>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.IntegralLimitLocation,DXM.IntegralLimitLocation>(value);
    }
  }
  
  [DataMember]
  public DMM.NaryLimitLocation? NaryLimitLocation
  {
    get
    {
      return _Element?.GetObject<DMM.NaryLimitLocation,DXM.NaryLimitLocation>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.NaryLimitLocation,DXM.NaryLimitLocation>(value);
    }
  }
  
}
