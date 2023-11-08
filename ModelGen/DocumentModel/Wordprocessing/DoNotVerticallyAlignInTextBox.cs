namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Vertical Alignment in Textboxes.
/// </summary>
public partial class DoNotVerticallyAlignInTextBox: ModelElement<DXW.DoNotVerticallyAlignInTextBox>
{
  public DoNotVerticallyAlignInTextBox(): base(){ }
  
  public DoNotVerticallyAlignInTextBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotVerticallyAlignInTextBox(DXW.DoNotVerticallyAlignInTextBox openXmlElement): base(openXmlElement) { }
  
}
