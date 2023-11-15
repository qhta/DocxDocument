namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Format.
/// </summary>
public partial class NumberingFormat: ModelElement<DXDC.NumberingFormat>
{
  public NumberingFormat(): base(){ }
  
  public NumberingFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingFormat(DXDC.NumberingFormat openXmlElement): base(openXmlElement) { }
  
  
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
