
namespace DocumentModel.Interop.Core;

public interface BulletFormat2: InteropObject
{
  public int Character { get; set; }
  public Font2 Font { get; }
  public int Number { get; }
  public void Picture(string FileName);
  public float RelativeSize { get; set; }
  public int StartValue { get; set; }
  public MsoNumberedBulletStyle Style { get; set; }
  public MsoBulletType Type { get; set; }
  public MsoTriState UseTextColor { get; set; }
  public MsoTriState UseTextFont { get; set; }
  public MsoTriState Visible { get; set; }
}
