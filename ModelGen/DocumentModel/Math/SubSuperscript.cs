namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Function.
/// </summary>
public partial class SubSuperscript
{
  
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  public DMM.SubSuperscriptProperties? SubSuperscriptProperties { get; set; }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  public DMM.Base? Base { get; set; }
  
  
  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  public DMM.SubArgument? SubArgument { get; set; }
  
  
  /// <summary>
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  public DMM.SuperArgument? SuperArgument { get; set; }
  
}
