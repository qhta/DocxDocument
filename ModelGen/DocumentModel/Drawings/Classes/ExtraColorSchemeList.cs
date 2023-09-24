namespace DocumentModel.Drawings;


/// <summary>
///   This element is a container for the list of extra color schemes present in a document.
/// </summary>
public partial class ExtraColorSchemeList
{
  public ElementCollection<ExtraColorScheme>? Items { get; set; }
  
}
