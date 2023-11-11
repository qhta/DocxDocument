namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public partial class StrRefExtension: ModelElement<DXDC.StrRefExtension>
{
  public StrRefExtension(): base(){ }
  
  public StrRefExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrRefExtension(DXDC.StrRefExtension openXmlElement): base(openXmlElement) { }
  
  
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
