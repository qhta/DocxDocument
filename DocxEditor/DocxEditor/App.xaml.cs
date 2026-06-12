using System.Configuration;
using System.Data;

using Syncfusion.Licensing;

namespace DocxEditor;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
  /// <summary>
  /// Sets up the application and registers the Syncfusion license key.
  /// </summary>
  public App()
  {
    // Register the Syncfusion license key
    SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JHaF5cWWRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdlWXleeHVVQ2VYWUN0X0dWYEo=");
    //Syncfusion.Diagnostics.DebugLogger.EnableLogging = true;
  }

}

