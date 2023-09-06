namespace ModelGenApp.ViewModels;
public class ElementParticleViewModel : ViewModel<ItemElementParticle>
{

  public ElementParticleViewModel(ItemElementParticle elementParticle) : base(elementParticle)
  {
    if (elementParticle.ItemType.Schema != null)
    {
      _DummyItems = new Collection<ViewModel>();
      _DummyItems.Add(new ViewModel());
      _Items = _DummyItems;
    }
  }

  public string? Caption
  {
    get
    {
      var result = Model.ItemType.GetFullName(false, false, false);
      if (Model.AccessProperty != null)
        result = Model.AccessProperty.Name + ": " + result;
      var attribs = new List<string>();
      if (Model.IsRequired)
        attribs.Add("required");
      else
        attribs.Add("optional");
      if (Model.IsMultiple)
        attribs.Add("multiple");
      if (Model.MinOccurs != Model.DefaultMinOccurs)
        attribs.Add($"minOccurs={Model.MinOccurs}");
      if (Model.MaxOccurs != Model.DefaultMaxOccurs)
        attribs.Add($"maxOccurs={Model.MaxOccurs}");
      if (attribs.Count > 0)
        result += " {" + string.Join(" ", attribs) + "}";
      return result;
    }
  }

  public Collection<ViewModel>? Items
  {
    get
    {
      if (_Items == _DummyItems)
      {
        _Items = new Collection<ViewModel>();
        var typeSchema = Model.ItemType.Schema;
        if (typeSchema != null)
        {
          var typeSchemaVM = new ElementSchemaViewModel(typeSchema);
          var items = typeSchemaVM.Items;
          if (items != null)
          {
            if (items.Count()==1 && items[0] is ItemsParticleViewModel subItems)
              items = subItems.Items;
            foreach (var item in items)
            {
              _Items.Add(item);
            }
          }
        }
      }
      return _Items;
    }
  }
  public Collection<ViewModel>? _Items;
  public Collection<ViewModel>? _DummyItems;
}
