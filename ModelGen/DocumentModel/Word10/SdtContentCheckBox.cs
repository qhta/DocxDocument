namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that the parent structured document tag is a checkbox when displayed in the document. The parent structured document tag contents MUST contain a single character and optionally an additional character in a deleted run.
/// </summary>
public partial class SdtContentCheckBox: ModelElement<DXO10W.SdtContentCheckBox>
{
  public SdtContentCheckBox(): base(){ }
  
  public SdtContentCheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentCheckBox(DXO10W.SdtContentCheckBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Checked.
  /// </summary>
  [DataMember]
  public DMW10.Checked? Checked
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.OnOffType");
  }
  
  
  /// <summary>
  ///   CheckedState.
  /// </summary>
  [DataMember]
  public DMW10.CheckedState? CheckedState
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType");
  }
  
  
  /// <summary>
  ///   UncheckedState.
  /// </summary>
  [DataMember]
  public DMW10.UncheckedState? UncheckedState
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType");
  }
  
}
