using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DocumentProperty
{
  public string Name { get; set; }
  public object Value { get; set; }
  public MsoDocProperties Type { get; set; }
  public bool LinkToContent { get; set; }
  public string LinkSource { get; set; }
}
