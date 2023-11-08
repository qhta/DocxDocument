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
    get
    {
      return _ExistingElement.GetFirstChild<DXO19DC.BooleanFalse>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO19DC.BooleanFalse>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO19DC.BooleanFalse();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
