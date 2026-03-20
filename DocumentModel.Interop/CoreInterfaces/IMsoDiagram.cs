
namespace DocumentModel.Interop.Core;

public interface IMsoDiagram: InteropObject
{
  DiagramNodes Nodes { get; }
  MsoDiagramType Type { get; }
  MsoTriState AutoLayout { get; set; }
  MsoTriState Reverse { get; set; }
  MsoTriState AutoFormat { get; set; }
  void Convert(MsoDiagramType Type);
  void FitText();
}