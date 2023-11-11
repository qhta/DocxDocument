namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of effects and 3D properties that can be applied to an object.
/// </summary>
public partial class EffectStyle: ModelElement<DXD.EffectStyle>
{
  public EffectStyle(): base(){ }
  
  public EffectStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectStyle(DXD.EffectStyle openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get
    {
      return _Element?.GetObject<DMD.EffectList,DXD.EffectList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectList,DXD.EffectList>(value);
    }
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      return _Element?.GetObject<DMD.EffectDag,DXD.EffectDag>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectDag,DXD.EffectDag>(value);
    }
  }
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Scene3DType,DXD.Scene3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Scene3DType,DXD.Scene3DType>(value);
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Shape3DType,DXD.Shape3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Shape3DType,DXD.Shape3DType>(value);
    }
  }
  
}
