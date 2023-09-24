namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a list of three line styles for use within a theme.  The three line styles are arranged in order from subtle to moderate to intense versions of lines.  This list makes up part of the style matrix.
/// </summary>
public partial class LineStyleList
{
  public ElementCollection<Outline>? Items { get; set; }
  
}
