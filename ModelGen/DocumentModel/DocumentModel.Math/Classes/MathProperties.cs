namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
public class MathProperties
{
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public BreakBinaryOperatorKind? BreakBinary
  {
    get;
    set;
  }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public BooleanKind? SmallFraction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public BooleanKind? DisplayDefaults
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public JustificationKind? DefaultJustification
  {
    get;
    set;
  }
  
  public BooleanKind? WrapRight
  {
    get;
    set;
  }
  
  public LimitLocationKind? IntegralLimitLocation
  {
    get;
    set;
  }
  
  public LimitLocationKind? NaryLimitLocation
  {
    get;
    set;
  }
  
}
