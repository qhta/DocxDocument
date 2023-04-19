namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties on control characters; that is, object characters that cannot be selected. 
///   Examples of control characters are n-ary operators (excluding their limits and bases), 
///   fraction bars (excluding the numerator and denominator), and grouping characters (excluding the base). 
///   ControlProperties allows formatting properties to be stored on these control characters. 
///   The control character inherits its formatting from the paragraph formatting; 
///   ControlProperties contains the formatting differences between the control character and the paragraph formatting.
/// </summary>
public class ControlProperties: ModelElement
{
  /// <summary>
  /// Specifies formatting differences between the control character and the paragraph formatting.
  /// </summary>
  public DMW.RunProperties? RunProperties { get; set; }

  /// <summary>
  /// Specifies revision information about inserted ControlProperties.
  /// </summary>
  public DMW.InsertedMathControl? InsertedMathControl { get; set; }

  /// <summary>
  /// Specifies revision information about deleted ControlProperties.
  /// </summary>
  public DMW.DeletedMathControl? DeletedMathControl { get; set; }

  /// <summary>
  /// Specifies revision information about move source of ControlProperties.
  /// </summary>
  public DMW.MoveFromMathControl? MoveFromMathControl { get; set; }

  /// <summary>
  /// Specifies revision information about move target of ControlProperties.
  /// </summary>
  public DMW.MoveToMathControl? MoveToMathControl { get; set; }

}