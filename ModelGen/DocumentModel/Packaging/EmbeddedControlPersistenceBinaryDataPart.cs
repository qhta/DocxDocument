namespace DocumentModel.Packaging;


/// <summary>
///   Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public partial class EmbeddedControlPersistenceBinaryDataPart: ModelPartElement<DXPack.EmbeddedControlPersistenceBinaryDataPart>
{
  public EmbeddedControlPersistenceBinaryDataPart(): base(){ }
  
  public EmbeddedControlPersistenceBinaryDataPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public EmbeddedControlPersistenceBinaryDataPart(DXPack.EmbeddedControlPersistenceBinaryDataPart openXmlElement): base(openXmlElement) { }
  
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
