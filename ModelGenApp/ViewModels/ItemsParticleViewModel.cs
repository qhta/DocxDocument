namespace ModelGenApp.ViewModels;
public class ItemsParticleViewModel : ViewModel<ItemsParticle>
{
  public ItemsParticleViewModel(ItemsParticle itemsParticle) : base(itemsParticle)
  { }

  public string? Caption
  {
    get
    {
      var result = Model.ParticleType.ToString().ToLower();
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

  public Collection<ViewModel> Items
  {
    get
    {
      if (_Items == null)
      {
        _Items = new Collection<ViewModel>();
        foreach (var item in Model.Items)
        {
          if (item is ItemElementParticle itemElement)
           _Items.Add(new ElementParticleViewModel(itemElement));
          else
         if (item is ItemsParticle itemsParticle)
            _Items.Add(new ItemsParticleViewModel(itemsParticle));
        }
      }
      return _Items;
    }
  }
  public Collection<ViewModel>? _Items;

}
