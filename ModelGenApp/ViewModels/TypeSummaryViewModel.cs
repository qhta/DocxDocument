namespace ModelGenApp.ViewModels;
public class TypeSummaryViewModel: ObservableList<TypePropViewModel>
{
  public bool IsEmpty => Count==0;
}
