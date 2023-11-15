namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drop-Down List Form Field Properties.
/// </summary>
public partial class DropDownListFormField: ModelElement<DXW.DropDownListFormField>
{
  public DropDownListFormField(): base(){ }
  
  public DropDownListFormField(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropDownListFormField(DXW.DropDownListFormField openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Drop-Down List Selection.
  /// </summary>
  [DataMember]
  public DMW.DropDownListSelection? DropDownListSelection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
  
  /// <summary>
  ///   Default Drop-Down List Item Index.
  /// </summary>
  [DataMember]
  public Int32? DefaultDropDownListItemIndex
  {
    get => _Element?.GetIntVal<Int32, DXW.DefaultDropDownListItemIndex>();
    set => _ExistingElement.SetIntVal<Int32, DXW.DefaultDropDownListItemIndex>(value);
  }
  
}
