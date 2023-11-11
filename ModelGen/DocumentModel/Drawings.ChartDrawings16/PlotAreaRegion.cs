namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public partial class PlotAreaRegion: ModelElement<DXO16DCD.PlotAreaRegion>
{
  public PlotAreaRegion(): base(){ }
  
  public PlotAreaRegion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotAreaRegion(DXO16DCD.PlotAreaRegion openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotSurface? PlotSurface
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PlotSurface,DXO16DCD.PlotSurface>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PlotSurface,DXO16DCD.PlotSurface>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
