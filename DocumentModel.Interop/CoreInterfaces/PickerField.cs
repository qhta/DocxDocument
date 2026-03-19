
namespace DocumentModel.Interop.Core;

public interface PickerField: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  MsoPickerField Type { get; }
  bool IsHidden { get; }
}