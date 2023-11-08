namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains information about an embedded control in the package. This information is provided by the specified control when asked to persist.
/// </summary>
public partial class EmbeddedControlPersistencePart: ModelElement<DXPack.EmbeddedControlPersistencePart>
{
  public EmbeddedControlPersistencePart(): base(){ }
  
  public EmbeddedControlPersistencePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbeddedControlPersistencePart(DXPack.EmbeddedControlPersistencePart openXmlElement): base(openXmlElement) { }
  
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
