
namespace ModelGenApp.ViewModels;
public partial class PhaseProgressViewModel : ViewModel
{
  public int InnerHeight
  {
    get { return _InnerHeight; }
    set
    {
      if (_InnerHeight != value)
      {
        _InnerHeight = value;
        NotifyPropertyChanged(nameof(InnerHeight));
      }
    }
  }
  private int _InnerHeight;
}
