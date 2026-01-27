namespace DocumentModel.Math;
/// <summary>
///   This element specifies the document-level properties for all math in the document.
/// </summary>
[OpenXmlType(typeof(DXM.MathProperties))]
public partial class MathProperties : ModelElement<DXM.MathProperties>
{
 /// <summary>
 ///   Specifies the default math font to be used in the document. 
 ///   If this element is omitted, font substitution (§17.8.2) should be used 
 ///   to determine the most appropriate font for use throughout the document.  
 /// </summary>
 public string? MathFont { get => _MathFont; set => UpdateField(ref _MathFont, value, nameof(MathFont)); }

 private string? _MathFont;
 /// <summary>
 ///   This element specifies how binary operators are treated when they coincide with a line break. 
 ///   If this element is omitted, the line break occurs before the binary operator. 
 ///   That is, the binary operator is the first element on the wrapped line.
 /// </summary>
 public BreakBinaryOperatorKind? BreakBinary { get => _BreakBinary; set => UpdateField(ref _BreakBinary, value, nameof(BreakBinary)); }

 private BreakBinaryOperatorKind? _BreakBinary;
 /// <summary>
 ///   Specifies how the subtraction operator is treated when it coincides with a line break, 
 ///   when brkBin is set to repeat. 
 ///   If this element is omitted, the subtraction operator is repeated before and after the break.
 /// </summary>
 public BreakBinarySubtractionKind? BreakBinarySubtraction { get => _BreakBinarySubtraction; set => UpdateField(ref _BreakBinarySubtraction, value, nameof(BreakBinarySubtraction)); }

 private BreakBinarySubtractionKind? _BreakBinarySubtraction;
 /// <summary>
 ///   Specifies a reduced fraction size display math, such that the numerator and denominator 
 ///   are written in script size instead of at the size of regular text.
 ///   When the element is absent, the default value of the option is 0 meaning that this option is not applied.  
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this option is applied.
 /// </summary>
 public bool? SmallFraction { get => _SmallFraction; set => UpdateField(ref _SmallFraction, value, nameof(SmallFraction)); }

 private bool? _SmallFraction;
 /// <summary>
 ///   Specifies the document-level property to overwrite paragraph settings for mathematical text. 
 ///   When omitted, this element is set to 1 or true and special math settings are applied. 
 ///   Whether the element is absent or present without the val attribute, 
 ///   the default of the val attribute is 1 meaning that this option is applied.
 /// </summary>
 public bool? DisplayDefaults { get => _DisplayDefaults; set => UpdateField(ref _DisplayDefaults, value, nameof(DisplayDefaults)); }

