using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PictureEffects: InteropCollection<PictureEffect>
{
  PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  void Delete(int Index);
}