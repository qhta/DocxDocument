
namespace DocumentModel.Interop.Core;

public interface IMsoDiagram: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  DiagramNodes Nodes { get; }
  MsoDiagramType Type { get; }
  MsoTriState AutoLayout { get; set; }
  MsoTriState Reverse { get; set; }
  MsoTriState AutoFormat { get; set; }
  void Convert(MsoDiagramType Type);
  void FitText();
}