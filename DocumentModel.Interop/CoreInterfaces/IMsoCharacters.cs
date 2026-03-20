
namespace DocumentModel.Interop.Core;

public partial interface IMsoCharacters
{
  public string Caption { get; set; }
  public int Count { get; }
  public ChartFont Font { get; }
  public string Text { get; set; }
  public string PhoneticCharacters { get; set; }
}
