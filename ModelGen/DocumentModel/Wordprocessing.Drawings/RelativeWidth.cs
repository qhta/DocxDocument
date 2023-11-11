namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public partial class RelativeWidth: ModelElement<DXO10WD.RelativeWidth>
{
  public RelativeWidth(): base(){ }
  
  public RelativeWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeWidth(DXO10WD.RelativeWidth openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  [DataMember]
  public DMWD.PercentageWidth? PercentageWidth
  {
    get
    {
      return _Element?.GetObject<DMWD.PercentageWidth,DXO10WD.PercentageWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMWD.PercentageWidth,DXO10WD.PercentageWidth>(value);
    }
  }
  
}
