namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the given run shall always behave as if it is hidden, even when hidden text is being displayed in the current document.
/// </summary>
public partial class SpecVanish: ModelElement<DXW.SpecVanish>
{
  public SpecVanish(): base(){ }
  
  public SpecVanish(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpecVanish(DXW.SpecVanish openXmlElement): base(openXmlElement) { }
  
}
