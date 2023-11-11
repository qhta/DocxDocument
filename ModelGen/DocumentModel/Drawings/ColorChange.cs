namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a Color Change Effect. Instances of clrFrom are replaced with instances of clrTo.
/// </summary>
public partial class ColorChange: ModelElement<DXD.ColorChange>
{
  public ColorChange(): base(){ }
  
  public ColorChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorChange(DXD.ColorChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies whether alpha values are considered for the effect. Effect alpha values are considered if useA is true, else they are ignored.
  /// </summary>
  [DataMember]
  public Boolean? UseAlpha
  {
    get
    {
      return _Element?.UseAlpha?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UseAlpha = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UseAlpha = null;
    }
  }
  
  
  /// <summary>
  ///   Change Color From.
  /// </summary>
  [DataMember]
  public DMD.ColorFrom? ColorFrom
  {
    get
    {
      return _Element?.GetObject<DMD.ColorFrom,DXD.ColorFrom>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ColorFrom,DXD.ColorFrom>(value);
    }
  }
  
  
  /// <summary>
  ///   Change Color To.
  /// </summary>
  [DataMember]
  public DMD.ColorTo? ColorTo
  {
    get
    {
      return _Element?.GetObject<DMD.ColorTo,DXD.ColorTo>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ColorTo,DXD.ColorTo>(value);
    }
  }
  
}
