namespace ModelGenApp.ViewModels;
public class ElementSchemaViewModel : ViewModel<ElementSchema>
{
  public ElementSchemaViewModel(ElementSchema elementSchema) : base(elementSchema)
  { }


  /// <summary>
  /// Attribute/Element tag in schema.
  /// </summary>
  public string? Tag => Model.SchemaTag;

  /// <summary>
  /// SchemaTag is attrib
  /// </summary>
  public bool IsAttrib => Model.SchemaIsAttrib;

  public string? Caption => (IsAttrib) ? $"<attribute name={Tag}>" : $"<element name={Tag}>";

  public ViewModel? Main
  {
    get
    {
      if (_Main == null && Model.Main != null)
      {
        if (Model.Main is ItemElementParticle itemElement)
          _Main = new ElementParticleViewModel(itemElement);
        else
       if (Model.Main is ItemsParticle itemsParticle)
          _Main = new ItemsParticleViewModel(itemsParticle);
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
