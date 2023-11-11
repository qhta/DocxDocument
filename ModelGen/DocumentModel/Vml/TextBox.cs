namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextBox Class.
/// </summary>
public partial class TextBox: ModelElement<DXV.TextBox>
{
  public TextBox(): base(){ }
  
  public TextBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBox(DXV.TextBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Box Inset
  /// </summary>
  [DataMember]
  public String? Inset
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Inset);
    }
    set
    {
      _ExistingElement.Inset = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Box Single-Click Selection Toggle
  /// </summary>
  [DataMember]
  public Boolean? SingleClick
  {
    get
    {
      return _Element?.SingleClick?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SingleClick = value;
      else
        _ExistingElement.SingleClick = null;
    }
  }
  
  [DataMember]
  public DMW.TextBoxContent? TextBoxContent
  {
    get
    {
      return _Element?.GetObject<DMW.TextBoxContent,DXW.TextBoxContent>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TextBoxContent,DXW.TextBoxContent>(value);
    }
  }
  
}
