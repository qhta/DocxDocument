namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an alpha outset/inset effect.
/// </summary>
public partial class AlphaOutset: ModelElement<DXD.AlphaOutset>
{
  public AlphaOutset(): base(){ }
  
  public AlphaOutset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaOutset(DXD.AlphaOutset openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the radius of outset/inset.
  /// </summary>
  [DataMember]
  public Int64? Radius
  {
    get
    {
      return _Element?.Radius?.Value;
    }
    set
    {
      _ExistingElement.Radius = value;
    }
  }
  
}
