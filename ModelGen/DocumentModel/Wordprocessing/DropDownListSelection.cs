namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drop-Down List Selection.
/// </summary>
public partial class DropDownListSelection: ModelElement<DXW.DropDownListSelection>
{
  public DropDownListSelection(): base(){ }
  
  public DropDownListSelection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropDownListSelection(DXW.DropDownListSelection openXmlElement): base(openXmlElement) { }
  
}
