namespace DocumentModel.Math;


/// <summary>
///   n-ary Operator Function.
/// </summary>
public partial class Nary
{
  
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  public DMM.NaryProperties? NaryProperties { get; set; }
  
  
  /// <summary>
  ///   Lower limit (n-ary) .
  /// </summary>
  public DMM.SubArgument? SubArgument { get; set; }
  
  
  /// <summary>
  ///   Upper limit (n-ary).
  /// </summary>
  public DMM.SuperArgument? SuperArgument { get; set; }
  
  
  /// <summary>
  ///   Base (Argument).
  /// </summary>
  public DMM.Base? Base { get; set; }
  
}
