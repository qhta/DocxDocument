namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pivot Format.
/// </summary>
public partial class PivotFormat: ModelElement<DXDC.PivotFormat>
{
  public PivotFormat(): base(){ }
  
  public PivotFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotFormat(DXDC.PivotFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      return _Element?.GetObject<DMDC.Index,DXDC.Index>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Index,DXDC.Index>(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC.Marker? Marker
  {
    get
    {
      return _Element?.GetObject<DMDC.Marker,DXDC.Marker>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Marker,DXDC.Marker>(value);
    }
  }
  
  
  /// <summary>
  ///   Data Label.
  /// </summary>
  [DataMember]
  public DMDC.DataLabel? DataLabel
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabel,DXDC.DataLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabel,DXDC.DataLabel>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
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
