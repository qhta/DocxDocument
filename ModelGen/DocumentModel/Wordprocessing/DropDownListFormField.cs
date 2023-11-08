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
      var element = _Element?.GetFirstChild<DXW.DropDownListSelection>();
      if (element != null)
        return DropDownListSelectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DropDownListSelection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropDownListSelectionConverter.CreateOpenXmlElement<DXW.DropDownListSelection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.DefaultDropDownListItemIndex,System.Int32>(openXmlElement, value);
    }
  }
  
}
