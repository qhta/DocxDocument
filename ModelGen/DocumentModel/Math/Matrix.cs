namespace DocumentModel.Math;


/// <summary>
///   Matrix Function.
/// </summary>
public partial class Matrix: ModelElement<DXM.Matrix>
{
  public Matrix(): base(){ }
  
  public Matrix(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Matrix(DXM.Matrix openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  [DataMember]
  public DMM.MatrixProperties? MatrixProperties
  {
    get
    {
      return _Element?.GetObject<DMM.MatrixProperties,DXM.MatrixProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.MatrixProperties,DXM.MatrixProperties>(value);
    }
  }
  
}
