
namespace DocumentModel.Interop.Core;

public interface TextColumn2: InteropObject
{
  int Number { get; set; }
  float Spacing { get; set; }
  MsoTextDirection TextDirection { get; set; }
}