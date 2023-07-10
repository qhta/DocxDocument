namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  public TypeInfoViewModel(TypeInfo typeInfo, bool isOriginal) : base(typeInfo)
  {
    IsOriginal = isOriginal;
    FillTypeSummaryVM();
    ShowTypeCommand = new RelayCommand(ShowTypeExecute, ShowTypeCanExecute) { Name = "ShowTypeCommand" };
  }

  [DataGridColumn]
  public TypeKind TypeKind => Model.TypeKind;

  public bool IsOriginal { get; set; }

  [DataGridColumn]
  public string? Acceptance
  {
    get
    {
      if (Model.IsAccepted)
        return "accepted";
      if (Model.IsRejected)
        return "rejected";
      return null;
    }
  }

  public string? Name
  {
    get
    {
      var name = Model.GetFullName(IsOriginal);
      if (name != null)
      {
        var str = name.ToString();
        var k = str.IndexOf('.');
        var l = str.IndexOf('<');
        if (l == -1)
          l = str.Length;
        if (k != -1 && k < l)
          str = str.Substring(k + 1);
        return str;
      }
      return null;
    }
  }

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.Name", ClipboardContentPath = "Type.Name")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var thisType = this.Model;
      if (thisType!=null)
      {
        if (thisType.TypeKind == TypeKind.Enum)
          return new EnumTypeInfoViewModel(thisType, IsOriginal);
        if (thisType.TypeKind == TypeKind.Type)
          return new TypeInfoViewModel(thisType, IsOriginal);
        return new ClassInfoViewModel(thisType, IsOriginal);
      }
      return null;
    }
  }

  public string? FullName
  {
    get
    {
      return Model.GetFullName(IsOriginal);
    }
  }

  public TypeSummaryViewModel TypeSummaryVM { get; } = new TypeSummaryViewModel();

  private void FillTypeSummaryVM()
  {
    TypeSummaryVM.Clear();
    TypeSummaryVM.Add(new TypePropViewModel("Acceptance", Acceptance));
    TypeSummaryVM.Add(new TypePropViewModel("Kind", TypeKind));
    TypeSummaryVM.Add(new TypePropViewModel("Name", Name));
  }

  /// <summary>
  /// Shown as Window.Title.
  /// </summary>
  public string Caption => TypeKind + " " + Model.GetFullName(IsOriginal);

  public virtual object? Members => null;

  #region ShowTypeCommand
  public Command ShowTypeCommand { get; private set; }

  protected virtual bool ShowTypeCanExecute()
  {
    return Model != null;
  }

  Window? window;
  protected virtual void ShowTypeExecute()
  {
    if (window != null && window.IsVisible)
    {
      window.Topmost = true;
      window.Focus();
    }
    else
    {
      window = new TypeInfoWindow();
      window.DataContext = this;
      window.Show();
    }
  }
  #endregion

}

