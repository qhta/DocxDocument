namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public partial class MoveToMathControl: ModelElement<DXW.MoveToMathControl>
{
  public MoveToMathControl(): base(){ }
  
  public MoveToMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveToMathControl(DXW.MoveToMathControl openXmlElement): base(openXmlElement) { }
  
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
