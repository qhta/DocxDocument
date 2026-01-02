namespace DocumentModel.Wordprocessing;

/// <summary>
/// This element specifies the presence of information about captions in a given WordprocessingML document. 
/// This information is divided into two components: 
/// <list type="bullet">
/// <item>
/// The child element caption defines the format for a single type of caption to be automatically added to the document. 
/// </item>
/// <item>
/// The child element autoCaptions defines the types of objects to which a caption format shall automatically be applied. 
/// </item>
/// </list>
/// </summary>
public class Captions : ModelElement
{
  public Caption? Caption { get; set; }
  public AutoCaptions? AutoCaptions { get; set; }
}