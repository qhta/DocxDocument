
namespace DocumentModel.Interop.Core;

public interface IMsoCharacters
{
  string Caption { get; set; }
  int Count { get; }
  object Delete();
  ChartFont Font { get; }
  object Insert(string bstr);
  string Text { get; set; }
  string PhoneticCharacters { get; set; }
}