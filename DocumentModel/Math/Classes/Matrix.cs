namespace DocumentModel.Math;

/// <summary>
///   Matrix Function.
/// </summary>
public class Matrix
{
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get; set; }

  public Collection<MatrixRow>? MatrixRows { get; set; }
}