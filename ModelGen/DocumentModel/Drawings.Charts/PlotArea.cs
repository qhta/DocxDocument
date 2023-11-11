namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plot data and formatting.
/// </summary>
public partial class PlotArea: ModelElement<DXDC.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXDC.PlotArea openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout.
  /// </summary>
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      return _Element?.GetObject<DMDC.Layout,DXDC.Layout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Layout,DXDC.Layout>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataTable? DataTable
  {
    get
    {
      return _Element?.GetObject<DMDC.DataTable,DXDC.DataTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataTable,DXDC.DataTable>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ShapeProperties,DXDC.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShapeProperties,DXDC.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
