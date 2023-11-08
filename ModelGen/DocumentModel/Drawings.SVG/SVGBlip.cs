namespace DocumentModel.Drawings.SVG;


/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public partial class SVGBlip: ModelElement<DXO19DSVG.SVGBlip>
{
  public SVGBlip(): base(){ }
  
  public SVGBlip(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SVGBlip(DXO19DSVG.SVGBlip openXmlElement): base(openXmlElement) { }
  
  
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
  
}
