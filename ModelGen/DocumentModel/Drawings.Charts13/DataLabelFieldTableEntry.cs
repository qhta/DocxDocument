namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public partial class DataLabelFieldTableEntry: ModelElement<DXO13DC.DataLabelFieldTableEntry>
{
  public DataLabelFieldTableEntry(): base(){ }
  
  public DataLabelFieldTableEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelFieldTableEntry(DXO13DC.DataLabelFieldTableEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  [DataMember]
  public DMDC13.TextFieldGuid? TextFieldGuid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.TextFieldGuid>();
      if (element != null)
        return TextFieldGuidConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.TextFieldGuid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFieldGuidConverter.CreateOpenXmlElement<DXO13DC.TextFieldGuid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
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
  ///   DataLabelFieldTableCache.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.DataLabelFieldTableCache>();
      if (element != null)
        return DataLabelFieldTableCacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabelFieldTableCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableCacheConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTableCache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
