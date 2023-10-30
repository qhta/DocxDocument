namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies what type(s) of objects shall automatically labelled with captions (§17.15.1.17), 
/// and with which captions the specified objects shall be labelled as defined in the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaption
{
  public AutoCaption(DXW.AutoCaption openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.AutoCaption _Element { get; private set; }

  public string? Name
  {
    get => _Element.Name;
    set => _Element.Name = value;
  }

  public string? Caption
  {
    get => _Element.Caption;
    set => _Element.Caption = value;
  }
}
