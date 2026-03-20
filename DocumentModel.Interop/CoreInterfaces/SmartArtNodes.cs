using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtNodes: InteropDictionary<string, SmartArtNode>
{
  public SmartArtNode Add();
}
