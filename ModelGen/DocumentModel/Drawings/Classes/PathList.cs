namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the entire path that is to make up a single geometric shape. The pathLst can consist of many individual paths within it.
/// </summary>
public partial class PathList
{
  public ElementCollection<Path>? Items { get; set; }
  
}
