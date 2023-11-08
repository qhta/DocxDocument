namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public partial class DLblsExtension: ModelElement<DXDC.DLblsExtension>
{
  public DLblsExtension(): base(){ }
  
  public DLblsExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DLblsExtension(DXDC.DLblsExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.ChartText? ChartText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ChartText>();
      if (element != null)
        return ChartTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTextConverter.CreateOpenXmlElement<DXO13DC.ChartText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.DataLabelFieldTable>();
      if (element != null)
        return DataLabelFieldTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabelFieldTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (element != null)
        return ShowDataLabelsRangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowDataLabelsRangeConverter.CreateOpenXmlElement<DXO13DC.ShowDataLabelsRange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.Layout? Layout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.Layout>();
      if (element != null)
        return LayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DXO13DC.Layout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ShowLeaderLines? ShowLeaderLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShowLeaderLines>();
      if (element != null)
        return ShowLeaderLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowLeaderLinesConverter.CreateOpenXmlElement<DXO13DC.ShowLeaderLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.LeaderLines? LeaderLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.LeaderLines>();
      if (element != null)
        return LeaderLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLinesConverter.CreateOpenXmlElement<DXO13DC.LeaderLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
