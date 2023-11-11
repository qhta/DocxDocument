namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TickLabels Class.
/// </summary>
public partial class TickLabels: ModelElement<DXO16DCD.TickLabels>
{
  public TickLabels(): base(){ }
  
  public TickLabels(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TickLabels(DXO16DCD.TickLabels openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
