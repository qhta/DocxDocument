namespace DocumentModel.Packaging;


/// <summary>
///   Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public partial class EmbeddedControlPersistenceBinaryDataPart: ModelElement<DXPack.EmbeddedControlPersistenceBinaryDataPart>
{
  public EmbeddedControlPersistenceBinaryDataPart(): base(){ }
  
  public EmbeddedControlPersistenceBinaryDataPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
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
