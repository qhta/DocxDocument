namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the ChartText Class.
/// </summary>
public partial class ChartText: ModelElement<DXO13DC.ChartText>
{
  public ChartText(): base(){ }
  
  public ChartText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartText(DXO13DC.ChartText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   String Reference.
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
  ///   Rich Text.
  /// </summary>
  [DataMember]
  public DMDC.RichText? RichText
  {
    get
    {
      return _Element?.GetObject<DMDC.RichText,DXDC.RichText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.RichText,DXDC.RichText>(value);
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
