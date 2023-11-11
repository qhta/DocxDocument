namespace DocumentModel;

/// <summary>
/// Specifies meaning od N4H field of <see cref="HyperlinkInfo"/>.
/// </summary>
public enum HyperlinkAction
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  None,   //  0 - None
  Change, //  1 - Change the link to new hyperlink value
  Remove, //  2 - Remove hyperlink from object
}
