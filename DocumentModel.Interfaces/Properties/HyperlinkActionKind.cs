namespace DocumentModel.Properties;
/// <summary>
/// Specifies meaning od N4H field of <see cref="IHyperlinkInfo"/>.
/// </summary>
public enum HyperlinkActionKind
{
  None,   //  0 - None
  Change, //  1 - Change the link to new hyperlink value
  Remove, //  2 - Remove hyperlink from object
}
