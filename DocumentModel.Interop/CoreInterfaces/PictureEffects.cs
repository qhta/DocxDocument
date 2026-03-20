using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PictureEffects: InteropObject, IEnumerable
{
  PictureEffect this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  void Delete(int Index);
}