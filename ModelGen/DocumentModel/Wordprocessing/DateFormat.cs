namespace DocumentModel.Wordprocessing;


/// <summary>
///   The element specifies the display format that shall be used to format any date entered into the nearest ancestor structured document tag in full DateTime format before displaying it in the structured document tag's run content.
/// </summary>
public partial class DateFormat: ModelElement<DXW.DateFormat>
{
  public DateFormat(): base(){ }
  
  public DateFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DateFormat(DXW.DateFormat openXmlElement): base(openXmlElement) { }
  
}
