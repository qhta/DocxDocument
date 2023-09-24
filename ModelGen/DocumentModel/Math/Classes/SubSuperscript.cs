namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Function.
/// </summary>
public partial class SubSuperscript
{
  
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  public SubSuperscriptProperties? SubSuperscriptProperties { get; set; }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
  
  
  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument { get; set; }
  
  
  /// <summary>
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get; set; }
  
}
