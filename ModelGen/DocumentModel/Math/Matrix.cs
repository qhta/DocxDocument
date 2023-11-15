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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
