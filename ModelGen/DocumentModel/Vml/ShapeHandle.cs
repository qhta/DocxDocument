namespace DocumentModel.Vml;


/// <summary>
///   Shape Handle.
/// </summary>
public partial class ShapeHandle: ModelElement<DXV.ShapeHandle>
{
  public ShapeHandle(): base(){ }
  
  public ShapeHandle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeHandle(DXV.ShapeHandle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Handle Position
  /// </summary>
  [DataMember]
  public String? Position
  {
    get => _Element?.Position;
    set => _ExistingElement.Position = value;
  }
  
  
  /// <summary>
  ///   Handle Polar Center
  /// </summary>
  [DataMember]
  public String? Polar
  {
    get => _Element?.Polar;
    set => _ExistingElement.Polar = value;
  }
  
  
  /// <summary>
  ///   Handle Coordinate Mapping
  /// </summary>
  [DataMember]
  public String? Map
  {
    get => _Element?.Map;
    set => _ExistingElement.Map = value;
  }
  
  
  /// <summary>
  ///   Invert Handle's X Position
  /// </summary>
  [DataMember]
  public Boolean? InvertX
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   Invert Handle's Y Position
  /// </summary>
  [DataMember]
  public Boolean? InvertY
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   Handle Inversion Toggle
  /// </summary>
  [DataMember]
  public Boolean? Switch
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   Handle X Position Range
  /// </summary>
  [DataMember]
  public String? XRange
  {
    get => _Element?.XRange;
    set => _ExistingElement.XRange = value;
  }
  
  
  /// <summary>
  ///   Handle Y Position Range
  /// </summary>
  [DataMember]
  public String? YRange
  {
    get => _Element?.YRange;
    set => _ExistingElement.YRange = value;
  }
  
  
  /// <summary>
  ///   Handle Polar Radius Range
  /// </summary>
  [DataMember]
  public String? RadiusRange
  {
    get => _Element?.RadiusRange;
    set => _ExistingElement.RadiusRange = value;
  }
  
}
