
namespace DocumentModel.Interop.Core;

public interface ODSOFilter: InteropObject
{
  public int Index { get; }
  public string Column { get; set; }
  public MsoFilterComparison Comparison { get; set; }
  public string CompareTo { get; set; }
  public MsoFilterConjunction Conjunction { get; set; }
}
