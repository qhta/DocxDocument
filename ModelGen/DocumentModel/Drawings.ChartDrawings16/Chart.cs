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
      var element = _Element?.GetFirstChild<DXO16DCD.ChartTitle>();
      if (element != null)
        return ChartTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ChartTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTitleConverter.CreateOpenXmlElement<DXO16DCD.ChartTitle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.PlotArea>();
      if (element != null)
        return PlotAreaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DXO16DCD.PlotArea>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.Legend>();
      if (element != null)
        return LegendConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendConverter.CreateOpenXmlElement<DXO16DCD.Legend>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
