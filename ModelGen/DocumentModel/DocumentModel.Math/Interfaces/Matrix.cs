namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public interface Matrix
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public DocumentModel.Math.MatrixProperties? MatrixProperties { get ; set; }
  
  public DocumentModel.Math.MatrixRow? MatrixRow { get ; set; }
  
}
