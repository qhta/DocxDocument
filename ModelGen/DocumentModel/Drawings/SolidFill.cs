namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a solid color fill. The shape is filled entirely with the specified color.
/// </summary>
public partial class SolidFill: ModelElement<DXD.SolidFill>
{
  public SolidFill(): base(){ }
  
  public SolidFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SolidFill(DXD.SolidFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
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
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
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
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
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
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
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
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  [DataMember]
  public DMD.SchemeColorKind? SchemeColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
    }
  }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
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
