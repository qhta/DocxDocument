using System.Collections.ObjectModel;

namespace ModelDocumentation;
public class Summary: ObservableCollection<string>
{
  public bool IsEmpty => Count == 0;
}
