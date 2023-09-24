namespace DocumentModel.Wordprocessing;


/// <summary>
///   Font Table Root Element.
/// </summary>
public partial class Fonts
{
  public ElementCollection<Font>? Items { get; set; }
  
}
