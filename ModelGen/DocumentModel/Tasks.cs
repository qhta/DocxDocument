namespace DocumentModel;


/// <summary>
///   Defines the Tasks Class.
/// </summary>
public partial class Tasks: ModelElement<DXO21DT.Tasks>
{
  public Tasks(): base(){ }
  
  public Tasks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tasks(DXO21DT.Tasks openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
