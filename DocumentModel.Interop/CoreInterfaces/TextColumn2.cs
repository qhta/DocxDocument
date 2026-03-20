
namespace DocumentModel.Interop.Core;

public interface TextColumn2: InteropObject
{
  public int Number { get; set; }
  public float Spacing { get; set; }
  public MsoTextDirection TextDirection { get; set; }
}
