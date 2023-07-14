using ModelGen;

namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  public TypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo)
  {
    Original = original;
    FillTypeSummaryVM();
    ShowTypeCommand = new RelayCommand(ShowTypeExecute, ShowTypeCanExecute) { Name = "ShowTypeCommand" };
  }

  [DataGridColumn]
  public TypeKind TypeKind => Model.TypeKind;

  public bool Original { get; set; }

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

  public string? Validity
  {
    get
    {
      if (Model.IsValid)
        return "valid";
      if (Model.IsInvalid)
        return "invalid";
      return null;
    }
  }

  public string? Name
  {
    get
    {
      var name = Model.GetFullName(Original);
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

  public string? TargetName
  {
    get
    {
      return Model.NewName;
    }
  }

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.Name", ClipboardContentPath = "Type.Name")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var thisType = this.Model;
      if (thisType != null)
      {
        if (thisType.TypeKind == TypeKind.Enum)
          return new EnumTypeInfoViewModel(thisType, Original);
        if (thisType.TypeKind == TypeKind.Type)
          return new TypeInfoViewModel(thisType, Original);
        return new ClassInfoViewModel(thisType, Original);
      }
      return null;
    }
  }

  public string? FullName
  {
    get
    {
      return Model.GetFullName(Original);
    }
  }

  public TypeSummaryViewModel TypeSummaryVM { get; } = new TypeSummaryViewModel();

  protected virtual void FillTypeSummaryVM()
  {
    TypeSummaryVM.Clear();
    TypeSummaryVM.Add(new TypePropViewModel("Acceptance", Acceptance, Model.IsRejected));
    TypeSummaryVM.Add(new TypePropViewModel("Validity", Validity, Model.IsInvalid));
    TypeSummaryVM.Add(new TypePropViewModel("Kind", TypeKind.ToString().ToLower()));
    TypeSummaryVM.Add(new TypePropViewModel("Namespace", Model.OriginalNamespace));
    TypeSummaryVM.Add(new TypePropViewModel("Name", Name));
    if (!String.IsNullOrEmpty(Model.TargetNamespace))
      TypeSummaryVM.Add(new TypePropViewModel("Target namespace", Model.TargetNamespace));
    if (!String.IsNullOrEmpty(Model.NewName))
      TypeSummaryVM.Add(new TypePropViewModel("New name", Model.NewName));
    if (Model.IsConverted)
    {
      var targetType = Model.GetConversionTarget();
      if (targetType != null)
        TypeSummaryVM.Add(new TypePropViewModel("Converted to", new TypeInfoViewModel(targetType, true)));
    }
    TypeSummaryVM.Add(new TypePropViewModel("Description", Model.Description));
  }

  /// <summary>
  /// Shown as Window.Title.
  /// </summary>
  public string Caption => TypeKind + " " + Model.GetFullName(Original);

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

