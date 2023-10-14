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
  public DocumentModel.Math.BreakBinaryOperatorKind? BreakBinary { get; set; }
  
  
  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  public DocumentModel.Math.BreakBinarySubtractionKind? BreakBinarySubtraction { get; set; }
  
  
  /// <summary>
  ///   Small Fraction.
  /// </summary>
  public DocumentModel.Math.SmallFraction? SmallFraction { get; set; }
  
  
  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  public DocumentModel.Math.DisplayDefaults? DisplayDefaults { get; set; }
  
  
  /// <summary>
  ///   Left Margin.
  /// </summary>
  public DocumentModel.Math.LeftMargin? LeftMargin { get; set; }
  
  
  /// <summary>
  ///   Right Margin.
  /// </summary>
  public DocumentModel.Math.RightMargin? RightMargin { get; set; }
  
  
  /// <summary>
  ///   Default Justification.
  /// </summary>
  public DocumentModel.Math.DefaultJustification? DefaultJustification { get; set; }
  
  
  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  public DocumentModel.Math.PreSpacing? PreSpacing { get; set; }
  
  
  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  public DocumentModel.Math.PostSpacing? PostSpacing { get; set; }
  
  
  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  public DocumentModel.Math.InterSpacing? InterSpacing { get; set; }
  
  
  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  public DocumentModel.Math.IntraSpacing? IntraSpacing { get; set; }
  
  public DocumentModel.Math.WrapIndent? WrapIndent { get; set; }
  
  public DocumentModel.Math.WrapRight? WrapRight { get; set; }
  
  public DocumentModel.Math.IntegralLimitLocation? IntegralLimitLocation { get; set; }
  
  public DocumentModel.Math.NaryLimitLocation? NaryLimitLocation { get; set; }
  
}
