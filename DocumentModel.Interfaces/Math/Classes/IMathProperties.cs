namespace DocumentModel.Math;
/// <summary>
///   This element specifies the document-level properties for all math in the document.
/// </summary>
public interface IMathProperties: IModelElement
{
  /// <summary>
  ///   Specifies the default math font to be used in the document. 
  ///   If this element is omitted, font substitution (§17.8.2) should be used 
  ///   to determine the most appropriate font for use throughout the document.  
  /// </summary>
  public string? MathFont { get; set; }
  /// <summary>
  ///   This element specifies how binary operators are treated when they coincide with a line break. 
  ///   If this element is omitted, the line break occurs before the binary operator. 
  ///   That is, the binary operator is the first element on the wrapped line.
  /// </summary>
  public BreakBinaryOperatorKind? BreakBinary { get; set; }
  /// <summary>
  ///   Specifies how the subtraction operator is treated when it coincides with a line break, 
  ///   when brkBin is set to repeat. 
  ///   If this element is omitted, the subtraction operator is repeated before and after the break.
  /// </summary>
  public BreakBinarySubtractionKind? BreakBinarySubtraction { get; set; }
  /// <summary>
  ///   Specifies a reduced fraction size display math, such that the numerator and denominator 
  ///   are written in script size instead of at the size of regular text.
  ///   When the element is absent, the default value of the option is 0 meaning that this option is not applied.  
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this option is applied.
  /// </summary>
  public bool? SmallFraction { get; set; }
  /// <summary>
  ///   Specifies the document-level property to overwrite paragraph settings for mathematical text. 
  ///   When omitted, this element is set to 1 or true and special math settings are applied. 
  ///   Whether the element is absent or present without the val attribute, 
  ///   the default of the val attribute is 1 meaning that this option is applied.
  /// </summary>
  public bool? DisplayDefaults { get; set; }
  /// <summary>
  ///   Specifies the left margin for math, in twips. If this element is omitted, no left margin is used. 
  ///   In other words, when the element is absent, the default value of the option is 0.  
  ///   When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch). 
  ///   Math margins are added to the paragraph settings for margins. 
  ///   If the sum of lMargin and rMargin exceed the width available, lMargin should be ignored. 
  /// </summary>
  public ITwips? LeftMargin { get; set; }
  /// <summary>
  ///   Specifies the right margin for math, in twips. If this element is omitted, no right margin is used. 
  ///   In other words, when the element is absent, the default value of the option is 0. 
  ///   When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
  ///   Math margins are added to the paragraph settings for margins. 
  ///   If the sum of lMargin and rMargin exceed the width available, lMargin should be ignored. 
  ///   If rMargin exceeds the width available, a default indent of 1440 twips should be used. 
  /// </summary>
  public ITwips? RightMargin { get; set; }
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
  public JustificationKind? DefaultJustification { get; set; }
  /// <summary>
  ///   Specifies the spacing before a math paragraph, in twips. 
  ///   If this element is omitted, no spacing is applied before the paragraph. 
  /// </summary>
  public ITwips? PreSpacing { get; set; }
  /// <summary>
  ///   Specifies the spacing after a math paragraph, in twips. 
  ///   If this element is omitted, no spacing is applied after the paragraph.
  /// </summary>
  public ITwips? PostSpacing { get; set; }
  /// <summary>
  ///   Specifies spacing between equations, expressions, or other instances of mathematical text within a display math paragraph, in twips.
  /// </summary>
  public ITwips? InterSpacing { get; set; }
  /// <summary>
  ///   Specifies the spacing between adjacent display math paragraphs, in twips. 
  ///   If this element is omitted, no spacing is applied between adjacent math paragraphs..
  /// </summary>
  public ITwips? IntraSpacing { get; set; }
  /// <summary>
  ///   Specifies the indent of the wrapped line of an instance of mathematical text. 
  ///   The line or lines of a wrapped instance of mathematical text after the line break 
  ///   can either be indented by a specified amount from the left margin, or right aligned. 
  ///   The default indent is 1". In other words, whether the element is absent or present without the val attribute, 
  ///   the default of the val attribute is 1440 twips (or 1 inch). 
  /// </summary>
  public ITwips? WrapIndent { get; set; }
  /// <summary>
  ///   Specifies the right justification of the wrapped line of an instance of mathematical text. 
  ///   The line or lines of a wrapped instance of mathematical text after the line break 
  ///   can either be indented by a specified amount from the left margin, or right aligned. 
  ///   If this element is present, the continuation is right aligned. 
  ///   When the element is absent, the default value of the option is 0 meaning that this option is not applied. 
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this option is applied.
  /// </summary>
  public bool? WrapRight { get; set; }
  /// <summary>
  ///   Specifies the document setting for the default placement of integral limits, 
  ///   when converted from a linear form to a two-dimensional output (professional form). 
  ///   Limits can be either centered above and below the integral, or positioned just to the right of the operator.
  /// </summary>
  public LimitLocationKind? IntegralLimitLocation { get; set; }
  /// <summary>
  ///   Specifies the location of limits in n-ary operators. 
  ///   Limits can be either centered above and below the n-ary operator, or positioned just to the right of the operator.
  /// </summary>
  public LimitLocationKind? NaryLimitLocation { get; set; }
}