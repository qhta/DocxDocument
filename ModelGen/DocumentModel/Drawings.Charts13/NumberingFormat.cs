namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the NumberingFormat Class.
/// </summary>
public partial class NumberingFormat: ModelElement<DXO13DC.NumberingFormat>
{
  public NumberingFormat(): base(){ }
  
  public NumberingFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingFormat(DXO13DC.NumberingFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Number Format Code
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get => _Element?.FormatCode;
    set => _ExistingElement.FormatCode = value;
  }
  
  
  /// <summary>
  ///   Linked to Source
  /// </summary>
  [DataMember]
  public Boolean? SourceLinked
  {
    get => _Element?.SourceLinked?.Value;
    set => _ExistingElement.SourceLinked = value;
  }
  
}
