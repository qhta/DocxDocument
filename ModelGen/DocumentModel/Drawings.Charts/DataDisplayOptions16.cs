namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DataDisplayOptions16 Class.
/// </summary>
public partial class DataDisplayOptions16: ModelElement<DXDC.DataDisplayOptions16>
{
  public DataDisplayOptions16(): base(){ }
  
  public DataDisplayOptions16(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataDisplayOptions16(DXDC.DataDisplayOptions16 openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BooleanFalse.
  /// </summary>
  [DataMember]
  public Boolean? BooleanFalse
  {
    get => _Element?.GetBoolVal<DXO19DC.BooleanFalse>();
    set => _ExistingElement.SetBoolVal<DXO19DC.BooleanFalse>(value);
  }
  
}
