
namespace DocumentModel.Interop.Core;

public interface TextColumn2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int Number { get; set; }
  float Spacing { get; set; }
  MsoTextDirection TextDirection { get; set; }
}