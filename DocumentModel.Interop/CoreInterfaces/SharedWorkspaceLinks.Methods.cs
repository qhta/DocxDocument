using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceLinks
{
  public SharedWorkspaceLink Add(string URL, object Description, object Notes);
}
