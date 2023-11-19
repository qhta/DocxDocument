namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a reference to a set of character forms defined within the font to be used as a stylistic set. For more information about stylistic sets, see OpenType.
/// </summary>
public partial class StyleSet: ModelElement<DXO10W.StyleSet>
{
  public StyleSet(): base(){ }
  
  public StyleSet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleSet(DXO10W.StyleSet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
