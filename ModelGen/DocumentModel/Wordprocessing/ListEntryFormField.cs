namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drop-Down List Entry.
/// </summary>
public partial class ListEntryFormField: ModelElement<DXW.ListEntryFormField>
{
  public ListEntryFormField(): base(){ }
  
  public ListEntryFormField(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ListEntryFormField(DXW.ListEntryFormField openXmlElement): base(openXmlElement) { }
  
}
