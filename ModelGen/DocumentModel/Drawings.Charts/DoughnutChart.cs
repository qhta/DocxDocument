namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Doughnut Charts.
/// </summary>
public partial class DoughnutChart: ModelElement<DXDC.DoughnutChart>
{
  public DoughnutChart(): base(){ }
  
  public DoughnutChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoughnutChart(DXDC.DoughnutChart openXmlElement): base(openXmlElement) { }
  
  
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
  public Byte? HoleSize
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.HoleSize>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.HoleSize,System.Byte>(_ExistingElement, value);
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
