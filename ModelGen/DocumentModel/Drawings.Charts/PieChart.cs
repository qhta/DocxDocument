namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie Charts.
/// </summary>
public partial class PieChart: ModelElement<DXDC.PieChart>
{
  public PieChart(): base(){ }
  
  public PieChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PieChart(DXDC.PieChart openXmlElement): base(openXmlElement) { }
  
  
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
  public UInt16? FirstSliceAngle
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.FirstSliceAngle>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.FirstSliceAngle,System.UInt16>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMDC.PieChartExtensionList? PieChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.PieChartExtensionList,DXDC.PieChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PieChartExtensionList,DXDC.PieChartExtensionList>(value);
    }
  }
  
}
