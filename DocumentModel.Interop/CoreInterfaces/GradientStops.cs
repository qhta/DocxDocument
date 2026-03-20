using System.Collections;

namespace DocumentModel.Interop.Core;

public interface GradientStops: InteropCollection<GradientStop>
{
  void Delete(int Index);
  void Insert(int RGB, float Position, float Transparency, int Index);
  void Insert2(int RGB, float Position, float Transparency, int Index, float Brightness);
}