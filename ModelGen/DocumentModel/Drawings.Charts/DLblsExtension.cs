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
      return _Element?.GetObject<DMDC13.ChartText,DXO13DC.ChartText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ChartText,DXO13DC.ChartText>(value);
    }
  }
  
  [DataMember]
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable
  {
    get
    {
      return _Element?.GetObject<DMDC13.DataLabelFieldTable,DXO13DC.DataLabelFieldTable>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.DataLabelFieldTable,DXO13DC.DataLabelFieldTable>(value);
    }
  }
  
  [DataMember]
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange
  {
    get
    {
      return _Element?.GetObject<DMDC13.ShowDataLabelsRange,DXO13DC.ShowDataLabelsRange>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ShowDataLabelsRange,DXO13DC.ShowDataLabelsRange>(value);
    }
  }
  
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC13.ShapeProperties,DXO13DC.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ShapeProperties,DXO13DC.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC13.Layout? Layout
  {
    get
    {
      return _Element?.GetObject<DMDC13.Layout,DXO13DC.Layout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.Layout,DXO13DC.Layout>(value);
    }
  }
  
  [DataMember]
  public DMDC13.ShowLeaderLines? ShowLeaderLines
  {
    get
    {
      return _Element?.GetObject<DMDC13.ShowLeaderLines,DXO13DC.ShowLeaderLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ShowLeaderLines,DXO13DC.ShowLeaderLines>(value);
    }
  }
  
  [DataMember]
  public DMDC13.LeaderLines? LeaderLines
  {
    get
    {
      return _Element?.GetObject<DMDC13.LeaderLines,DXO13DC.LeaderLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.LeaderLines,DXO13DC.LeaderLines>(value);
    }
  }
  
}
