namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
public interface IMathProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Math Font.
  /// </summary>
  public System.String? MathFont { get ; set; }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public DocumentModel.Math.BreakBinaryOperatorKind? BreakBinary { get ; set; }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public DocumentModel.Math.BreakBinarySubtractionKind? BreakBinarySubtraction { get ; set; }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public DocumentModel.Math.BooleanKind? SmallFraction { get ; set; }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public DocumentModel.Math.BooleanKind? DisplayDefaults { get ; set; }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public System.UInt32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public System.UInt32? RightMargin { get ; set; }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public DocumentModel.Math.JustificationKind? DefaultJustification { get ; set; }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public System.UInt32? PreSpacing { get ; set; }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public System.UInt32? PostSpacing { get ; set; }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public System.UInt32? InterSpacing { get ; set; }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public System.UInt32? IntraSpacing { get ; set; }
  
  public System.UInt32? WrapIndent { get ; set; }
  
  public DocumentModel.Math.BooleanKind? WrapRight { get ; set; }
  
  public DocumentModel.Math.LimitLocationKind? IntegralLimitLocation { get ; set; }
  
  public DocumentModel.Math.LimitLocationKind? NaryLimitLocation { get ; set; }
  
}
