namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the AxisUnits Class.
/// </summary>
public partial class AxisUnits: ModelElement<DXO16DCD.AxisUnits>
{
  public AxisUnits(): base(){ }
  
  public AxisUnits(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisUnits(DXO16DCD.AxisUnits openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AxisUnitsLabel.
  /// </summary>
  [DataMember]
  public DMDCD16.AxisUnitsLabel? AxisUnitsLabel
  {
    get
    {
      return _Element?.GetObject<DMDCD16.AxisUnitsLabel,DXO16DCD.AxisUnitsLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.AxisUnitsLabel,DXO16DCD.AxisUnitsLabel>(value);
    }
  }
  
  
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
