namespace DocumentModel.Packaging;


/// <summary>
///   Defines the LabelInfoPart
/// </summary>
public partial class LabelInfoPart: ModelElement<DXPack.LabelInfoPart>
{
  public LabelInfoPart(): base(){ }
  
  public LabelInfoPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LabelInfoPart(DXPack.LabelInfoPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
