namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public partial class ImageControl: ModelElement<DXO10CUI.ImageControl>
{
  public ImageControl(): base(){ }
  
  public ImageControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageControl(DXO10CUI.ImageControl openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? QualifiedId
  {
    get => HexIntConverter.GetValue(_Element?.QualifiedId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get => _Element?.Enabled?.Value;
    set => _ExistingElement.Enabled = value;
  }
  
  
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get => _Element?.GetEnabled;
    set => _ExistingElement.GetEnabled = value;
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
  
  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Image
  {
    get => _Element?.Image;
    set => _ExistingElement.Image = value;
  }
  
  
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get => _Element?.ImageMso;
    set => _ExistingElement.ImageMso = value;
  }
  
  
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get => _Element?.GetImage;
    set => _ExistingElement.GetImage = value;
  }
  
  
  /// <summary>
  ///   altText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? AltText
  {
    get => _Element?.AltText;
    set => _ExistingElement.AltText = value;
  }
  
  
  /// <summary>
  ///   getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetAltText
  {
    get => _Element?.GetAltText;
    set => _ExistingElement.GetAltText = value;
  }
  
}
