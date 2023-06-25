namespace ModelGenApp.ViewModels;
public partial class ProcessOptionsViewModel: ViewModel
{

  public ProcessOptions Options
  {
    get { return _Options; }
    set
    {
      if (_Options != value)
      {
        _Options = value;
        NotifyPropertyChanged(nameof(Options));
      }
    }
  }
  private ProcessOptions _Options;


  public ObservableCollection<string> MainTypeNames
  {
    get { return _MainTypeNames; }
    set
    {
      if (_MainTypeNames != value)
      {
        _MainTypeNames = value;
        NotifyPropertyChanged(nameof(MainTypeNames));
      }
    }
  }
  private ObservableCollection<string> _MainTypeNames;


  public ProcessOptionsViewModel()
  {
    _Options = ProcessOptionsMgr.GetInstance();
    _MainTypeNames = GetMainTypeNames();
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
