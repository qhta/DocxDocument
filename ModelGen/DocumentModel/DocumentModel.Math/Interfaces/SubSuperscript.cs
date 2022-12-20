namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public partial interface SubSuperscript
{
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.SubSuperscriptProperties? SubSuperscriptProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
  /// <summary>
  /// Subscript (Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument { get; set; }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument { get; set; }
  
}
