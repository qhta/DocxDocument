using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface _CustomTaskPane
{
  public string Title { get; }
  public object Window { get; }
  public bool Visible { get; set; }
  public object ContentControl { get; }
  public int Height { get; set; }
  public int Width { get; set; }
  public MsoCTPDockPosition DockPosition { get; set; }
  public MsoCTPDockPositionRestrict DockPositionRestrict { get; set; }
  public void Delete();
}
