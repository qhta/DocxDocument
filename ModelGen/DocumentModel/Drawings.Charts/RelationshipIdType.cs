namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RelationshipIdType Class.
/// </summary>
public partial class RelationshipIdType: ModelElement<DXDC.RelationshipIdType>
{
  public RelationshipIdType(): base(){ }
  
  public RelationshipIdType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelationshipIdType(DXDC.RelationshipIdType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
