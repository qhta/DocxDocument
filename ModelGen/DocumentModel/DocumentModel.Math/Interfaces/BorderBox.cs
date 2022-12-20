namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public partial interface BorderBox
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public DocumentModel.Math.BorderBoxProperties? BorderBoxProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
}
