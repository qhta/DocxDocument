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
      var element = _Element?.GetFirstChild<DXO13DC.Formula>();
      if (element != null)
        return FormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaConverter.CreateOpenXmlElement<DXO13DC.Formula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13DC.DataLabelsRangeChache>();
      if (element != null)
        return DataLabelsRangeChacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabelsRangeChache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsRangeChacheConverter.CreateOpenXmlElement<DXO13DC.DataLabelsRangeChache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
