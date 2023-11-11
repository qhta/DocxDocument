namespace DocumentModel.Wordprocessing;


/// <summary>
///   Text Box Form Field Properties.
/// </summary>
public partial class TextInput: ModelElement<DXW.TextInput>
{
  public TextInput(): base(){ }
  
  public TextInput(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextInput(DXW.TextInput openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Box Form Field Type.
  /// </summary>
  [DataMember]
  public DMW.TextBoxFormFieldKind? TextBoxFormFieldType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(_ExistingElement.GetFirstChild<DXW.TextBoxFormFieldType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextBoxFormFieldType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(itemElement, (DMW.TextBoxFormFieldKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxFormFieldType, DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>((DMW.TextBoxFormFieldKind)value));
    }
  }
  
  
  /// <summary>
  ///   Default Text Box Form Field String.
  /// </summary>
  [DataMember]
  public DMW.DefaultTextBoxFormFieldString? DefaultTextBoxFormFieldString
  {
    get
    {
      return _Element?.GetObject<DMW.DefaultTextBoxFormFieldString,DXW.DefaultTextBoxFormFieldString>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DefaultTextBoxFormFieldString,DXW.DefaultTextBoxFormFieldString>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Box Form Field Maximum Length.
  /// </summary>
  [DataMember]
  public Int16? MaxLength
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.MaxLength>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.MaxLength,System.Int16>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Text Box Form Field Formatting.
  /// </summary>
  [DataMember]
  public String? Format
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.Format>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.Format>(_ExistingElement, value);
    }
  }
  
}
