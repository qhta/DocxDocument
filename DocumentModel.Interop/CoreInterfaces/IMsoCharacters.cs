
namespace DocumentModel.Interop.Core;

public interface IMsoCharacters
{
  public string Caption { get; set; }
  public int Count { get; }
  public object Delete();
  public ChartFont Font { get; }
  public object Insert(string bstr);
  public string Text { get; set; }
  public string PhoneticCharacters { get; set; }
}
