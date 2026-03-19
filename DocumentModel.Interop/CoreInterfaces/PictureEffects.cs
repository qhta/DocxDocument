using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PictureEffects: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  PictureEffect this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  void Delete(int Index);
}