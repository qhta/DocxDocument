namespace DocumentModel.Math;


/// <summary>
///   Matrix Column Properties.
/// </summary>
public partial class MatrixColumnProperties: ModelElement<DXM.MatrixColumnProperties>
{
  public MatrixColumnProperties(): base(){ }
  
  public MatrixColumnProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixColumnProperties(DXM.MatrixColumnProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Column Count.
  /// </summary>
  [DataMember]
  public Int64? MatrixColumnCount
  {
    get => _Element?.GetIntVal<Int64, DXM.MatrixColumnCount>();
    set => _ExistingElement.SetIntVal<Int64, DXM.MatrixColumnCount>(value);
  }
  
  
  /// <summary>
  ///   Matrix Column Justification.
  /// </summary>
  [DataMember]
  public DMM.HorizontalAlignmentKind? MatrixColumnJustification
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
