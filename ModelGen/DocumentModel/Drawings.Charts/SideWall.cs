namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D side wall formatting.
/// </summary>
public partial class SideWall: ModelElement<DXDC.SideWall>
{
  public SideWall(): base(){ }
  
  public SideWall(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SideWall(DXDC.SideWall openXmlElement): base(openXmlElement) { }
  
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
