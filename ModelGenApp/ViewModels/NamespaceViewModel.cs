namespace ModelGenApp.ViewModels;
public class NamespaceViewModel: ViewModel
{
  public NamespaceViewModel(PhaseViewModel phaseViewModel, string name)
  {
    Owner = phaseViewModel;
    Name = name;
    _AllTypes = new TypeListViewModel(this, "All types");
  }

  internal PhaseViewModel Owner { get; private set; }


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

  public string Caption => Owner.Name +" "+this.Name;

  public TypeListViewModel AllTypes
  {
    get { return _AllTypes; }
    set
    {
      if (_AllTypes != value)
      {
        _AllTypes = value;
        NotifyPropertyChanged(nameof(AllTypes));
      }
    }
  }
  private TypeListViewModel _AllTypes;

  //public int AllTypesCount =>  AllTypes.Count();

  //public int ClassesCount => AllTypes.Where(item=>item.TypeKind==TypeKind.Class).Count();

  //public int EnumsCount => AllTypes.Where(item=>item.TypeKind==TypeKind.Enum).Count(); 

  //public int InterfacesCount => AllTypes.Where(item=>item.TypeKind==TypeKind.Interface).Count();

  //public int StructsCount => AllTypes.Where(item=>item.TypeKind==TypeKind.Struct).Count();

  //public int OthersCount => AllTypes.Where(item=>item.TypeKind==TypeKind.Type).Count(); 

}
