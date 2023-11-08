namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a drop-down list when displayed in the document.
/// </summary>
public partial class SdtContentDropDownList: ModelElement<DXW.SdtContentDropDownList>
{
  public SdtContentDropDownList(): base(){ }
  
  public SdtContentDropDownList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDropDownList(DXW.SdtContentDropDownList openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  [DataMember]
  public String? LastValue
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LastValue);
    }
    set
    {
      _ExistingElement.LastValue = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
