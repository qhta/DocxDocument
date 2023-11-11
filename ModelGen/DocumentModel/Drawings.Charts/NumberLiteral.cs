namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Literal.
/// </summary>
public partial class NumberLiteral: ModelElement<DXDC.NumberLiteral>
{
  public NumberLiteral(): base(){ }
  
  public NumberLiteral(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberLiteral(DXDC.NumberLiteral openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get
    {
      return _Element?.GetObject<DMDC.FormatCode,DXDC.FormatCode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FormatCode,DXDC.FormatCode>(value);
    }
  }
  
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
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
