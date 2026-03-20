using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PictureEffect: InteropObject
{
  public MsoPictureEffectType Type { get; }
  public int Position { get; set; }
  public void Delete();
  public EffectParameters EffectParameters { get; }
  public MsoTriState Visible { get; set; }
}
