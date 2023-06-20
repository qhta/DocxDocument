namespace ModelGenApp.ViewModels;
public partial class ProcessOptionsViewModel: ObservableObject
{
  [ObservableProperty]
  private ProcessOptions options;

  [ObservableProperty]
  private ObservableCollection<string> mainTypeNames;

  public ProcessOptionsViewModel()
  {
    options = ProcessOptionsMgr.GetInstance();
    mainTypeNames = GetMainTypeNames();
  }

  private ObservableCollection<string> GetMainTypeNames()
  {
    var assembly = Assembly.Load("DocumentFormat.OpenXml");
    var typeNames = assembly.GetTypes().Where(type => !type.IsCompilerGenerated() && !type.IsAbstract)
    .Select(type => type.FullName ?? "")
    .Where(name=>name.StartsWith("DocumentFormat.OpenXml.Packaging")).ToList();
    typeNames.Sort();
    var sortedTypeNames = typeNames.Where(name=>name.EndsWith("Document")).ToList();
    sortedTypeNames.AddRange(typeNames.Where(name=>name.EndsWith("Part")).ToList());
    return new ObservableCollection<string>(sortedTypeNames);
  }
}
