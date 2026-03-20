
namespace DocumentModel.Interop.Core;

public interface SmartArt: InteropObject
{
  SmartArtNodes AllNodes { get; }
  SmartArtNodes Nodes { get; }
  SmartArtLayout Layout { get; set; }
  SmartArtQuickStyle QuickStyle { get; set; }
  SmartArtColor Color { get; set; }
  MsoTriState Reverse { get; set; }
  void Reset();
}