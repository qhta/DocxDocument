using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions_UTManager: InteropObject
{
  public MsoDebugOptions_UTs UnitTests { get; }
  public bool ReportErrors { get; set; }
}
