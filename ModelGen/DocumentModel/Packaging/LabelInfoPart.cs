namespace DocumentModel.Packaging;


/// <summary>
///   Defines the LabelInfoPart
/// </summary>
public partial class LabelInfoPart: ModelPartElement<DXPack.LabelInfoPart>
{
  public LabelInfoPart(): base(){ }
  
  public LabelInfoPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
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
