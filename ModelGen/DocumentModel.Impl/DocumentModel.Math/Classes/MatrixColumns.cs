namespace DocumentModel.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public class MatrixColumnsImpl: ModelElementImpl, MatrixColumns
{
  public DocumentFormat.OpenXml.Math.MatrixColumns? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumns?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<MatrixColumn>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
