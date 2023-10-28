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
  public DMM.BreakBinaryOperatorKind? BreakBinary { get; set; }
  
  
  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  public DMM.BreakBinarySubtractionKind? BreakBinarySubtraction { get; set; }
  
  
  /// <summary>
  ///   Small Fraction.
  /// </summary>
  public DMM.SmallFraction? SmallFraction { get; set; }
  
  
  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  public DMM.DisplayDefaults? DisplayDefaults { get; set; }
  
  
  /// <summary>
  ///   Left Margin.
  /// </summary>
  public DMM.LeftMargin? LeftMargin { get; set; }
  
  
  /// <summary>
  ///   Right Margin.
  /// </summary>
  public DMM.RightMargin? RightMargin { get; set; }
  
  
  /// <summary>
  ///   Default Justification.
  /// </summary>
  public DMM.DefaultJustification? DefaultJustification { get; set; }
  
  
  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  public DMM.PreSpacing? PreSpacing { get; set; }
  
  
  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  public DMM.PostSpacing? PostSpacing { get; set; }
  
  
  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  public DMM.InterSpacing? InterSpacing { get; set; }
  
  
  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  public DMM.IntraSpacing? IntraSpacing { get; set; }
  
  public DMM.WrapIndent? WrapIndent { get; set; }
  
  public DMM.WrapRight? WrapRight { get; set; }
  
  public DMM.IntegralLimitLocation? IntegralLimitLocation { get; set; }
  
  public DMM.NaryLimitLocation? NaryLimitLocation { get; set; }
  
}
