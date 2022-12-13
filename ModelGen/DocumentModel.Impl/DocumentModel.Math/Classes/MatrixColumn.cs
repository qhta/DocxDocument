namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public class MatrixColumnImpl: ModelElementImpl, MatrixColumn
{
  public DocumentFormat.OpenXml.Math.MatrixColumn? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumn?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MatrixColumnImpl(): base() {}
  
  public MatrixColumnImpl(DocumentFormat.OpenXml.Math.MatrixColumn openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public DocumentModel.Math.MatrixColumnProperties? MatrixColumnProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
