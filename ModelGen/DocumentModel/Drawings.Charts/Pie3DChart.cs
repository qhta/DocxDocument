namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Pie Charts.
/// </summary>
public partial class Pie3DChart: ModelElement<DXDC.Pie3DChart>
{
  public Pie3DChart(): base(){ }
  
  public Pie3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Pie3DChart(DXDC.Pie3DChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get
    {
      return _Element?.GetObject<DMDC.VaryColors,DXDC.VaryColors>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.VaryColors,DXDC.VaryColors>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabels,DXDC.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabels,DXDC.DataLabels>(value);
    }
  }
  
  [DataMember]
  public DMDC.Pie3DChartExtensionList? Pie3DChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.Pie3DChartExtensionList,DXDC.Pie3DChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Pie3DChartExtensionList,DXDC.Pie3DChartExtensionList>(value);
    }
  }
  
}
