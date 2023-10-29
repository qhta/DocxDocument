namespace DocumentModel;

/// <summary>
/// Specifies what type(s) of objects shall automatically labelled with captions (§17.15.1.17), 
/// and with which captions the specified objects shall be labelled as defined in the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaption
{
  public AutoCaption(DXW.AutoCaption autoCaption)
  {
    _AutoCaption = autoCaption;
  }

  internal DXW.AutoCaption _AutoCaption { get; private set; }

  public string? Name
  {
    get => _AutoCaption.Name;
    set => _AutoCaption.Name = value;
  }

  public string? Caption
  {
    get => _AutoCaption.Caption;
    set => _AutoCaption.Caption = value;
  }
}
