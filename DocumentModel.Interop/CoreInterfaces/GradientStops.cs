using System.Collections;

namespace DocumentModel.Interop.Core;

public interface GradientStops: InteropObject, IEnumerable
{
  GradientStop this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  void Delete(int Index);
  void Insert(int RGB, float Position, float Transparency, int Index);
  void Insert2(int RGB, float Position, float Transparency, int Index, float Brightness);
}