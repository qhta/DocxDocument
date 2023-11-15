namespace DocumentModel.Drawings;


/// <summary>
///   Defines the CreationId Class.
/// </summary>
public partial class CreationId: ModelElement<DXO16D.CreationId>
{
  public CreationId(): base(){ }
  
  public CreationId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CreationId(DXO16D.CreationId openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
