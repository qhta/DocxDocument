
namespace DocumentModel.Interop.Core;

public interface PickerResult: InteropObject
{
  public string Id { get; }
  public string DisplayName { get; set; }
  public string Type { get; set; }
  public string SIPId { get; set; }
  public object ItemData { get; set; }
  public object SubItems { get; set; }
  public object DuplicateResults { get; }
  public PickerFields Fields { get; set; }
}
