namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Data Class.
/// </summary>
public partial class Data: ModelElement<DXO16DCD.Data>
{
  public Data(): base(){ }
  
  public Data(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Data(DXO16DCD.Data openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
