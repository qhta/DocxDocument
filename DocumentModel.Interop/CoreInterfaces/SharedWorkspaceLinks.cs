using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLinks: InteropCollection<SharedWorkspaceLink>
{
  public SharedWorkspaceLink Add(string URL, object Description, object Notes);
  public bool ItemCountExceeded { get; }
}
