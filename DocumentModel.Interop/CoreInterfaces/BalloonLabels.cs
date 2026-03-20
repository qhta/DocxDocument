using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface BalloonLabels: InteropCollection<object>
{
  public string Name { get; }
}
