namespace ModelGenApp.ViewModels;
public class NamespaceViewModel: ViewModel
{
  public NamespaceViewModel(PhaseViewModel phaseViewModel, string name)
  {
    Owner = phaseViewModel;
    Name = name;
    AllTypes = new TypeListViewModel(this, "All types");
    Classes = new ClassListViewModel(this, "Classes");
    Enums = new EnumTypeListViewModel(this, "Enums");
    Interfaces= new ClassListViewModel(this, "Interfaces");
    Structs = new ClassListViewModel(this, "Structs");
    Others= new TypeListViewModel(this, "Others");
  }

  public PhaseViewModel Owner { get; private set; }


  [DataGridColumn]
  public string Name
  {
    get { return _Name; }
    set
    {
      if (_Name != value)
      {
        _Name = value;
        NotifyPropertyChanged(nameof(Name));
      }
    }
  }
  private string _Name = null!;

  public string Caption => Owner.PhaseName +" "+this.Name;

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "AllTypes.Count", ClipboardContentPath = "AllTypes.Count")]
  public TypeListViewModel AllTypes { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "Classes.Count", ClipboardContentPath = "Classes.Count")]
  public TypeListViewModel Classes { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "Enums.Count", ClipboardContentPath = "Enums.Count")]
  public TypeListViewModel Enums { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "Interfaces.Count", ClipboardContentPath = "Interfaces.Count")]
  public TypeListViewModel Interfaces { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "Structs.Count", ClipboardContentPath = "Structs.Count")]
  public TypeListViewModel Structs { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate", 
    SortMemberPath = "Others.Count", ClipboardContentPath = "Others.Count")]
  public TypeListViewModel Others { get; set; }

}
