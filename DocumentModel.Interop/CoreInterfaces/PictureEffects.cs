using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PictureEffects: InteropCollection<PictureEffect>
{
  public PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  public void Delete(int Index);
}
