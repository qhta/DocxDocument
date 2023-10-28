namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Function.
/// </summary>
public partial class PreSubSuper
{
  
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  public DMM.PreSubSuperProperties? PreSubSuperProperties { get; set; }
  
  
  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  public DMM.SubArgument? SubArgument { get; set; }
  
  
  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DMM.SuperArgument? SuperArgument { get; set; }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  public DMM.Base? Base { get; set; }
  
}
