namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a tint effect. Shifts effect color values towards/away from hue by the specified amount.
/// </summary>
public partial class TintEffect: ModelElement<DXD.TintEffect>
{
  public TintEffect(): base(){ }
  
  public TintEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TintEffect(DXD.TintEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the hue towards which to tint.
  /// </summary>
  [DataMember]
  public Int32? Hue
  {
    get
    {
      return _Element?.Hue?.Value;
    }
    set
    {
      _ExistingElement.Hue = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies by how much the color value is shifted.
  /// </summary>
  [DataMember]
  public Int32? Amount
  {
    get
    {
      return _Element?.Amount?.Value;
    }
    set
    {
      _ExistingElement.Amount = value;
    }
  }
  
}
