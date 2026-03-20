using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLinks: InteropCollection<SharedWorkspaceLink>
{
  SharedWorkspaceLink Add(string URL, object Description, object Notes);
  bool ItemCountExceeded { get; }
}