namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public class MatrixImpl: ModelElement<DocumentFormat.OpenXml.Math.Matrix>, Matrix
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties
  {
    get;
    set;
  }
  
}
