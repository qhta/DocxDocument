using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface IFind
{
  public int Show();
  public void Execute();
  public void Load(string bstrQueryName);
  public void Save(string bstrQueryName);
  public void Delete(string bstrQueryName);
}
