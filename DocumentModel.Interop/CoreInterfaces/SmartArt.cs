
namespace DocumentModel.Interop.Core;

public interface SmartArt: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  SmartArtNodes AllNodes { get; }
  SmartArtNodes Nodes { get; }
  SmartArtLayout Layout { get; set; }
  SmartArtQuickStyle QuickStyle { get; set; }
  SmartArtColor Color { get; set; }
  MsoTriState Reverse { get; set; }
  void Reset();
}