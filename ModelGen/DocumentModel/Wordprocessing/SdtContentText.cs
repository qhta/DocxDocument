namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public partial class SdtContentText: ModelElement<DXW.SdtContentText>
{
  public SdtContentText(): base(){ }
  
  public SdtContentText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentText(DXW.SdtContentText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  [DataMember]
  public Boolean? MultiLine
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.MultiLine);
    }
    set
    {
      _ExistingElement.MultiLine = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
