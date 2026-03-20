using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentProperty
{
  public void Delete();
  public string Name { get; set; }
  public object Value { get; set; }
  public MsoDocProperties Type { get; set; }
  public bool LinkToContent { get; set; }
  public string LinkSource { get; set; }
}
