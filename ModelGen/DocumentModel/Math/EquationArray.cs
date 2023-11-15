namespace DocumentModel.Math;


/// <summary>
///   Equation-Array Function.
/// </summary>
public partial class EquationArray: ModelElement<DXM.EquationArray>
{
  public EquationArray(): base(){ }
  
  public EquationArray(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EquationArray(DXM.EquationArray openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  [DataMember]
  public DMM.EquationArrayProperties? EquationArrayProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
