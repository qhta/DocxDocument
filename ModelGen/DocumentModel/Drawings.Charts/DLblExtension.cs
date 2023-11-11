namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public partial class DLblExtension: ModelElement<DXDC.DLblExtension>
{
  public DLblExtension(): base(){ }
  
  public DLblExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DLblExtension(DXDC.DLblExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.ExceptionForSave? ExceptionForSave
  {
    get
    {
      return _Element?.GetObject<DMDC13.ExceptionForSave,DXO13DC.ExceptionForSave>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ExceptionForSave,DXO13DC.ExceptionForSave>(value);
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
  
}
