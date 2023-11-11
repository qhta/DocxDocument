namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MultiLvlStrRefExtension Class.
/// </summary>
public partial class MultiLvlStrRefExtension: ModelElement<DXDC.MultiLvlStrRefExtension>
{
  public MultiLvlStrRefExtension(): base(){ }
  
  public MultiLvlStrRefExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MultiLvlStrRefExtension(DXDC.MultiLvlStrRefExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.FullReference? FullReference
  {
    get
    {
      return _Element?.GetObject<DMDC13.FullReference,DXO13DC.FullReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FullReference,DXO13DC.FullReference>(value);
    }
  }
  
  [DataMember]
  public DMDC13.LevelReference? LevelReference
  {
    get
    {
      return _Element?.GetObject<DMDC13.LevelReference,DXO13DC.LevelReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.LevelReference,DXO13DC.LevelReference>(value);
    }
  }
  
  [DataMember]
  public DMDC13.FormulaReference? FormulaReference
  {
    get
    {
      return _Element?.GetObject<DMDC13.FormulaReference,DXO13DC.FormulaReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FormulaReference,DXO13DC.FormulaReference>(value);
    }
  }
  
}
