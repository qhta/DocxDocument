namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the Saturation Class.
/// </summary>
public partial class Saturation: ModelElement<DXO10D.Saturation>
{
  public Saturation(): base(){ }
  
  public Saturation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Saturation(DXO10D.Saturation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SaturationAmount
  {
    get
    {
      return _Element?.SaturationAmount?.Value;
    }
    set
    {
      _ExistingElement.SaturationAmount = value;
    }
  }
  
}
