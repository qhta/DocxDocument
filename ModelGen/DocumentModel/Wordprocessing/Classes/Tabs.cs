namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a sequence of custom tab stops which shall be used for any tab characters in the current paragraph.
/// </summary>
public partial class Tabs
{
  public ElementCollection<TabStop>? Items { get; set; }
  
}
