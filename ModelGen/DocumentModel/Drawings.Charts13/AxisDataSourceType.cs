namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the AxisDataSourceType Class.
/// </summary>
public partial class AxisDataSourceType: ModelElement<DXO13DC.AxisDataSourceType>
{
  public AxisDataSourceType(): base(){ }
  
  public AxisDataSourceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisDataSourceType(DXO13DC.AxisDataSourceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Multi Level String Reference.
  /// </summary>
  [DataMember]
  public DMDC.MultiLevelStringReference? MultiLevelStringReference
  {
    get
    {
      return _Element?.GetObject<DMDC.MultiLevelStringReference,DXDC.MultiLevelStringReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MultiLevelStringReference,DXDC.MultiLevelStringReference>(value);
    }
  }
  
  
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
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      return _Element?.GetObject<DMDC.StringReference,DXDC.StringReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringReference,DXDC.StringReference>(value);
    }
  }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get
    {
      return _Element?.GetObject<DMDC.StringLiteral,DXDC.StringLiteral>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringLiteral,DXDC.StringLiteral>(value);
    }
  }
  
}
