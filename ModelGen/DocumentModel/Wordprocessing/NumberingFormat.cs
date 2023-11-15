namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote Numbering Format.
/// </summary>
public partial class NumberingFormat: ModelElement<DXW.NumberingFormat>
{
  public NumberingFormat(): base(){ }
  
  public NumberingFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingFormat(DXW.NumberingFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   format, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Format
  {
    get => _Element?.Format;
    set => _ExistingElement.Format = value;
  }
  
}
