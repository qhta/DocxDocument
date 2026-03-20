using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CommandBarControls: InteropDictionary<string, CommandBarControl>
{
  CommandBarControl Add(object Type, object Id, object Parameter, object Before, object Temporary);
}