
namespace DocumentModel.Interop.Core;

public interface PickerResult: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Id { get; }
  string DisplayName { get; set; }
  string Type { get; set; }
  string SIPId { get; set; }
  object ItemData { get; set; }
  object SubItems { get; set; }
  object DuplicateResults { get; }
  PickerFields Fields { get; set; }
}