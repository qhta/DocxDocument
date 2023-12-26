namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextBodyProperties Class.
/// </summary>
public partial class TextBodyProperties: ModelElement<DXO13DCS.TextBodyProperties>
{
  public TextBodyProperties(): base(){ }
  
  public TextBodyProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBodyProperties(DXO13DCS.TextBodyProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get => _Element?.Rotation?.Value;
    set => _ExistingElement.Rotation = value;
  }
  
  
  /// <summary>
  ///   Paragraph Spacing
  /// </summary>
  [DataMember]
  public Boolean? UseParagraphSpacing
  {
    get => _Element?.UseParagraphSpacing?.Value;
    set => _ExistingElement.UseParagraphSpacing = value;
  }
  
  
  /// <summary>
  ///   Left Inset
  /// </summary>
  [DataMember]
  public Int32? LeftInset
  {
    get => _Element?.LeftInset?.Value;
    set => _ExistingElement.LeftInset = value;
  }
  
  
  /// <summary>
  ///   Top Inset
  /// </summary>
  [DataMember]
  public Int32? TopInset
  {
    get => _Element?.TopInset?.Value;
    set => _ExistingElement.TopInset = value;
  }
  
  
  /// <summary>
  ///   Right Inset
  /// </summary>
  [DataMember]
  public Int32? RightInset
  {
    get => _Element?.RightInset?.Value;
    set => _ExistingElement.RightInset = value;
  }
  
  
  /// <summary>
  ///   Bottom Inset
  /// </summary>
  [DataMember]
  public Int32? BottomInset
  {
    get => _Element?.BottomInset?.Value;
    set => _ExistingElement.BottomInset = value;
  }
  
  
  /// <summary>
  ///   Number of Columns
  /// </summary>
  [DataMember]
  public Int32? ColumnCount
  {
    get => _Element?.ColumnCount?.Value;
    set => _ExistingElement.ColumnCount = value;
  }
  
  
  /// <summary>
  ///   Space Between Columns
  /// </summary>
  [DataMember]
  public Int32? ColumnSpacing
  {
    get => _Element?.ColumnSpacing?.Value;
    set => _ExistingElement.ColumnSpacing = value;
  }
  
  
  /// <summary>
  ///   Columns Right-To-Left
  /// </summary>
  [DataMember]
  public Boolean? RightToLeftColumns
  {
    get => _Element?.RightToLeftColumns?.Value;
    set => _ExistingElement.RightToLeftColumns = value;
  }
  
  
  /// <summary>
  ///   From WordArt
  /// </summary>
  [DataMember]
  public Boolean? FromWordArt
  {
    get => _Element?.FromWordArt?.Value;
    set => _ExistingElement.FromWordArt = value;
  }
  
  
  /// <summary>
  ///   Anchor Center
  /// </summary>
  [DataMember]
  public Boolean? AnchorCenter
  {
    get => _Element?.AnchorCenter?.Value;
    set => _ExistingElement.AnchorCenter = value;
  }
  
  
  /// <summary>
  ///   Force Anti-Alias
  /// </summary>
  [DataMember]
  public Boolean? ForceAntiAlias
  {
    get => _Element?.ForceAntiAlias?.Value;
    set => _ExistingElement.ForceAntiAlias = value;
  }
  
  
  /// <summary>
  ///   Text Upright
  /// </summary>
  [DataMember]
  public Boolean? UpRight
  {
    get => _Element?.UpRight?.Value;
    set => _ExistingElement.UpRight = value;
  }
  
  
  /// <summary>
  ///   Compatible Line Spacing
  /// </summary>
  [DataMember]
  public Boolean? CompatibleLineSpacing
  {
    get => _Element?.CompatibleLineSpacing?.Value;
    set => _ExistingElement.CompatibleLineSpacing = value;
  }
  
  
  /// <summary>
  ///   Preset Text Shape.
  /// </summary>
  [DataMember]
  public DMD.PresetTextWarp? PresetTextWarp
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
