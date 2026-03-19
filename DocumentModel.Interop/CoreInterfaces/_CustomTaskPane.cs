using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface _CustomTaskPane
{
  string Title { get; }
  object Application { get; }
  object Window { get; }
  bool Visible { get; set; }
  object ContentControl { get; }
  int Height { get; set; }
  int Width { get; set; }
  MsoCTPDockPosition DockPosition { get; set; }
  MsoCTPDockPositionRestrict DockPositionRestrict { get; set; }
  void Delete();
}