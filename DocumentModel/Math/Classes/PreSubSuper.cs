namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Pre-Sub-Superscript objects Pre. 
/// </summary>
public class PreSubSuper: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  public PreSubSuperProperties? PreSubSuperProperties { get; set; }

  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument { get; set; }

  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }

  /// <summary>
  ///   Base argument.
  /// </summary>
  public Argument? Base { get; set; }
}