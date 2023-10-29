namespace DocumentModel;

/// <summary>
/// Specifies that one or more types of objects, when inserted into a WordprocessingML document, 
/// are automatically be labeled with a specific caption defined using the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaptions
{
  public AutoCaptions(DXW.AutoCaptions autocaptions)
  {
    _AutoCaptions = autocaptions;
  }

  internal DXW.AutoCaptions _AutoCaptions { get; private set; }
}
