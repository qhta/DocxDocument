using System.Collections;

namespace DocumentModel.Interop.Core;

public interface BalloonCheckboxes: InteropCollection<BalloonCheckbox>
{
  public string Name { get; }
}
