namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartStringValue Class.
/// </summary>
public partial class ChartStringValue: ModelElement<DXO16DCD.ChartStringValue>
{
  public ChartStringValue(): base(){ }
  
  public ChartStringValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartStringValue(DXO16DCD.ChartStringValue openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get
    {
      return _Element?.Index?.Value;
    }
    set
    {
      _ExistingElement.Index = value;
    }
  }
  
}
