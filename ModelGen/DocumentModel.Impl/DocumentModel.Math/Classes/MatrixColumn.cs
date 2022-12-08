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
  
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public MatrixColumnProperties? MatrixColumnProperties
  {
    get;
    set;
  }
  
}
