namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public interface Matrix // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get ; set; }
  
  public Collection<MatrixRow>? MatrixRows { get ; set; }
  
}
