using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface PictureEffects
{
  public PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  public void Delete(int Index);
}
