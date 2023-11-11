namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public partial class PlotArea: ModelElement<DXO16DCD.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXO16DCD.PlotArea openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotAreaRegion? PlotAreaRegion
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PlotAreaRegion,DXO16DCD.PlotAreaRegion>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PlotAreaRegion,DXO16DCD.PlotAreaRegion>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
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
