namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenEffectsProperties Class.
/// </summary>
public partial class HiddenEffectsProperties: ModelElement<DXO10D.HiddenEffectsProperties>
{
  public HiddenEffectsProperties(): base(){ }
  
  public HiddenEffectsProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenEffectsProperties(DXO10D.HiddenEffectsProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
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
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
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
