namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape Style.
/// </summary>
public partial class Style: ModelElement<DXDDD.Style>
{
  public Style(): base(){ }
  
  public Style(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Style(DXDDD.Style openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  [DataMember]
  public DMD.LineReference? LineReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineReference>();
      if (element != null)
        return LineReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineReferenceConverter.CreateOpenXmlElement<DXD.LineReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  [DataMember]
  public DMD.FillReference? FillReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FillReference>();
      if (element != null)
        return FillReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillReferenceConverter.CreateOpenXmlElement<DXD.FillReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  [DataMember]
  public DMD.EffectReference? EffectReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectReference>();
      if (element != null)
        return EffectReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectReferenceConverter.CreateOpenXmlElement<DXD.EffectReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Font Reference.
  /// </summary>
  [DataMember]
  public DMD.FontReference? FontReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FontReference>();
      if (element != null)
        return FontReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontReferenceConverter.CreateOpenXmlElement<DXD.FontReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
