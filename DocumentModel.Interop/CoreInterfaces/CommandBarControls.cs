using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CommandBarControls: InteropObject, IEnumerable
{
  CommandBarControl Add(object Type, object Id, object Parameter, object Before, object Temporary);
  int Count { get; }
  CommandBarControl this[object Index] { get; }
  new IEnumerator GetEnumerator();
}