namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotSurface Class.
/// </summary>
public partial class PlotSurface: ModelElement<DXO16DCD.PlotSurface>
{
  public PlotSurface(): base(){ }
  
  public PlotSurface(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotSurface(DXO16DCD.PlotSurface openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
