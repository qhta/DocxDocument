using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PictureEffect: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoPictureEffectType Type { get; }
  int Position { get; set; }
  void Delete();
  EffectParameters EffectParameters { get; }
  MsoTriState Visible { get; set; }
}