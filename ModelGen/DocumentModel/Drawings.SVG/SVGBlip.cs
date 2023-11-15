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
    get => _Element?.Embed;
    set => _ExistingElement.Embed = value;
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get => _Element?.Link;
    set => _ExistingElement.Link = value;
  }
  
}
