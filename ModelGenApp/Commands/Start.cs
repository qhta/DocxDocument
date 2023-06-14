using ModelGen;

namespace ModelGenApp.Commands
{
  public class Start : ICommand
  {
    public Commander Commander { get; private set; }

    public Start(Commander commander)
    {
      Commander = commander;
    }

    public bool CanExecute(object? parameter)
    {
      return Commander.IsRun != true;
    }

    public void Execute(object? parameter)
    {

    }
#pragma warning disable CS0067
    public event EventHandler? CanExecuteChanged;
  }
}
