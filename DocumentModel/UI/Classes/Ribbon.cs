namespace DocumentModel.UI;

/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public record Ribbon
{
  /// <summary>
  ///   startFromScratch
  /// </summary>
  public Boolean? StartFromScratch { get; set; }

  /// <summary>
  ///   OfficeMenu.
  /// </summary>
  public OfficeMenu? OfficeMenu { get; set; }

  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public QuickAccessToolbar? QuickAccessToolbar { get; set; }

  /// <summary>
  ///   Tabs.
  /// </summary>
  public Tabs? Tabs { get; set; }

  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  public ContextualTabSets? ContextualTabSets { get; set; }
}