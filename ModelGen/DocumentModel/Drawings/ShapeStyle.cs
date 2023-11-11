namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the style information for a shape.
/// </summary>
public partial class ShapeStyle: ModelElement<DXD.ShapeStyle>
{
  public ShapeStyle(): base(){ }
  
  public ShapeStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeStyle(DXD.ShapeStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  [DataMember]
  public DMD.LineReference? LineReference
  {
    get
    {
      return _Element?.GetObject<DMD.LineReference,DXD.LineReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LineReference,DXD.LineReference>(value);
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
      return _Element?.GetObject<DMD.FillReference,DXD.FillReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FillReference,DXD.FillReference>(value);
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
      return _Element?.GetObject<DMD.EffectReference,DXD.EffectReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectReference,DXD.EffectReference>(value);
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
      return _Element?.GetObject<DMD.FontReference,DXD.FontReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FontReference,DXD.FontReference>(value);
    }
  }
  
}
