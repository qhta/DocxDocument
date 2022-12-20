namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public partial interface Matrix
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public DocumentModel.Math.MatrixProperties? MatrixProperties { get; set; }
  
  public Collection<DocumentModel.Math.MatrixRow>? MatrixRows { get; set; }
  
}
