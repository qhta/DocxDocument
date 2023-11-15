namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the CompatExtension Class.
/// </summary>
public partial class CompatExtension: ModelElement<DXO10D.CompatExtension>
{
  public CompatExtension(): base(){ }
  
  public CompatExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CompatExtension(DXO10D.CompatExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get => _Element?.ShapeId;
    set => _ExistingElement.ShapeId = value;
  }
  
}
