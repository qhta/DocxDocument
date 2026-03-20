using System.Collections;

namespace DocumentModel.Interop.Core;

public interface BalloonCheckboxes: InteropCollection<BalloonCheckbox>
{
  string Name { get; }
}