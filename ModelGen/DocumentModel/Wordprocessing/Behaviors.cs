namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public partial class Behaviors: ModelElement<DXW.Behaviors>
{
  public Behaviors(): base(){ }
  
  public Behaviors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Behaviors(DXW.Behaviors openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ElementCollection<DocPartBehaviorKind>? Items
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentModel.ModelElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentModel.ModelElement");
  }
  
}
