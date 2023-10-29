namespace DocumentModel;

/// <summary>
/// Specifies that one or more types of objects, when inserted into a WordprocessingML document, 
/// are automatically be labeled with a specific caption defined using the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaptions
{
  public AutoCaptions(DXW.AutoCaptions openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.AutoCaptions _Element { get; private set; }
}
