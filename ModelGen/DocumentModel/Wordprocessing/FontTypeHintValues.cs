namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontTypeHintValues enumeration.
/// </summary>
public partial class FontTypeHintValues: ModelElement<DXW.FontTypeHintValues>
{
  public FontTypeHintValues(): base(){ }
  
  public FontTypeHintValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontTypeHintValues(DXW.FontTypeHintValues openXmlElement): base(openXmlElement) { }
  
}
