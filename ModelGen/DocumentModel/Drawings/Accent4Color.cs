namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 4 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent4Color: ModelElement<DXD.Accent4Color>
{
  public Accent4Color(): base(){ }
  
  public Accent4Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent4Color(DXD.Accent4Color openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.RgbColorModelPercentage>();
      if (element != null)
        return RgbColorModelPercentageConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelPercentageConverter.CreateOpenXmlElement<DXD.RgbColorModelPercentage>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.RgbColorModelHex>();
      if (element != null)
        return RgbColorModelHexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelHexConverter.CreateOpenXmlElement<DXD.RgbColorModelHex>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.HslColor? HslColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HslColor>();
      if (element != null)
        return HslColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HslColorConverter.CreateOpenXmlElement<DXD.HslColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SystemColor? SystemColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SystemColor>();
      if (element != null)
        return SystemColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SystemColorConverter.CreateOpenXmlElement<DXD.SystemColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PresetColorKind? PresetColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
  }
  
}
