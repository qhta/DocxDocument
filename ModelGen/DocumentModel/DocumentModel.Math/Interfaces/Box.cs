namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public partial interface Box
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public DocumentModel.Math.BoxProperties? BoxProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
}
