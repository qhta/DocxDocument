namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
public interface MathProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Math Font.
  /// </summary>
  public String? MathFont { get ; set; }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public BreakBinaryOperatorKind? BreakBinary { get ; set; }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public BreakBinarySubtractionKind? BreakBinarySubtraction { get ; set; }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public BooleanKind? SmallFraction { get ; set; }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public BooleanKind? DisplayDefaults { get ; set; }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public UInt32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public UInt32? RightMargin { get ; set; }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public JustificationKind? DefaultJustification { get ; set; }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public UInt32? PreSpacing { get ; set; }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public UInt32? PostSpacing { get ; set; }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public UInt32? InterSpacing { get ; set; }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public UInt32? IntraSpacing { get ; set; }
  
  public UInt32? WrapIndent { get ; set; }
  
  public BooleanKind? WrapRight { get ; set; }
  
  public LimitLocationKind? IntegralLimitLocation { get ; set; }
  
  public LimitLocationKind? NaryLimitLocation { get ; set; }
  
}
