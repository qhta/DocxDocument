namespace DocumentModel.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public partial class Nary
{
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  public DocumentModel.Math.NaryProperties? NaryProperties { get; set; }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument { get; set; }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument { get; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
}
