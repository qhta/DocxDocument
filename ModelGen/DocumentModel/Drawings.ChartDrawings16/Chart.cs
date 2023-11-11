namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Chart Class.
/// </summary>
public partial class Chart: ModelElement<DXO16DCD.Chart>
{
  public Chart(): base(){ }
  
  public Chart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Chart(DXO16DCD.Chart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartTitle.
  /// </summary>
  [DataMember]
  public DMDCD16.ChartTitle? ChartTitle
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ChartTitle,DXO16DCD.ChartTitle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ChartTitle,DXO16DCD.ChartTitle>(value);
    }
  }
  
  
  /// <summary>
  ///   PlotArea.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotArea? PlotArea
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PlotArea,DXO16DCD.PlotArea>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PlotArea,DXO16DCD.PlotArea>(value);
    }
  }
  
  
  /// <summary>
  ///   Legend.
  /// </summary>
  [DataMember]
  public DMDCD16.Legend? Legend
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Legend,DXO16DCD.Legend>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Legend,DXO16DCD.Legend>(value);
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
