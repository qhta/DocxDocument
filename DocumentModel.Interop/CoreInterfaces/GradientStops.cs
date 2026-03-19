using System.Collections;

namespace DocumentModel.Interop.Core;

public interface GradientStops: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  GradientStop this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  void Delete(int Index = -1);
  void Insert(int RGB, float Position, float Transparency = 0f, int Index = -1);
  void Insert2(int RGB, float Position, float Transparency = 0f, int Index = -1, float Brightness = 0f);
}