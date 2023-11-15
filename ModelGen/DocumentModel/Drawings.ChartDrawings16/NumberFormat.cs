namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the NumberFormat Class.
/// </summary>
public partial class NumberFormat: ModelElement<DXO16DCD.NumberFormat>
{
  public NumberFormat(): base(){ }
  
  public NumberFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberFormat(DXO16DCD.NumberFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get => _Element?.FormatCode;
    set => _ExistingElement.FormatCode = value;
  }
  
  
  /// <summary>
  ///   sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? SourceLinked
  {
    get => _Element?.SourceLinked?.Value;
    set => _ExistingElement.SourceLinked = value;
  }
  
}
