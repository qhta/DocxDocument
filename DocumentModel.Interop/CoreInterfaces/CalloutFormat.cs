
namespace DocumentModel.Interop.Core;

public interface CalloutFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void AutomaticLength();
  void CustomDrop(float Drop);
  void CustomLength(float Length);
  void PresetDrop(MsoCalloutDropType DropType);
  MsoTriState Accent { get; set; }
  MsoCalloutAngleType Angle { get; set; }
  MsoTriState AutoAttach { get; set; }
  MsoTriState AutoLength { get; }
  MsoTriState Border { get; set; }
  float Drop { get; }
  MsoCalloutDropType DropType { get; }
  float Gap { get; set; }
  float Length { get; }
  MsoCalloutType Type { get; set; }
}