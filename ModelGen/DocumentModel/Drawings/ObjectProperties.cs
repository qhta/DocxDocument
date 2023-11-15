namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ObjectProperties Class.
/// </summary>
public partial class ObjectProperties: ModelElement<DXO13D.ObjectProperties>
{
  public ObjectProperties(): base(){ }
  
  public ObjectProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectProperties(DXO13D.ObjectProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   objectId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsActiveX
  {
    get => _Element?.IsActiveX?.Value;
    set => _ExistingElement.IsActiveX = value;
  }
  
  
  /// <summary>
  ///   linkType, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? LinkType
  {
    get => _Element?.LinkType;
    set => _ExistingElement.LinkType = value;
  }
  
}
