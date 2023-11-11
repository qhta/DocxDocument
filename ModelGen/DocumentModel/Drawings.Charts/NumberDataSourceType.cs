namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public partial class NumberDataSourceType: ModelElement<DXDC.NumberDataSourceType>
{
  public NumberDataSourceType(): base(){ }
  
  public NumberDataSourceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataSourceType(DXDC.NumberDataSourceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Number Reference.
  /// </summary>
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberReference,DXDC.NumberReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberReference,DXDC.NumberReference>(value);
    }
  }
  
  
  /// <summary>
  ///   Number Literal.
  /// </summary>
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberLiteral,DXDC.NumberLiteral>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberLiteral,DXDC.NumberLiteral>(value);
    }
  }
  
}
