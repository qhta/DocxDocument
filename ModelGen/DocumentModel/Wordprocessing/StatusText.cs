namespace DocumentModel.Wordprocessing;


/// <summary>
///   Associated Status Text.
/// </summary>
public partial class StatusText: ModelElement<DXW.StatusText>
{
  public StatusText(): base(){ }
  
  public StatusText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StatusText(DXW.StatusText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Status Text Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
