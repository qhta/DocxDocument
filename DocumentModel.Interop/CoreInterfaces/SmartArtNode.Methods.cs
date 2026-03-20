
namespace DocumentModel.Interop.Core;

public partial interface SmartArtNode
{
  public SmartArtNode AddNode
  (MsoSmartArtNodePosition Position,
    MsoSmartArtNodeType Type);
  public void Delete();
  public void Promote();
  public void Demote();
  public void Larger();
  public void Smaller();
  public void ReorderUp();
  public void ReorderDown();
}
