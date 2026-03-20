using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface IMsoDataLabels
{
  public object Select();
  public object Delete();
  public new IEnumerator GetEnumerator();
  public void Propagate(object Index);
}
