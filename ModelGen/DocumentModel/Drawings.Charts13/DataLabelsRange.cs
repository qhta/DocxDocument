namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelsRange Class.
/// </summary>
public partial class DataLabelsRange: ModelElement<DXO13DC.DataLabelsRange>
{
  public DataLabelsRange(): base(){ }
  
  public DataLabelsRange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelsRange(DXO13DC.DataLabelsRange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Formula.
  /// </summary>
  [DataMember]
  public DMDC13.Formula? Formula
  {
    get
    {
      return _Element?.GetObject<DMDC13.Formula,DXO13DC.Formula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.Formula,DXO13DC.Formula>(value);
    }
  }
  
  
  /// <summary>
  ///   DataLabelsRangeChache.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabelsRangeChache? DataLabelsRangeChache
  {
    get
    {
      return _Element?.GetObject<DMDC13.DataLabelsRangeChache,DXO13DC.DataLabelsRangeChache>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.DataLabelsRangeChache,DXO13DC.DataLabelsRangeChache>(value);
    }
  }
  
}
