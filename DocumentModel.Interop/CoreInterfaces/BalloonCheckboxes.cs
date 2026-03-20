using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface BalloonCheckboxes: InteropCollection<BalloonCheckbox>
{
  public string Name { get; }
}
