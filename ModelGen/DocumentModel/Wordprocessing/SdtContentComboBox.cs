namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a combo box when displayed in the document.
/// </summary>
public partial class SdtContentComboBox: ModelElement<DXW.SdtContentComboBox>
{
  public SdtContentComboBox(): base(){ }
  
  public SdtContentComboBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentComboBox(DXW.SdtContentComboBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Combo Box Last Saved Value
  /// </summary>
  [DataMember]
  public String? LastValue
  {
    get => _Element?.LastValue;
    set => _ExistingElement.LastValue = value;
  }
  
}
