using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface RulerLevels2: InteropDictionary<string, RulerLevel2>
{
  RulerLevel2 Item(object Index);
}