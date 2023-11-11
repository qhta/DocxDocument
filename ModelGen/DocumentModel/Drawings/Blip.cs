namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of an image (binary large image or picture) and contains a reference to the image data.
/// </summary>
public partial class Blip: ModelElement<DXD.Blip>
{
  public Blip(): base(){ }
  
  public Blip(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blip(DXD.Blip openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [DataMember]
  public String? Embed
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Embed);
    }
    set
    {
      _ExistingElement.Embed = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Link);
    }
    set
    {
      _ExistingElement.Link = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMD.BlipExtensionList? BlipExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.BlipExtensionList,DXD.BlipExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BlipExtensionList,DXD.BlipExtensionList>(value);
    }
  }
  
}
