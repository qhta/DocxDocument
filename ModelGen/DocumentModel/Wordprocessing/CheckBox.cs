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
      var element = _Element?.GetFirstChild<DXW.FormFieldSize>();
      if (element != null)
        return FormFieldSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FormFieldSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormFieldSizeConverter.CreateOpenXmlElement<DXW.FormFieldSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AutomaticallySizeFormField? AutomaticallySizeFormField
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AutomaticallySizeFormField>();
      if (element != null)
        return AutomaticallySizeFormFieldConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutomaticallySizeFormField>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutomaticallySizeFormFieldConverter.CreateOpenXmlElement<DXW.AutomaticallySizeFormField>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DefaultCheckBoxFormFieldState? DefaultCheckBoxFormFieldState
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>();
      if (element != null)
        return DefaultCheckBoxFormFieldStateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultCheckBoxFormFieldStateConverter.CreateOpenXmlElement<DXW.DefaultCheckBoxFormFieldState>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Checked? Checked
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Checked>();
      if (element != null)
        return CheckedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Checked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckedConverter.CreateOpenXmlElement<DXW.Checked>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
