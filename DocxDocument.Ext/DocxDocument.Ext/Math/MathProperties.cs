namespace DocumentModel.Math;

/// <summary>
///  This class specifies the document-level properties for all math in the document. 
/// </summary>
public class MathProperties : ModelElement<DXM.MathProperties>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public MathProperties(): base(){ }

  /// <summary>
  /// Constructor with any OpenXmlElement parameter.
  /// </summary>
  /// <param name="openXmlElement"></param>
  public MathProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  /// <summary>
  /// Constructor with OpenXml MathProperties parameter
  /// </summary>
  /// <param name="openXmlMathProperties"></param>
  public MathProperties(DXM.MathProperties openXmlMathProperties): base(openXmlMathProperties) { } 

  /// <summary>
  /// This element specifies how binary operators are treated when they coincide with a line break. 
  /// If this element is omitted, the line break occurs before the binary operator. 
  /// That is, the binary operator is the first element on the wrapped line.
  /// </summary>
  [DataMember]
  public DMM.BreakBinaryOperatorKind? BreakBinary
  {
    get => _Element?.GetEnumVal<DMM.BreakBinaryOperatorKind, DXM.BreakBinary>();
    set => _ExistingElement.SetEnumVal<DMM.BreakBinaryOperatorKind, DXM.BreakBinaryOperatorValues, DXM.BreakBinary>(value);
  }

  /// <summary>
  /// This element specifies how the subtraction operator is treated when it coincides with a line break, when brkBin is set to repeat. 
  /// If this element is omitted, the subtraction operator is repeated before and after the break.
  /// </summary>
  [DataMember]
  public DMM.BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get => _Element?.GetEnumVal<DMM.BreakBinarySubtractionKind, DXM.BreakBinarySubtraction>();
    set => _ExistingElement.SetEnumVal<DMM.BreakBinarySubtractionKind, DXM.BreakBinarySubtractionValues, DXM.BreakBinarySubtraction>(value);
  }

  /// <summary>
  /// This element specifies the default math font to be used in the document. 
  /// If this element is omitted, font substitution (§17.8.2) should be used to determine the most appropriate font for use throughout the document.
  /// </summary>
  [DataMember]
  public string? MathFont
  {
    get => _Element?.GetStringVal<DXM.MathFont>();
    set => _ExistingElement.SetStringVal<DXM.MathFont>(value);
  }

  /// <summary>
  /// This element specifies a reduced fraction size display math, such that the numerator and denominator are written in script size 
  /// instead of at the size of regular text.
  /// When the element is absent, the default value of the option is 0 meaning that this option is not applied.
  /// When the element is present and the val attribute is absent, the default of the val attribute is 1 meaning that this option is applied.
  /// </summary>
  [DataMember]
  public bool? SmallFraction
  {
    get => _Element?.GetBoolVal<DXM.SmallFraction>();
    set => _ExistingElement.SetBoolVal<DXM.SmallFraction>(value);
  }

  /// <summary>
  /// This element specifies the document-level property to overwrite paragraph settings for mathematical text. 
  /// When omitted, this element is set to 1 or true and special math settings are applied. 
  /// Whether the element is absent or present without the val attribute, 
  /// the default of the val attribute is 1 meaning that this option is applied.
  /// </summary>
  [DataMember]
  public bool? DisplayDefaults
  {
    get => _Element?.GetBoolVal<DXM.DisplayDefaults>();
    set => _ExistingElement.SetBoolVal<DXM.DisplayDefaults>(value);
  }

  /// <summary>
  /// This element specifies the left margin for math, in twips. 
  /// If this element is omitted, no left margin is used. 
  /// In other words, when the element is absent, the default value of the option is 0.
  /// When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
  /// </summary>
  [DataMember]
  public Twips? LeftMargin
  {
    get => _Element?.GetTwipsVal<DXM.LeftMargin>();
    set => _ExistingElement.SetTwipsVal<DXM.LeftMargin>(value);
  }

  /// <summary>
  /// This element specifies the right margin for math, in twips. 
  /// If this element is omitted, no right margin is used. 
  /// In other words, when the element is absent, the default value of the option is 0.
  /// When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
  /// Math margins are added to the paragraph settings for margins. 
  /// If the sum of lMargin and rMargin exceed the width available, lMargin should be ignored. I
  /// f rMargin exceeds the width available, a default indent of 1440 twips should be used. 
  /// </summary>
  [DataMember]
  public Twips? RightMargin
  {
    get => _Element?.GetTwipsVal<DXM.RightMargin>();
    set => _ExistingElement.SetTwipsVal<DXM.RightMargin>(value);
  }

  /// <summary>
  /// This element specifies the default justification of display math, at the document level. 
  /// ndividual instances of mathematical text can overrule the default setting. 
  /// If this element is omitted, the default justification is centerGroup. 
  /// Whether the element is absent or present without the val attribute, the default of the val attribute is centerGroup.
  /// <para>
  /// Display math can be left justified, right justified, centered, or centered as a group. 
  /// When display math is centered as a group, the mathematical text is left aligned within a block, 
  /// and the entire block is centered with respect to column margins. 
  /// If this element is omitted, the mathematical text is centered as a group.
  /// </para>
  /// </summary>
  [DataMember]
  public DMM.JustificationKind? DefaultJustification
  {
    get => _Element?.GetEnumVal<DMM.JustificationKind, DXM.DefaultJustification>();
    set => _ExistingElement.SetEnumVal<DMM.JustificationKind, DXM.JustificationValues, DXM.DefaultJustification>(value);
  }

  /// <summary>
  /// This element specifies the spacing before a math paragraph, in twips. 
  /// </summary>
  [DataMember]
  public Twips? PreSpacing
  {
    get => _Element?.GetTwipsVal<DXM.PreSpacing>();
    set => _ExistingElement.SetTwipsVal<DXM.PreSpacing>(value);
  }

  /// <summary>
  /// This element specifies the spacing after a math paragraph, in twips. 
  /// </summary>
  [DataMember]
  public Twips? PostSpacing
  {
    get => _Element?.GetTwipsVal<DXM.PostSpacing>();
    set => _ExistingElement.SetTwipsVal<DXM.PostSpacing>(value);
  }

  /// <summary>
  /// This element specifies spacing between equations, expressions, 
  /// or other instances of mathematical text within a display math paragraph, in twips.
  /// </summary>
  [DataMember]
  public Twips? InterSpacing
  {
    get => _Element?.GetTwipsVal<DXM.InterSpacing>();
    set => _ExistingElement.SetTwipsVal<DXM.InterSpacing>(value);
  }

  /// <summary>
  /// This element specifies the spacing between adjacent display math paragraphs, in twips. 
  /// </summary>
  [DataMember]
  public Twips? IntraSpacing
  {
    get => _Element?.GetTwipsVal<DXM.IntraSpacing>();
    set => _ExistingElement.SetTwipsVal<DXM.IntraSpacing>(value);
  }

  /// <summary>
  /// This element specifies the document setting for the default placement of integral limits, 
  /// when converted from a linear form to a two-dimensional output (professional form). 
  /// Limits can be either centered above and below the integral, or positioned just to the right of the operator, as in:
  /// <para>
  /// When this integral object is written linearly, as , the placement of limits is ambiguous. 
  /// intLim is a document-level property that specifies the default positioning. When this element is omitted, 
  /// the default placement of integral limits is subSup (that is, the location of subscripts and superscripts, 
  /// or just to the right of the base or operator). Whether the element is absent or present without the val attribute, 
  /// the default of the val attribute is subSup. 
  /// </para>
  /// </summary>
  [DataMember]
  public DMM.LimitLocationKind? IntegralLimitLocation
  {
    get => _Element?.GetEnumVal<DMM.LimitLocationKind, DXM.IntegralLimitLocation>();
    set => _ExistingElement.SetEnumVal<DMM.LimitLocationKind, DXM.LimitLocationValues, DXM.IntegralLimitLocation>(value);
  }

  /// <summary>
  /// This element specifies the document setting for the default placement of n-ary limits other than integrals 
  /// (since integrals are most often written as subSup and other n-ary operators are most often written as undOvr), 
  /// when converted from a built down form to a two-dimensional output (professional form). 
  /// Limits can be either centered above and below the n-ary operator, or positioned just to the right of the operator, as in:
  /// <para>
  /// When this summation object is written in built down form, as in , for example, the placement of limits is ambiguous. 
  /// naryLim specifies this positioning. When this element is omitted, the default placement of n-ary limits is undOvr 
  /// (that is, the location of lower and upper limits). Whether the element is absent or present without the val attribute, 
  /// the default of the val attribute is undOvr. 
  /// </para>
  /// </summary>
  [DataMember]
  public DMM.LimitLocationKind? NaryLimitLocation
  {
    get => _Element?.GetEnumVal<DMM.LimitLocationKind, DXM.NaryLimitLocation>();
    set => _ExistingElement.SetEnumVal<DMM.LimitLocationKind, DXM.LimitLocationValues, DXM.NaryLimitLocation>(value);
  }

  /// <summary>
  /// This element specifies the right justification of the wrapped line of an instance of mathematical text. 
  /// The line or lines of a wrapped instance of mathematical text after the line break 
  /// can either be indented by a specified amount from the left margin, or right aligned. 
  /// If this element is present, the continuation is right aligned.
  /// </summary>
  [DataMember]
  public bool? WrapRight
  {
    get => _Element?.GetBoolVal<DXM.WrapRight>();
    set => _ExistingElement.SetBoolVal<DXM.WrapRight>(value);
  }

  /// <summary>
  /// This element specifies the indent of the wrapped line of an instance of mathematical text. 
  /// The line or lines of a wrapped instance of mathematical text after the line break 
  /// can either be indented by a specified amount from the left margin, or right aligned. 
  /// The default indent is 1". In other words, whether the element is absent or present without the val attribute, 
  /// the default of the val attribute is 1440 twips (or 1 inch).
  /// </summary>
  [DataMember]
  public Twips? WrapIndent
  {
    get => _Element?.GetTwipsVal<DXM.WrapIndent>();
    set => _ExistingElement.SetTwipsVal<DXM.WrapIndent>(value);
  }

}
