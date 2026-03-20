using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PictureEffect: InteropObject
{
  MsoPictureEffectType Type { get; }
  int Position { get; set; }
  void Delete();
  EffectParameters EffectParameters { get; }
  MsoTriState Visible { get; set; }
}