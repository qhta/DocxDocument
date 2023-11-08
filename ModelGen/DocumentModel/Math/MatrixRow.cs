namespace DocumentModel.Math;


/// <summary>
///   Matrix Row.
/// </summary>
public partial class MatrixRow: ModelElement<DXM.MatrixRow>
{
  public MatrixRow(): base(){ }
  
  public MatrixRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixRow(DXM.MatrixRow openXmlElement): base(openXmlElement) { }
  
}
