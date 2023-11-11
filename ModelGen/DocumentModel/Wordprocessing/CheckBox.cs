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
    get
    {
      return _Element?.GetObject<DMW.FormFieldSize,DXW.FormFieldSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FormFieldSize,DXW.FormFieldSize>(value);
    }
  }
  
  [DataMember]
  public DMW.AutomaticallySizeFormField? AutomaticallySizeFormField
  {
    get
    {
      return _Element?.GetObject<DMW.AutomaticallySizeFormField,DXW.AutomaticallySizeFormField>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutomaticallySizeFormField,DXW.AutomaticallySizeFormField>(value);
    }
  }
  
  [DataMember]
  public DMW.DefaultCheckBoxFormFieldState? DefaultCheckBoxFormFieldState
  {
    get
    {
      return _Element?.GetObject<DMW.DefaultCheckBoxFormFieldState,DXW.DefaultCheckBoxFormFieldState>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DefaultCheckBoxFormFieldState,DXW.DefaultCheckBoxFormFieldState>(value);
    }
  }
  
  [DataMember]
  public DMW.Checked? Checked
  {
    get
    {
      return _Element?.GetObject<DMW.Checked,DXW.Checked>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Checked,DXW.Checked>(value);
    }
  }
  
}
