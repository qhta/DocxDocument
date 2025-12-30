using System.Configuration;
using System.Data;
using System.Windows;
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
    SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF5cXGpCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWH1fd3RcR2hYU0R3XEFWYEs=");
    //Syncfusion.Diagnostics.DebugLogger.EnableLogging = true;
  }

}

