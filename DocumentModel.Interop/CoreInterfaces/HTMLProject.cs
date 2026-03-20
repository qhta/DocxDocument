using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface HTMLProject: InteropObject
{
  public MsoHTMLProjectState State { get; }
  public HTMLProjectItems HTMLProjectItems { get; }
}
