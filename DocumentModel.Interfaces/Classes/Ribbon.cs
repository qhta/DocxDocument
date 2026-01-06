namespace DocumentModel;

/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public interface Ribbon
{
  /// <summary>
  ///   startFromScratch
  /// </summary>
  public bool? StartFromScratch { get; set; }
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public QuickAccessToolbar? QuickAccessToolbar { get; set; }
  /// <summary>
  ///   Tabs.
  /// </summary>
  public Tabs? Tabs { get; set; }
  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  public ContextualTabs? ContextualTabs { get; set; }
}