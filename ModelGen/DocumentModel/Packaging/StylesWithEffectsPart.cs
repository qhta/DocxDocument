namespace DocumentModel.Packaging;


/// <summary>
///   This part stores a copy of the styles part.
/// </summary>
public partial class StylesWithEffectsPart: ModelPartElement<DXPack.StylesWithEffectsPart>
{
  public StylesWithEffectsPart(): base(){ }
  
  public StylesWithEffectsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public StylesWithEffectsPart(DXPack.StylesWithEffectsPart openXmlElement): base(openXmlElement) { }
  
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
