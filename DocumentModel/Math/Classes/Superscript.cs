namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public partial class Superscript
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public DocumentModel.Math.SuperscriptProperties? SuperscriptProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument { get; set; }
  
}
