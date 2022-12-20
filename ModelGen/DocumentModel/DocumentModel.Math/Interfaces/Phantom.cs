namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public partial interface Phantom
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public DocumentModel.Math.PhantomProperties? PhantomProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
}
