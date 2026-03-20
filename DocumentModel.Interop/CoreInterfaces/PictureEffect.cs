using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface PictureEffect: InteropObject
{
  public MsoPictureEffectType Type { get; }
  public int Position { get; set; }
  public EffectParameters EffectParameters { get; }
  public MsoTriState Visible { get; set; }
}
