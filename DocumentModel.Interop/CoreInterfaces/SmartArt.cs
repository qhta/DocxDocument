
namespace DocumentModel.Interop.Core;

public partial interface SmartArt: InteropObject
{
  public SmartArtNodes AllNodes { get; }
  public SmartArtNodes Nodes { get; }
  public SmartArtLayout Layout { get; set; }
  public SmartArtQuickStyle QuickStyle { get; set; }
  public SmartArtColor Color { get; set; }
  public MsoTriState Reverse { get; set; }
}
