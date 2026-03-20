using System.Collections;

namespace DocumentModel.Interop.Core;

public interface BalloonLabels: InteropCollection<object>
{
  public string Name { get; }
}
