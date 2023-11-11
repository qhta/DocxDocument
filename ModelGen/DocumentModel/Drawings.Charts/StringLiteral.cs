namespace DocumentModel.Drawings.Charts;


/// <summary>
///   String Literal.
/// </summary>
public partial class StringLiteral: ModelElement<DXDC.StringLiteral>
{
  public StringLiteral(): base(){ }
  
  public StringLiteral(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringLiteral(DXDC.StringLiteral openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get
    {
      return _Element?.GetObject<DMDC.PointCount,DXDC.PointCount>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PointCount,DXDC.PointCount>(value);
    }
  }
  
  [DataMember]
  public DMDC.StrDataExtensionList? StrDataExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.StrDataExtensionList,DXDC.StrDataExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StrDataExtensionList,DXDC.StrDataExtensionList>(value);
    }
  }
  
}
