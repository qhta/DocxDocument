namespace DocumentModel.Drawings;


/// <summary>
///   Defines the PictureAttributionSourceURL Class.
/// </summary>
public partial class PictureAttributionSourceURL: ModelElement<DXO19D.PictureAttributionSourceURL>
{
  public PictureAttributionSourceURL(): base(){ }
  
  public PictureAttributionSourceURL(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureAttributionSourceURL(DXO19D.PictureAttributionSourceURL openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
