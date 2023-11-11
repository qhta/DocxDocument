namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceType Class.
/// </summary>
public partial class SurfaceType: ModelElement<DXDC.SurfaceType>
{
  public SurfaceType(): base(){ }
  
  public SurfaceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceType(DXDC.SurfaceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Thickness.
  /// </summary>
  [DataMember]
  public Byte? Thickness
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.Thickness>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.Thickness,System.Byte>(_ExistingElement, value);
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
  ///   Picture Options.
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
