namespace ModelGenApp.ViewModels;
public class ElementSchemaViewModel : ViewModel<ElementSchema>
{
  public ElementSchemaViewModel(ElementSchema elementSchema, string? name = null) : base(elementSchema)
  { 
    Name = name;
  }



  public string? Name
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
  private string? _Name;

  /// <summary>
  /// Attribute/Element tag in schema.
  /// </summary>
  public string? Tag => Model.SchemaTag;

  /// <summary>
  /// SchemaTag is attrib
  /// </summary>
  public bool IsAttrib => Model.SchemaIsAttrib;

  public string? Caption => Name ?? ((IsAttrib) ? $"<attribute name={Tag}>" : $"<element name={Tag}>");

  public ViewModel? Main
  {
    get
    {
      if (_Main == null && Model.Main != null)
      {
        if (Model.Main is ItemElementParticle itemElement)
        {
          var elementVM = new ElementParticleViewModel(itemElement);
          elementVM.Name = Name;
          _Main = elementVM;
        }
        else
       if (Model.Main is ItemsParticle itemsParticle)
        {
          var itemsVM = new ItemsParticleViewModel(itemsParticle);
          itemsVM.Name = Name;
          _Main = itemsVM;
        }
      }
      return _Main;
    }
  }
  public ViewModel? _Main;

  public Collection<ViewModel>? Items
  {
    get
    {
      if (_Items == null && Model.Main != null)
      {
        var main = Main;
        if (main != null)
          _Items = new Collection<ViewModel>{ main };
      }
      return _Items;
    }
  }
  public Collection<ViewModel>? _Items;


}
