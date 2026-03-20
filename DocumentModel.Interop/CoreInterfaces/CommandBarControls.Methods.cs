using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface CommandBarControls
{
  public CommandBarControl Add(object Type, object Id, object Parameter, object Before, object Temporary);
}
