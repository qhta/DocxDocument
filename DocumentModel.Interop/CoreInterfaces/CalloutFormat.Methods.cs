
namespace DocumentModel.Interop.Core;

public partial interface CalloutFormat
{
  public void AutomaticLength();
  public void CustomDrop(float Drop);
  public void CustomLength(float Length);
  public void PresetDrop(MsoCalloutDropType DropType);
}
