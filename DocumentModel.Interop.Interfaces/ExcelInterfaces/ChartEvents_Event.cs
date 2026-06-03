using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComEventInterface(typeof(ChartEvents), typeof(ChartEvents_EventProvider))]
[TypeLibType(TypeLibTypeFlags.FHidden)]
[ComVisible(false)]
public interface ChartEvents_Event
{
  event ChartEvents_ActivateEventHandler Activate;
  event ChartEvents_DeactivateEventHandler Deactivate;
  event ChartEvents_ResizeEventHandler Resize;
  event ChartEvents_MouseDownEventHandler MouseDown;
  event ChartEvents_MouseUpEventHandler MouseUp;
  event ChartEvents_MouseMoveEventHandler MouseMove;
  event ChartEvents_BeforeRightClickEventHandler BeforeRightClick;
  event ChartEvents_DragPlotEventHandler DragPlot;
  event ChartEvents_DragOverEventHandler DragOver;
  event ChartEvents_BeforeDoubleClickEventHandler BeforeDoubleClick;
  event ChartEvents_SelectEventHandler Select;
  event ChartEvents_SeriesChangeEventHandler SeriesChange;
  event ChartEvents_CalculateEventHandler Calculate;
  event ChartEvents_RemoteResizeEventHandler RemoteResize;
  event ChartEvents_RemoteSeriesChangeEventHandler RemoteSeriesChange;
}