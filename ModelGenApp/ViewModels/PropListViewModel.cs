﻿namespace ModelGenApp.ViewModels;

/// <summary>
/// This is a container for <see cref="PropInfoViewModel"/>. Can belong to <see cref="ClassInfoViewModel"/>
/// or be used for all properties in all types.
/// </summary>
public class PropListViewModel : ItemListViewModel<PropInfoViewModel>
{
  public PropListViewModel(PhaseResultsViewModel phase, ClassInfoViewModel? owner, string name, TNS typeNameSelector): base(phase, owner, name)
  {
    ShowDisplayOptions = true;
    TypeNameSelector = typeNameSelector; 
    //_Predicate = new Predicate<PropInfoViewModel>(item=> item.Model.IsAcceptedAfter(Phase.PhaseNum));
    //_Predicate = new Predicate<object>(obj=> obj_Predicate.Invoke(obj));
  }

  public TNS TypeNameSelector { [DebuggerStepThrough] get; private set; }

  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        foreach (var prop in this)
          prop.ShowFullTypeName = this.ShowFullTypeName;
      }
    }
  }

  public PropListViewModel Properties => this;

  public PropListViewModel Members => this;

  protected override void ApplyAcceptedOnlyFilter(bool value)
  {
    if (value)
    {
      VisibleItems.Filter = new MemberInfoViewModelFilter(MemberInfoKind.AcceptedMembers, Phase.PhaseNum);
    }
    else
    {
      VisibleItems.Filter = null;
    }
  }

  //Predicate<PropInfoViewModel> IFilter<PropInfoViewModel>.GetPredicate() => _Predicate;

  //bool IFilter<PropInfoViewModel>.Accept(PropInfoViewModel item) => _Predicate.Invoke(item);

  //Predicate<object> IFilter.GetPredicate() => _Predicate;

  //bool IFilter.Accept(object item) => _Predicate.Invoke(item);

  //private Predicate<PropInfoViewModel> _Predicate;

  //private Predicate<object> _Predicate;

  public async void FillItemsAsync()
  {
    await Task.Factory.StartNew(() => FillItems());
  }

  public void FillItems()
  {
    var Source = OwnerType as ClassInfoViewModel;
    if (Source != null)
      FilterItems(Source.Properties);
    else
      CreateItems(GetModelProperties());
  }

  public ClassInfoViewModel? Source => OwnerType as ClassInfoViewModel;

  private IEnumerable<PropInfo> GetModelProperties()
  {
    var props = Source?.Model.Properties?.ToList()
      ?? ModelGen.TypeManager.AllTypes.SelectMany(type=>type.Properties?.Cast<PropInfo>() ?? new PropInfo[0]).ToList();
    //if (Filter != null)
    //    props = props.Where(item => Filter.Predicate(item)).ToList();
    return props;
  }

  private void CreateItems(IEnumerable<PropInfo> props)
  {
    Items.Clear();
      Items.AddRange(props.Select(item => CreateItemViewModel(item, Phase)));
  }

  private void FilterItems(IEnumerable<PropInfoViewModel> props)
  {
    Items.Clear();
    Items.AddRange(props);
  }

  public async void RefreshItemsAsync()
  {
    await Task.Factory.StartNew(() => RefreshItems());
  }

  public void RefreshItems()
  {
    if (Source != null)
      RefreshFilteredItems(Source.Properties);
    else
      RefreshCreatedItems(GetModelProperties());
  }

  private void RefreshCreatedItems(IEnumerable<PropInfo> props)
  {
    var newProps = new List<PropInfo>();
    foreach (var propInfo in props)
      if (!Items.Any(vm => vm.Model == propInfo))
        newProps.Add(propInfo);

    Items.AddRange(newProps.Select(item => CreateItemViewModel(item, Phase)));
  }

  private void RefreshFilteredItems(IEnumerable<PropInfoViewModel> props)
  {
    var newTypes = new List<PropInfoViewModel>();
    foreach (var propInfo in props)
      if (!Items.Any(vm => vm == propInfo))
        newTypes.Add(propInfo);

    Items.AddRange(newTypes);
  }

  protected virtual PropInfoViewModel CreateItemViewModel(PropInfo item, PhaseResultsViewModel phase)
  {
    return new PropInfoViewModel(phase, null, item, TypeNameSelector);
  }

  public bool ShowErrorColumn => VisibleItems.Any(item => item.Model.IsInvalid(this.Phase.PhaseNum));

}
