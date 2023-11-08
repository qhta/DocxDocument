namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the DataLabelHidden Class.
/// </summary>
public partial class DataLabelHidden: ModelElement<DXO16DCD.DataLabelHidden>
{
  public DataLabelHidden(): base(){ }
  
  public DataLabelHidden(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelHidden(DXO16DCD.DataLabelHidden openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Idx
  {
    get
    {
      return _Element?.Idx?.Value;
    }
    set
    {
      _ExistingElement.Idx = value;
    }
  }
  
}
