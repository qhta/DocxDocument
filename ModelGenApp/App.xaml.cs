namespace ModelGenApp;

public partial class App : Application
{
  public App()
  {
    GC.Collect();
    CultureInfo.CurrentUICulture = new CultureInfo("pl-PL");
    Command.CommandManager = new CommandManagerBridge();
  }

}
