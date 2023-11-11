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
    get
    {
      return _Element?.GetObject<DMW.DropDownListSelection,DXW.DropDownListSelection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DropDownListSelection,DXW.DropDownListSelection>(value);
    }
  }
  
  
  /// <summary>
  ///   Default Drop-Down List Item Index.
  /// </summary>
  [DataMember]
  public Int32? DefaultDropDownListItemIndex
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.DefaultDropDownListItemIndex>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.DefaultDropDownListItemIndex,System.Int32>(_ExistingElement, value);
    }
  }
  
}
