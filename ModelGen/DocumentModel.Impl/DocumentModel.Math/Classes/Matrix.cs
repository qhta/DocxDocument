namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public class MatrixImpl: ModelElementImpl, Matrix
{
  public DocumentFormat.OpenXml.Math.Matrix? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Matrix?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MatrixRow>? MatrixRows
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
