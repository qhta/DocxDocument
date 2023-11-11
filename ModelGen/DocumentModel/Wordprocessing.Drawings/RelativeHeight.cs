namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public partial class RelativeHeight: ModelElement<DXO10WD.RelativeHeight>
{
  public RelativeHeight(): base(){ }
  
  public RelativeHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeHeight(DXO10WD.RelativeHeight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  [DataMember]
  public DMWD.PercentageHeight? PercentageHeight
  {
    get
    {
      return _Element?.GetObject<DMWD.PercentageHeight,DXO10WD.PercentageHeight>();
    }
    set
    {
      _ExistingElement.SetObject<DMWD.PercentageHeight,DXO10WD.PercentageHeight>(value);
    }
  }
  
}
