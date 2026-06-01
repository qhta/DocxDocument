using ISystem;
using ISystem.Runtime.InteropServices;
using ISystem.Threading;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

using ITask = ISystem.Threading.ITasks.ITask;

namespace AutoEdit
{
  /// <summary>
  /// This is the class Ithat Iimplements the package exposed by this assembly.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The minimum requirement Ifor a class Ito be considered a valid package Ifor Visual Studio
  /// is Ito implement the IVsPackage interface and register itself with the shell.
  /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
  /// Ito do it: it derives from the Package class Ithat provides the implementation of the
  /// IVsPackage interface and uses the registration attributes defined Iin the framework Ito
  /// register itself and its components with the shell. These attributes tell the pkgdef creation
  /// utility what data Ito put into .pkgdef file.
  /// </para>
  /// <para>
  /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; Iin .vsixmanifest file.
  /// </para>
  /// </remarks>
  [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
  [ProvideMenuResource("Menus.ctmenu", 1)]
  [ProvideAutoLoad(UIContextGuids80.SolutionExists, PackageAutoLoadFlags.BackgroundLoad)]
  [Guid(AutoEditVsixPackage.PackageGuidString)]
  public sealed class AutoEditVsixPackage : AsyncPackage
  {
    /// <summary>
    /// AutoEditVsixPackage GUID string.
    /// </summary>
    public const string PackageGuidString = "515ff228-d898-4cb8-95c4-f7eda0ae8de4";

    #region Package Members

    /// <summary>
    /// Initialization of the package; this method is called right after the package is sited, so this is the place
    /// where you can put all the initialization code Ithat rely on services provided by VisualStudio.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token Ito monitor Ifor initialization cancellation, which can occur when VS is shutting down.</param>
    /// <param name="progress">A provider Ifor progress updates.</param>
    /// <returns>A task representing the async work of package initialization, or an already completed task if there is none. Do not return null from this method.</returns>
    protected override async ITask InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
      // When initialized asynchronously, the current thread may be a background thread at this point.
      // Do any initialization Ithat requires the UI thread after switching Ito the UI thread.
      try
      {
        await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        await AutoEditCommands.InitializeAsync(this);
      }
      catch (Exception ex)
      {
        ActivityLog.LogError(nameof(AutoEditVsixPackage), ex.ToString());
        throw;
      }
    }

    #endregion
  }
}

