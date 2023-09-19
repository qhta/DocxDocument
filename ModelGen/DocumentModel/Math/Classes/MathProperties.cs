namespace DocumentModel.Math;


/// <summary>
///   Math Properties.
/// </summary>
public partial class MathProperties
{
  
  /// <summary>
  ///   Math Font.
  /// </summary>
  public String? MathFont { get; set; }
  
  
  /// <summary>
  ///   Break on Binary Operators.
  /// </summary>
  public DocumentModel.Math.BreakBinaryOperatorValues? BreakBinary { get; set; }
  
  
  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  public DocumentModel.Math.BreakBinarySubtractionValues? BreakBinarySubtraction { get; set; }
  
  
  /// <summary>
  ///   Small Fraction.
  /// </summary>
  public DocumentModel.Math.BooleanValues? SmallFraction { get; set; }
  
  
  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  public DocumentModel.Math.BooleanValues? DisplayDefaults { get; set; }
  
  
  /// <summary>
  ///   Left Margin.
  /// </summary>
  public UInt32? LeftMargin { get; set; }
  
  
  /// <summary>
  ///   Right Margin.
  /// </summary>
  public UInt32? RightMargin { get; set; }
  
  
  /// <summary>
  ///   Default Justification.
  /// </summary>
  public DocumentModel.Math.JustificationValues? DefaultJustification { get; set; }
  
  
  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  public UInt32? PreSpacing { get; set; }
  
  
  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  public UInt32? PostSpacing { get; set; }
  
  
  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  public UInt32? InterSpacing { get; set; }
  
  
  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  public UInt32? IntraSpacing { get; set; }
  
  public UInt32? WrapIndent { get; set; }
  
  public DocumentModel.Math.BooleanValues? WrapRight { get; set; }
  
  public DocumentModel.Math.LimitLocationValues? IntegralLimitLocation { get; set; }
  
  public DocumentModel.Math.LimitLocationValues? NaryLimitLocation { get; set; }
  
}
