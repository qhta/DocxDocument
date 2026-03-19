
namespace DocumentModel.Interop.Core;

public interface PickerProperty: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Id { get; }
  object Value { get; }
  MsoPickerField Type { get; }
}