
namespace DocumentModel.Interop.Core;

public interface BulletFormat2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Character { get; set; }
  Font2 Font { get; }
  int Number { get; }
  void Picture(string FileName);
  float RelativeSize { get; set; }
  int StartValue { get; set; }
  MsoNumberedBulletStyle Style { get; set; }
  MsoBulletType Type { get; set; }
  MsoTriState UseTextColor { get; set; }
  MsoTriState UseTextFont { get; set; }
  MsoTriState Visible { get; set; }
}