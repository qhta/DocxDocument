namespace DocumentModel.Wordprocessing;


/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public partial class CheckBox: ModelElement<DXW.CheckBox>
{
  public CheckBox(): base(){ }
  
  public CheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckBox(DXW.CheckBox openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.FormFieldSize? FormFieldSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
  }
  
  [DataMember]
  public DMW.AutomaticallySizeFormField? AutomaticallySizeFormField
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  [DataMember]
  public DMW.DefaultCheckBoxFormFieldState? DefaultCheckBoxFormFieldState
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  [DataMember]
  public DMW.Checked? Checked
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
