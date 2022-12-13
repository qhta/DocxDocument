namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public interface PreSubSuper
{
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.PreSubSuperProperties? PreSubSuperProperties { get ; set; }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
