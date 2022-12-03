namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public interface Superscript // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public SuperscriptProperties? SuperscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument { get ; set; }
  
}
