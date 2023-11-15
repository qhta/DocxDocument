namespace DocumentModel.Word10;


/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public partial class CheckBoxSymbolType: ModelElement<DXO10W.CheckBoxSymbolType>
{
  public CheckBoxSymbolType(): base(){ }
  
  public CheckBoxSymbolType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckBoxSymbolType(DXO10W.CheckBoxSymbolType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Font
  {
    get => _Element?.Font;
    set => _ExistingElement.Font = value;
  }
  
  
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? Val
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
}
