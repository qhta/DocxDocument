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
      var element = _Element?.GetFirstChild<DXDC.VaryColors>();
      if (element != null)
        return VaryColorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VaryColorsConverter.CreateOpenXmlElement<DXDC.VaryColors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXDC.FirstSliceAngle,System.UInt16>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.PieChartExtensionList? PieChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PieChartExtensionList>();
      if (element != null)
        return PieChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PieChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PieChartExtensionListConverter.CreateOpenXmlElement<DXDC.PieChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
