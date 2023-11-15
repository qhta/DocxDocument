namespace DocumentModel.Math;


/// <summary>
///   Matrix Column.
/// </summary>
public partial class MatrixColumn: ModelElement<DXM.MatrixColumn>
{
  public MatrixColumn(): base(){ }
  
  public MatrixColumn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixColumn(DXM.MatrixColumn openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Column Properties.
  /// </summary>
  [DataMember]
  public DMM.MatrixColumnProperties? MatrixColumnProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
