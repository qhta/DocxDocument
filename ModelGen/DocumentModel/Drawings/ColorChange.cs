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
        _ExistingElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.ColorFrom>();
      if (element != null)
        return ColorFromConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ColorFrom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorFromConverter.CreateOpenXmlElement<DXD.ColorFrom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ColorTo>();
      if (element != null)
        return ColorToConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ColorTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorToConverter.CreateOpenXmlElement<DXD.ColorTo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
