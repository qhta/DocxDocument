namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ColorMapOverride Class.
/// </summary>
public partial class ColorMapOverride: ModelElement<DXDC.ColorMapOverride>
{
  public ColorMapOverride(): base(){ }
  
  public ColorMapOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMapOverride(DXDC.ColorMapOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
