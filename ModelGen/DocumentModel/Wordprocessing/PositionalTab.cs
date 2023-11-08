namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an absolute position tab character shall be placed at the current location in the run content. An absolute position tab is a character which is used to advance the position on the current line of text when displaying this WordprocessingML content, using the following logic:
/// </summary>
public partial class PositionalTab: ModelElement<DXW.PositionalTab>
{
  public PositionalTab(): base(){ }
  
  public PositionalTab(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PositionalTab(DXW.PositionalTab openXmlElement): base(openXmlElement) { }
  
}
