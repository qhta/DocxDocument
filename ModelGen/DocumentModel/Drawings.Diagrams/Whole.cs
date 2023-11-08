namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Whole E2O Formatting.
/// </summary>
public partial class Whole: ModelElement<DXDDD.Whole>
{
  public Whole(): base(){ }
  
  public Whole(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Whole(DXDDD.Whole openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Outline>();
      if (element != null)
        return OutlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
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
  
}
