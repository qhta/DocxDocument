namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextSpacingType Class.
/// </summary>
public partial class TextSpacingType: ModelElement<DXD.TextSpacingType>
{
  public TextSpacingType(): base(){ }
  
  public TextSpacingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextSpacingType(DXD.TextSpacingType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Spacing Percent.
  /// </summary>
  [DataMember]
  public Int32? SpacingPercent
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPercent>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPercent>(value);
  }
  
  
  /// <summary>
  ///   Spacing Points.
  /// </summary>
  [DataMember]
  public Int32? SpacingPoints
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPoints>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPoints>(value);
  }
  
}
