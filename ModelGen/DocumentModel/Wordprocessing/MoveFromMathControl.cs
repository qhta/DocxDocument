namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveFromMathControl Class.
/// </summary>
public partial class MoveFromMathControl: ModelElement<DXW.MoveFromMathControl>
{
  public MoveFromMathControl(): base(){ }
  
  public MoveFromMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveFromMathControl(DXW.MoveFromMathControl openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.InsertedMathControl? InsertedMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.DeletedMathControl? DeletedMathControl
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
