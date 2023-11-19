namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public partial class Hyperlink: ModelElement<DXW.Hyperlink>
{
  public Hyperlink(): base(){ }
  
  public Hyperlink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Hyperlink(DXW.Hyperlink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  [DataMember]
  public String? TargetFrame
  {
    get => _Element?.TargetFrame;
    set => _ExistingElement.TargetFrame = value;
  }
  
  
  /// <summary>
  ///   Associated String
  /// </summary>
  [DataMember]
  public String? Tooltip
  {
    get => _Element?.Tooltip;
    set => _ExistingElement.Tooltip = value;
  }
  
  
  /// <summary>
  ///   Location in Target Document
  /// </summary>
  [DataMember]
  public String? DocLocation
  {
    get => _Element?.DocLocation;
    set => _ExistingElement.DocLocation = value;
  }
  
  
  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  [DataMember]
  public Boolean? History
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  [DataMember]
  public String? Anchor
  {
    get => _Element?.Anchor;
    set => _ExistingElement.Anchor = value;
  }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
