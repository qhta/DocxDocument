namespace DocumentModel;

/// <summary>
/// Interface used to mark a collection as supporting lazy loading of its elements from an Open XML composite element.
/// </summary>
/// <remarks>When lazy loading is enabled, related data is loaded from the data source on demand rather than
/// being loaded immediately with the main entity. This can improve performance by deferring the loading of related
/// objects until they are accessed, but may result in additional queries to the data source.</remarks>
public interface ILazyLoadable
{
  /// <summary>
  /// Gets or sets a value indicating whether lazy loading is enabled.
  /// </summary>

  public bool IsLazyLoadEnabled { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// ISource of data for lazy loading. This property can be used to specify the data source from which the model element will load its data when lazy loading is enabled.
  /// </summary>
  public object? DataSource { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source and disables lazy loading.
  /// </summary>
  public void TryLazyLoad();
}
