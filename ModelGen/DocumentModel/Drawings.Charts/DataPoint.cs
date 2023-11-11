namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint: ModelElement<DXDC.DataPoint>
{
  public DataPoint(): base(){ }
  
  public DataPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataPoint(DXDC.DataPoint openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Invert if Negative.
  /// </summary>
  [DataMember]
  public DMDC.InvertIfNegative? InvertIfNegative
  {
    get
    {
      return _Element?.GetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>(value);
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
  ///   3D Bubble.
  /// </summary>
  [DataMember]
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      return _Element?.GetObject<DMDC.Bubble3D,DXDC.Bubble3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Bubble3D,DXDC.Bubble3D>(value);
    }
  }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  [DataMember]
  public DMDC.Explosion? Explosion
  {
    get
    {
      return _Element?.GetObject<DMDC.Explosion,DXDC.Explosion>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Explosion,DXDC.Explosion>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get
    {
      return _Element?.GetObject<DMDC.PictureOptions,DXDC.PictureOptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PictureOptions,DXDC.PictureOptions>(value);
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
