namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public partial class ImageLayer: ModelElement<DXO10D.ImageLayer>
{
  public ImageLayer(): base(){ }
  
  public ImageLayer(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageLayer(DXO10D.ImageLayer openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
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
  
}
