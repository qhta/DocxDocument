namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroups: ModelElement<DXO10CUI.BackstageGroups>
{
  public BackstageGroups(): base(){ }
  
  public BackstageGroups(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageGroups(DXO10CUI.BackstageGroups openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMCUI10.TaskFormGroup? TaskFormGroup
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
