namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D back wall formatting.
/// </summary>
public partial class BackWall: ModelElement<DXDC.BackWall>
{
  public BackWall(): base(){ }
  
  public BackWall(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackWall(DXDC.BackWall openXmlElement): base(openXmlElement) { }
  
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
