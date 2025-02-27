namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public class Ribbon: ModelElement
{
  /// <summary>
  ///   startFromScratch
  /// </summary>
  public bool? StartFromScratch { get; set; }

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