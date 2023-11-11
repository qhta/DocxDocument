namespace DocumentModel.Math;


/// <summary>
///   Fraction Properties.
/// </summary>
public partial class FractionProperties: ModelElement<DXM.FractionProperties>
{
  public FractionProperties(): base(){ }
  
  public FractionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FractionProperties(DXM.FractionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fraction type.
  /// </summary>
  [DataMember]
  public DMM.FractionTypeKind? FractionType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionTypeKind>(_ExistingElement.GetFirstChild<DXM.FractionType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.FractionType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionTypeKind>(itemElement, (DMM.FractionTypeKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.FractionType, DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionTypeKind>((DMM.FractionTypeKind)value));
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
