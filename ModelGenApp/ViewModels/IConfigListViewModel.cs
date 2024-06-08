namespace ModelGenApp.ViewModels;

/// <summary>
/// Interface of generic class ConfigListViewModel(T)
/// </summary>
public interface IConfigListViewModel
{
  /// <summary>
  /// Abstract method to recreate items. Invoked when other list is changed.
  /// </summary>
  public void RefreshData();

  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command StoreDataCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// A command to restore config data.
  /// </summary>
  public Command RestoreDataCommand { [DebuggerStepThrough] get; }

}
