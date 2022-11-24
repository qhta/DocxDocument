namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
public interface IMathProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Math Font.
  /// </summary>
  public IMathFont? MathFont { get ; set; }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public IBreakBinary? BreakBinary { get ; set; }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public IBreakBinarySubtraction? BreakBinarySubtraction { get ; set; }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public ISmallFraction? SmallFraction { get ; set; }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public IDisplayDefaults? DisplayDefaults { get ; set; }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public ILeftMargin? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public IRightMargin? RightMargin { get ; set; }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public IDefaultJustification? DefaultJustification { get ; set; }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public IPreSpacing? PreSpacing { get ; set; }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public IPostSpacing? PostSpacing { get ; set; }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public InterSpacing? InterSpacing { get ; set; }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public IntraSpacing? IntraSpacing { get ; set; }
  
}
