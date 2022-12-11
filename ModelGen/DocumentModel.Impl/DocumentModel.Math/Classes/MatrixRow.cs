namespace DocumentModel.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public class MatrixRowImpl: ModelElementImpl, MatrixRow
{
  public DocumentFormat.OpenXml.Math.MatrixRow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixRow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MatrixRowImpl(): base() {}
  
  public MatrixRowImpl(DocumentFormat.OpenXml.Math.MatrixRow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
