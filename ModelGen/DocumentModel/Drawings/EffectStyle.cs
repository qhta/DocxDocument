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
      var element = _Element?.GetFirstChild<DXD.EffectList>();
      if (element != null)
        return EffectListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectDag>();
      if (element != null)
        return EffectDagConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Scene3DType>();
      if (element != null)
        return Scene3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Scene3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Shape3DType>();
      if (element != null)
        return Shape3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
