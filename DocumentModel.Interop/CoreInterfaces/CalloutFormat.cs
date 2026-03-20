
namespace DocumentModel.Interop.Core;

public interface CalloutFormat: InteropObject
{
  public void AutomaticLength();
  public void CustomDrop(float Drop);
  public void CustomLength(float Length);
  public void PresetDrop(MsoCalloutDropType DropType);
  public MsoTriState Accent { get; set; }
  public MsoCalloutAngleType Angle { get; set; }
  public MsoTriState AutoAttach { get; set; }
  public MsoTriState AutoLength { get; }
  public MsoTriState Border { get; set; }
  public float Drop { get; }
  public MsoCalloutDropType DropType { get; }
  public float Gap { get; set; }
  public float Length { get; }
  public MsoCalloutType Type { get; set; }
}