 private bool? _DisplayDefaults;
 /// <summary>
 ///   Specifies the left margin for math, in twips. If this element is omitted, no left margin is used. 
 ///   In other words, when the element is absent, the default value of the option is 0.  
 ///   When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch). 
 ///   Math margins are added to the paragraph settings for margins. 
 ///   If the sum of lMargin and rMargin exceed the width available, lMargin should be ignored. 
 /// </summary>
 public Twips? LeftMargin { get => _LeftMargin; set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin)); }

 private Twips? _LeftMargin;
 /// <summary>
 ///   Specifies the right margin for math, in twips. If this element is omitted, no right margin is used. 
 ///   In other words, when the element is absent, the default value of the option is 0. 
 ///   When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
 ///   Math margins are added to the paragraph settings for margins. 
 ///   If the sum of lMargin and rMargin exceed the width available, lMargin should be ignored. 
 ///   If rMargin exceeds the width available, a default indent of 1440 twips should be used. 
 /// </summary>
 public Twips? RightMargin { get => _RightMargin; set => UpdateField(ref _RightMargin, value, nameof(RightMargin)); }

 private Twips? _RightMargin;
 /// <summary>
 ///   Specifies the default justification of display math, at the document level. 
 ///   Individual instances of mathematical text can overrule the default setting. 
 ///   If this element is omitted, the default justification is centerGroup. 
 ///   Whether the element is absent or present without the val attribute, the default of the val attribute is centerGroup. 
 ///   Display math can be left justified, right justified, centered, or centered as a group. 
 ///   When display math is centered as a group, the mathematical text is left aligned within a block, 
 ///   and the entire block is centered with respect to column margins. 
 ///   If this element is omitted, the mathematical text is centered as a group. 
 /// </summary>
 public JustificationKind? DefaultJustification { get => _DefaultJustification; set => UpdateField(ref _DefaultJustification, value, nameof(DefaultJustification)); }

 private JustificationKind? _DefaultJustification;
 /// <summary>
 ///   Specifies the spacing before a math paragraph, in twips. 
 ///   If this element is omitted, no spacing is applied before the paragraph. 
 /// </summary>
 public Twips? PreSpacing { get => _PreSpacing; set => UpdateField(ref _PreSpacing, value, nameof(PreSpacing)); }

 private Twips? _PreSpacing;
 /// <summary>
 ///   Specifies the spacing after a math paragraph, in twips. 
 ///   If this element is omitted, no spacing is applied after the paragraph.
 /// </summary>
 public Twips? PostSpacing { get => _PostSpacing; set => UpdateField(ref _PostSpacing, value, nameof(PostSpacing)); }

 private Twips? _PostSpacing;
 /// <summary>
 ///   Specifies spacing between equations, expressions, or other instances of mathematical text within a display math paragraph, in twips.
 /// </summary>
 public Twips? InterSpacing { get => _InterSpacing; set => UpdateField(ref _InterSpacing, value, nameof(InterSpacing)); }

 private Twips? _InterSpacing;
 /// <summary>
 ///   Specifies the spacing between adjacent display math paragraphs, in twips. 
 ///   If this element is omitted, no spacing is applied between adjacent math paragraphs..
 /// </summary>
 public Twips? IntraSpacing { get => _IntraSpacing; set => UpdateField(ref _IntraSpacing, value, nameof(IntraSpacing)); }

 private Twips? _IntraSpacing;
 /// <summary>
 ///   Specifies the indent of the wrapped line of an instance of mathematical text. 
 ///   The line or lines of a wrapped instance of mathematical text after the line break 
 ///   can either be indented by a specified amount from the left margin, or right aligned. 
 ///   The default indent is 1". In other words, whether the element is absent or present without the val attribute, 
 ///   the default of the val attribute is 1440 twips (or 1 inch). 
 /// </summary>
 public Twips? WrapIndent { get => _WrapIndent; set => UpdateField(ref _WrapIndent, value, nameof(WrapIndent)); }

 private Twips? _WrapIndent;
 /// <summary>
 ///   Specifies the right justification of the wrapped line of an instance of mathematical text. 
 ///   The line or lines of a wrapped instance of mathematical text after the line break 
 ///   can either be indented by a specified amount from the left margin, or right aligned. 
 ///   If this element is present, the continuation is right aligned. 
 ///   When the element is absent, the default value of the option is 0 meaning that this option is not applied. 
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this option is applied.
 /// </summary>
 public bool? WrapRight { get => _WrapRight; set => UpdateField(ref _WrapRight, value, nameof(WrapRight)); }

 private bool? _WrapRight;
 /// <summary>
 ///   Specifies the document setting for the default placement of integral limits, 
 ///   when converted from a linear form to a two-dimensional output (professional form). 
 ///   Limits can be either centered above and below the integral, or positioned just to the right of the operator.
 /// </summary>
 public LimitLocationKind? IntegralLimitLocation { get => _IntegralLimitLocation; set => UpdateField(ref _IntegralLimitLocation, value, nameof(IntegralLimitLocation)); }

 private LimitLocationKind? _IntegralLimitLocation;
 /// <summary>
 ///   Specifies the location of limits in n-ary operators. 
 ///   Limits can be either centered above and below the n-ary operator, or positioned just to the right of the operator.
 /// </summary>
 public LimitLocationKind? NaryLimitLocation { get => _NaryLimitLocation; set => UpdateField(ref _NaryLimitLocation, value, nameof(NaryLimitLocation)); }

 private LimitLocationKind? _NaryLimitLocation;
}