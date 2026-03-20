using System.Collections;

namespace DocumentModel.Interop.Core;

public interface GradientStops: InteropCollection<GradientStop>
{
  public void Delete(int Index);
  public void Insert(int RGB, float Position, float Transparency, int Index);
  public void Insert2(int RGB, float Position, float Transparency, int Index, float Brightness);
}
