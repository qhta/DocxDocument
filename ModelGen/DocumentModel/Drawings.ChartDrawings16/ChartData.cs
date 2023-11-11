namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartData Class.
/// </summary>
public partial class ChartData: ModelElement<DXO16DCD.ChartData>
{
  public ChartData(): base(){ }
  
  public ChartData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartData(DXO16DCD.ChartData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExternalData.
  /// </summary>
  [DataMember]
  public DMDCD16.ExternalData? ExternalData
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExternalData,DXO16DCD.ExternalData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExternalData,DXO16DCD.ExternalData>(value);
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
