using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

public interface IMathProperties
{
  /// <summary> 
  /// This element specifies how binary operators are treated when they coincide with a line break.
  /// If this element is omitted, the line break occurs before the binary operator.
  /// That is, the binary operator is the first element on the wrapped line.
  ///</summary> 
  public BreakBinaryOperator? BreakBinary { get; set; }

  /// <summary> 
  /// This element specifies how the subtraction operator is treated when it coincides with a line break,
  /// when brkBin is set to repeat.
  /// If this element is omitted, the subtraction operator is repeated before and after the break.
  ///</summary> 
  public BreakBinarySubstraction? BreakBinarySubtraction { get; set; }

  /// <summary> 
  /// This element specifies the default justification of display math, at the document level.
  /// Individual instances of mathematical text can overrule the default setting.
  /// If this element is omitted, the default justification is centerGroup.
  /// Whether the element is absent or present without the val attribute,
  /// the default of the val attribute is centerGroup.
  ///</summary> 
  public MathJustification? DefaultJustification { get; set; }

  /// <summary> 
  /// This element specifies the document-level property to overwrite paragraph settings for mathematical text.
  ///</summary> 
  public bool? DisplayDefaults { get; set; }

  /// <summary> 
  /// This element specifies spacing between equations, expressions,
  /// or other instances of mathematical text within a display math paragraph, in twips.
  ///</summary> 
  public Twips? InterSpacing { get; set; }

  /// <summary> 
  /// This element specifies the spacing between adjacent display math paragraphs, in twips.
  /// If this element is omitted, no spacing is applied between adjacent math paragraphs.
  ///</summary> 
  public Twips? IntraSpacing { get; set; }

  /// <summary> 
  /// This element specifies the left margin for math, in twips.
  /// If this element is omitted, no left margin is used.
  /// In other words, when the element is absent, the default value of the option is 0.
  /// When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
  ///</summary> 
  public Twips? LeftMargin { get; set; }

  /// <summary> 
  /// This element specifies the default math font to be used in the document.
  /// If this element is omitted, font substitution should be used to determine the most appropriate font for use throughout the document.
  ///</summary> 
  public string? MathFont { get; set; }

  /// <summary> 
  /// his element specifies the spacing after a math paragraph, in twips.
  ///</summary> 
  public Twips? PostSpacing { get; set; }

  /// <summary> 
  /// This element specifies the spacing before a math paragraph, in twips.
  /// If this element is omitted, no spacing is applied before the paragraph.
  ///</summary> 
  public Twips? PreSpacing { get; set; }

  /// <summary> 
  /// This element specifies the right margin for math, in twips.
  /// If this element is omitted, no right margin is used.
  /// In other words, when the element is absent, the default value of the option is 0.
  /// When the element is present and the val attribute is absent, the default of the val attribute is 1440 (or 1 inch).
  ///</summary> 
  public Twips? RightMargin { get; set; }

  /// <summary> 
  /// This element specifies a reduced fraction size display math,
  /// such that the numerator and denominator are written in script size instead of at the size of regular text.
  ///</summary> 
  public bool? SmallFraction { get; set; }

  public Twips? WrapIndent{ get; set; }

  public bool? WrapRight { get; set; }

  public LimitLocation? IntegralLimitLocation { get; set;}

  public LimitLocation? NaryLimitLocation { get; set; }

}